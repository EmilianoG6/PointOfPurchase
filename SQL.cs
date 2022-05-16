using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PIA_PoP
{
    public class SQL
    {
        string connectionString = @"Data Source=DESKTOP-EMI4280\SQLEXPRESS;Initial Catalog=PoP;User ID=sa;Password=admin";
        public bool GetConnection()
        {
            try
            {
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public List<Venta> ReadVentas()
        {
            List<Venta> ventasList = new List<Venta>();
            string query = "EXEC ReadVenta";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                try {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Venta venta = new Venta();
                        venta.IDTicket = reader.GetInt32(0);
                        venta.IDCliente = reader.GetInt32(1);
                        venta.IDEmpleado = reader.GetInt32(2);
                        venta.FechaVenta = reader.GetDateTime(3);
                        venta.HoraVenta = reader.GetTimeSpan(4);
                        ventasList.Add(venta);
                    }
                    reader.Close();
                }
                catch(Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
            return ventasList;
        }

        public List<Producto> ReadProductos()
        {
            List<Producto> productosList = new List<Producto>();
            string query = "EXEC ReadProductos";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                try
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Producto producto = new Producto();
                        producto.IDProducto = reader.GetInt32(0);
                        producto.IDCategoria = reader.GetInt32(1);
                        producto.IDMarca = reader.GetInt32(2);
                        producto.IDProveedor = reader.GetInt32(3);
                        producto.IDUnidad = reader.GetInt32(4);
                        producto.Descripcion = reader.GetString(5);
                        producto.PrecioUnitario = reader.GetInt32(6);
                        producto.UnidadEnStock = reader.GetInt32(7);
                        producto.Descontinuado = reader.GetBoolean(8);
                        productosList.Add(producto);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
            return productosList;
        }

    }

    public class Venta
    {
        public int IDTicket { get; set; }
        public int IDCliente { get; set; }
        public int IDEmpleado { get; set; }
        public DateTime FechaVenta { get; set; }
        public TimeSpan HoraVenta { get; set; }
    }

    public class Producto
    {
        public int IDProducto { get; set; }
        public int IDCategoria { get; set; }
        public int IDMarca{ get; set; }
        public int IDProveedor { get; set; }
        public int IDUnidad { get; set; }
        public string? Descripcion { get; set; }
        public int PrecioUnitario { get; set; }
        public int UnidadEnStock { get; set; }
        public bool Descontinuado { get; set; }
    }
}
