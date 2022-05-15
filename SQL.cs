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
    }

    public class Venta
    {
        public int IDTicket { get; set; }
        public int IDCliente { get; set; }
        public int IDEmpleado { get; set; }
        public DateTime FechaVenta { get; set; }
        public TimeSpan HoraVenta { get; set; }

    }
}
