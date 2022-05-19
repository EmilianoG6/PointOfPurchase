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

        public List<Empresa> ReadEmpresa()
        {
            List<Empresa> empresaList = new List<Empresa>();
            string query = "SELECT NombreEmpresa, Slogan, Fundador, Telefono, Estado, Ciudad, CodigoPostal, Calle, CodigoIdentificacionFiscal FROM Empresa";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                try
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Empresa empresa = new Empresa();
                        empresa.NombreEmpresa = reader.GetString(0);
                        empresa.Slogan = reader.GetString(1);
                        empresa.Fundador = reader.GetString(2);
                        empresa.Telefono = reader.GetString(3);
                        empresa.Estado = reader.GetString(4);
                        empresa.Ciudad = reader.GetString(5);
                        empresa.CodigoPostal = reader.GetInt32(6);
                        empresa.Calle = reader.GetString(7);
                        empresa.CodigoIdentificacionFiscal = reader.GetString(8);
                        empresaList.Add(empresa);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
            return empresaList;
        }

        public List<Venta> ReadVentas()
        {
            List<Venta> ventasList = new List<Venta>();
            string query = "EXEC ReadVentas";
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

        public Venta LoadVenta(int ID)
        {
            Venta venta = new Venta();
            string query = "SELECT IDTicket, IDCliente, IDEmpleado, FechaVenta FROM Venta WHERE IDTicket = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", ID);
                try
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();                    
                    venta.IDTicket = reader.GetInt32(0);
                    venta.IDCliente = reader.GetInt32(1);
                    venta.IDEmpleado = reader.GetInt32(2);
                    venta.FechaVenta = reader.GetDateTime(3);
                    reader.Close();
                    return venta;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }            
        }

        public void CreateVenta(int IDCliente, int IDEmpleado, DateTime FechaVenta)
        {
            string query = "INSERT INTO Venta (IDCliente, IDEmpleado, FechaVenta) VALUES (@IDCliente, @IDEmpleado, @FechaVenta)";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@IDCliente", IDCliente);
                cmd.Parameters.AddWithValue("@IDEmpleado", IDEmpleado);
                cmd.Parameters.AddWithValue("@FechaVenta", FechaVenta);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void UpdateVenta(int IDTicket, int IDCliente, int IDEmpleado, DateTime FechaVenta)
        {
            string query = "UPDATE Venta SET IDCliente = @IDCliente, IDEmpleado = @IDEmpleado, FechaVenta = @FechaVenta WHERE IDTicket = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", IDTicket);
                cmd.Parameters.AddWithValue("@IDCliente", IDCliente);
                cmd.Parameters.AddWithValue("@IDEmpleado", IDEmpleado);
                cmd.Parameters.AddWithValue("@FechaVenta", FechaVenta);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void DeleteVenta(int IDTicket)
        {
            string query = "DELETE FROM Venta WHERE IDTicket = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", IDTicket);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public List<DetalleTicket> ReadDetalleTickets()
        {
            List<DetalleTicket> detalleTicketsList = new List<DetalleTicket>();
            string query = "EXEC ReadDetalleTicket";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                try
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DetalleTicket detalleTicket = new DetalleTicket();
                        detalleTicket.IDTicket = reader.GetInt32(0);
                        detalleTicket.IDProducto = reader.GetInt32(1);
                        detalleTicket.PrecioUnitario = reader.GetInt32(2);
                        detalleTicket.Cantidad = reader.GetInt32(3);
                        detalleTicketsList.Add(detalleTicket);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
            return detalleTicketsList;
        }

        public DetalleTicket LoadDetalleTicket(int ID)
        {
            DetalleTicket detalleTicket = new DetalleTicket();
            string query = "SELECT IDTicket, IDProducto, PrecioUnitario, Cantidad FROM DetalleTicket WHERE IDTicket = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", ID);
                try
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    detalleTicket.IDTicket = reader.GetInt32(0);
                    detalleTicket.IDProducto = reader.GetInt32(1);
                    detalleTicket.PrecioUnitario = reader.GetInt32(2);
                    detalleTicket.Cantidad = reader.GetInt32(3);
                    reader.Close();
                    return detalleTicket;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void CreateDetalleTicket(int IDTicket, int IDProducto, int PrecioUnitario, int Cantidad)
        {
            string query = "INSERT INTO DetalleTicket (IDTicket, IDProducto, PrecioUnitario, Cantidad) VALUES (@IDTicket, @IDProducto, @PrecioUnitario, @Cantidad)";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@IDTicket", IDTicket);
                cmd.Parameters.AddWithValue("@IDProducto", IDProducto);
                cmd.Parameters.AddWithValue("@PrecioUnitario", PrecioUnitario);
                cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void DeleteDetalleTicket(int IDTicket)
        {
            string query = "DELETE FROM DetalleTicket WHERE IDTicket = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", IDTicket);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public List<Factura> ReadFacturas()
        {
            List<Factura> facturasList = new List<Factura>();
            string query = "EXEC ReadFacturas";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                try
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Factura factura = new Factura();
                        factura.IDFactura = reader.GetInt32(0);
                        factura.IDTicket = reader.GetInt32(1);
                        factura.IDCliente = reader.GetInt32(2);
                        factura.Nombre = reader.GetString(3);
                        factura.FechaFactura = reader.GetDateTime(4);
                        facturasList.Add(factura);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
            return facturasList;
        }

        public Factura LoadFactura(int ID)
        {
            Factura factura = new Factura();
            string query = "SELECT IDFactura, IDTicket, IDCliente, Nombre, FechaFactura FROM Factura WHERE IDFactura = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", ID);
                try
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    factura.IDFactura = reader.GetInt32(0);
                    factura.IDTicket = reader.GetInt32(1);
                    factura.IDCliente = reader.GetInt32(2);
                    factura.Nombre = reader.GetString(3);
                    factura.FechaFactura = reader.GetDateTime(4);
                    reader.Close();
                    return factura;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void CreateFactura(int IDTicket, int IDCliente, string Nombre, DateTime FechaFactura)
        {
            string query = "INSERT INTO Factura (IDTicket, IDCliente, Nombre, FechaFactura) VALUES (@IDTicket, @IDCliente, @Nombre, @FechaFactura)";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@IDTicket", IDTicket);
                cmd.Parameters.AddWithValue("@IDCliente", IDCliente);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@FechaFactura", FechaFactura);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void UpdateFactura(int IDFactura, int IDTicket, int IDCliente, string Nombre, DateTime FechaFactura)
        {
            string query = "UPDATE Factura SET IDTicket = @IDTicket, IDCliente = @IDCliente, Nombre = @Nombre, FechaFactura = @FechaFactura WHERE IDFactura = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", IDFactura);
                cmd.Parameters.AddWithValue("@IDTicket", IDTicket);
                cmd.Parameters.AddWithValue("@IDCliente", IDCliente);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@FechaFactura", FechaFactura);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void DeleteFactura(int IDFactura)
        {
            string query = "DELETE FROM Factura WHERE IDFactura = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", IDFactura);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public List<DetalleFactura> ReadDetalleFacturas()
        {
            List<DetalleFactura> detalleFacturasList = new List<DetalleFactura>();
            string query = "EXEC ReadDetalleFactura";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                try
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DetalleFactura detalleFactura = new DetalleFactura();
                        detalleFactura.IDFactura = reader.GetInt32(0);
                        detalleFactura.IDProducto = reader.GetInt32(1);
                        detalleFactura.PrecioUnitario = reader.GetInt32(2);
                        detalleFactura.Cantidad = reader.GetInt32(3);
                        detalleFacturasList.Add(detalleFactura);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
            return detalleFacturasList;
        }

        public DetalleFactura LoadDetalleFactura(int ID)
        {
            DetalleFactura detalleFactura = new DetalleFactura();
            string query = "SELECT IDFactura, IDProducto, PrecioUnitario, Cantidad FROM DetalleFactura WHERE IDFactura = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", ID);
                try
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    detalleFactura.IDFactura = reader.GetInt32(0);
                    detalleFactura.IDProducto = reader.GetInt32(1);
                    detalleFactura.PrecioUnitario = reader.GetInt32(2);
                    detalleFactura.Cantidad = reader.GetInt32(3);
                    reader.Close();
                    return detalleFactura;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void CreateDetalleFactura(int IDFactura, int IDProducto, int PrecioUnitario, int Cantidad)
        {
            string query = "INSERT INTO DetalleFactura (IDFactura, IDProducto, PrecioUnitario, Cantidad) VALUES (@IDFactura, @IDProducto, @PrecioUnitario, @Cantidad)";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@IDFactura", IDFactura);
                cmd.Parameters.AddWithValue("@IDProducto", IDProducto);
                cmd.Parameters.AddWithValue("@PrecioUnitario", PrecioUnitario);
                cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void DeleteDetalleFactura(int IDFactura)
        {
            string query = "DELETE FROM DetalleFactura WHERE IDFactura = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", IDFactura);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public List<Orden> ReadOrdenes()
        {
            List<Orden> ordenesList = new List<Orden>();
            string query = "EXEC ReadOrdenes";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                try
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Orden orden = new Orden();
                        orden.IDOrdenCompra = reader.GetInt32(0);
                        orden.IDProveedor = reader.GetInt32(1);
                        orden.FechaOrden = reader.GetDateTime(2);
                        ordenesList.Add(orden);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
            return ordenesList;
        }

        public Orden LoadOrden(int ID)
        {
            Orden orden = new Orden();
            string query = "SELECT IDOrdenCompra, IDProveedor, FechaOrden FROM OrdenCompra WHERE IDOrdenCompra = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", ID);
                try
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    orden.IDOrdenCompra = reader.GetInt32(0);
                    orden.IDProveedor = reader.GetInt32(1);
                    orden.FechaOrden = reader.GetDateTime(2);
                    reader.Close();
                    return orden;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void CreateOrden(int IDProveedor, DateTime FechaOrden)
        {
            string query = "INSERT INTO OrdenCompra (IDProveedor, FechaOrden) VALUES (@IDProveedor, @FechaOrden)";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@IDProveedor", IDProveedor);
                cmd.Parameters.AddWithValue("@FechaOrden", FechaOrden);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void UpdateOrden(int IDOrdenCompra, int IDProveedor, DateTime FechaOrden)
        {
            string query = "UPDATE OrdenCompra SET IDProveedor = @IDProveedor, FechaOrden = @FechaOrden WHERE IDOrdenCompra = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", IDOrdenCompra);
                cmd.Parameters.AddWithValue("@IDProveedor", IDProveedor);
                cmd.Parameters.AddWithValue("@FechaOrden", FechaOrden);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void DeleteOrden(int IDOrdenCompra)
        {
            string query = "DELETE FROM OrdenCompra WHERE IDOrdenCompra = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", IDOrdenCompra);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public List<DetalleOrden> ReadDetalleOrdenes()
        {
            List<DetalleOrden> detalleOrdenesList = new List<DetalleOrden>();
            string query = "EXEC ReadDetalleOrdenCompra";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                try
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DetalleOrden detalleOrden = new DetalleOrden();
                        detalleOrden.IDOrdenCompra = reader.GetInt32(0);
                        detalleOrden.IDProducto = reader.GetInt32(1);
                        detalleOrden.NombreMarca = reader.GetString(2);
                        detalleOrden.Costo = reader.GetInt32(3);
                        detalleOrden.Cantidad = reader.GetInt32(4);
                        detalleOrdenesList.Add(detalleOrden);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
            return detalleOrdenesList;
        }

        public DetalleOrden LoadDetalleOrden(int ID)
        {
            DetalleOrden detalleOrden = new DetalleOrden();
            string query = "SELECT IDOrdenCompra, IDProducto, NombreMarca, Costo, Cantidad FROM DetalleOrdenCompra WHERE IDOrdenCompra = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", ID);
                try
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    detalleOrden.IDOrdenCompra = reader.GetInt32(0);
                    detalleOrden.IDProducto = reader.GetInt32(1);
                    detalleOrden.NombreMarca = reader.GetString(2);
                    detalleOrden.Costo = reader.GetInt32(3);
                    detalleOrden.Cantidad = reader.GetInt32(4);
                    reader.Close();
                    return detalleOrden;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void CreateDetalleOrden(int IDOrdenCompra, int IDProducto, string NombreMarca, int Costo, int Cantidad)
        {
            string query = "INSERT INTO DetalleOrdenCompra (IDOrdenCompra, IDProducto, NombreMarca, Costo, Cantidad) VALUES (@IDOrdenCompra, @IDProducto, @NombreMarca, @Costo, @Cantidad)";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@IDOrdenCompra", IDOrdenCompra);
                cmd.Parameters.AddWithValue("@IDProducto", IDProducto);
                cmd.Parameters.AddWithValue("@NombreMarca", NombreMarca);
                cmd.Parameters.AddWithValue("@Costo", Costo);
                cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void DeleteDetalleOrden(int IDOrdenCompra)
        {
            string query = "DELETE FROM DetalleOrdenCompra WHERE IDOrdenCompra = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", IDOrdenCompra);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
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

        public Producto LoadProducto(int ID)
        {
            Producto producto = new Producto();
            string query = "SELECT IDProducto, IDCategoria, IDMarca, IDProveedor, IDUnidad, Descripcion, PrecioUnitario, UnidadEnStock, Descontinuado FROM Producto WHERE IDProducto = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", ID);
                try
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();                    
                    producto.IDProducto = reader.GetInt32(0);
                    producto.IDCategoria = reader.GetInt32(1);
                    producto.IDMarca = reader.GetInt32(2);
                    producto.IDProveedor = reader.GetInt32(3);
                    producto.IDUnidad = reader.GetInt32(4);
                    producto.Descripcion = reader.GetString(5);                    
                    producto.PrecioUnitario = reader.GetInt32(6);
                    producto.UnidadEnStock = reader.GetInt32(7);
                    producto.Descontinuado = reader.GetBoolean(8);
                    reader.Close();
                    return producto;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }        

        public void CreateProducto(int IDCategoria, int IDMarca, int IDProveedor, int IDUnidad, string Descripcion, int PrecioUnitario, int UnidadEnStock, bool Descontinuado)
        {
            string query = "INSERT INTO Producto (IDCategoria, IDMarca, IDProveedor, IDUnidad, Descripcion, PrecioUnitario, UnidadEnStock, Descontinuado) VALUES (@IDProducto, @IDCategoria, @IDMarca, @IDProveedor, @IDUnidad, @Descripcion, @PrecioUnitario, @UnidadEnStock, @Descontinuado)";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@IDCategoria", IDCategoria);
                cmd.Parameters.AddWithValue("@IDMarca", IDMarca);
                cmd.Parameters.AddWithValue("@IDProveedor", IDProveedor);
                cmd.Parameters.AddWithValue("@IDUnidad", IDUnidad);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                cmd.Parameters.AddWithValue("@PrecioUnitario", PrecioUnitario);
                cmd.Parameters.AddWithValue("@UnidadEnStock", UnidadEnStock);
                cmd.Parameters.AddWithValue("@Descontinuado", Descontinuado);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void UpdateProducto(int IDProducto, int IDCategoria, int IDMarca, int IDProveedor, int IDUnidad, string Descripcion, int PrecioUnitario, int UnidadEnStock, bool Descontinuado)
        {
            string query = "UPDATE Producto SET IDCategoria = @IDCategoria, IDMarca = @IDMarca, IDProveedor = @IDProveedor, IDUnidad = @IDUnidad, Descripcion = @Descripcion, PrecioUnitario = @PrecioUnitario, UnidadEnStock = @UnidadEnStock, Descontinuado = @Descontinuado WHERE IDProducto = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", IDProducto);
                cmd.Parameters.AddWithValue("@IDCategoria", IDCategoria);
                cmd.Parameters.AddWithValue("@IDMarca", IDMarca);
                cmd.Parameters.AddWithValue("@IDProveedor", IDProveedor);
                cmd.Parameters.AddWithValue("@IDUnidad", IDUnidad);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                cmd.Parameters.AddWithValue("@PrecioUnitario", PrecioUnitario);
                cmd.Parameters.AddWithValue("@UnidadEnStock", UnidadEnStock);
                cmd.Parameters.AddWithValue("@Descontinuado", Descontinuado);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void DeleteProducto(int IDProducto)
        {
            string query = "DELETE FROM Producto WHERE IDProducto = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", IDProducto);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public List<Empleado> ReadEmpleados()
        {
            List<Empleado> empleadosList = new List<Empleado>();
            string query = "EXEC ReadEmpleados";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                try
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Empleado empleado = new Empleado();
                        empleado.IDEmpleado = reader.GetInt32(0);
                        empleado.IDArea = reader.GetInt32(1);
                        empleado.NombreEmp = reader.GetString(2);
                        empleado.ApellidoEmp = reader.GetString(3);
                        empleado.SexoEmp = reader.GetString(4);
                        empleado.EstadoEmp = reader.GetString(5);
                        empleado.CiudadEmp = reader.GetString(6);
                        empleado.CodigoPostalEmp = reader.GetInt32(7);
                        empleado.CalleEmp = reader.GetString(8);
                        empleado.NumExtEmp = reader.GetString(9);
                        empleado.TelefonoEmp = reader.GetString(10);
                        empleado.EmailEmp = reader.GetString(11);
                        empleado.FechaContratacion = reader.GetDateTime(12);
                        empleadosList.Add(empleado);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
            return empleadosList;
        }

        public Empleado LoadEmpleado(int ID)
        {
            Empleado empleado = new Empleado();
            string query = "SELECT IDEmpleado, IDArea, NombreEmp, ApellidoEmp, SexoEmp, EstadoEmp, CiudadEmp, CodigoPostalEmp, CalleEmp, NumExtEmp, TelefonoEmp, EmailEmp, FechaContratacion FROM Empleado WHERE IDEmpleado = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", ID);
                try
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    empleado.IDEmpleado = reader.GetInt32(0);
                    empleado.IDArea = reader.GetInt32(1);
                    empleado.NombreEmp = reader.GetString(2);
                    empleado.ApellidoEmp = reader.GetString(3);
                    empleado.SexoEmp = reader.GetString(4);
                    empleado.EstadoEmp = reader.GetString(5);
                    empleado.CiudadEmp = reader.GetString(6);
                    empleado.CodigoPostalEmp = reader.GetInt32(7);
                    empleado.CalleEmp = reader.GetString(8);
                    empleado.NumExtEmp = reader.GetString(9);
                    empleado.TelefonoEmp = reader.GetString(10);
                    empleado.EmailEmp = reader.GetString(11);
                    empleado.FechaContratacion = reader.GetDateTime(12);
                    reader.Close();
                    return empleado;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void CreateEmpleado(int IDArea, String NombreEmp, String ApellidoEmp, String SexoEmp, String EstadoEmp, String CiudadEmp, int CodigoPostalEmp, String CalleEmp, String NumExtEmp, String TelefonoEmp, String EmailEmp, DateTime FechaContratacion)
        {
            string query = "INSERT INTO Venta (IDArea, NombreEmp, ApellidoEmp, SexoEmp, EstadoEmp, CiudadEmp, CodigoPostalEmp, CalleEmp, NumExtEmp, TelefonoEmp, EmailEmp, FechaContratacion) VALUES (@IDArea, @NombreEmp, @ApellidoEmp, @SexoEmp, @EstadoEmp, @CiudadEmp, @CodigoPostalEmp, @CalleEmp, @NumExtEmp, @TelefonoEmp, @EmailEmp, @FechaContratacion)";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@IDArea", IDArea);
                cmd.Parameters.AddWithValue("@NombreEmp", NombreEmp);
                cmd.Parameters.AddWithValue("@ApellidoEmp", ApellidoEmp);
                cmd.Parameters.AddWithValue("@SexoEmp", SexoEmp);
                cmd.Parameters.AddWithValue("@EstadoEmp", EstadoEmp);
                cmd.Parameters.AddWithValue("@CiudadEmp", CiudadEmp);
                cmd.Parameters.AddWithValue("@CodigoPostalEmp", CodigoPostalEmp);
                cmd.Parameters.AddWithValue("@CalleEmp", CalleEmp);
                cmd.Parameters.AddWithValue("@NumExtEmp", NumExtEmp);
                cmd.Parameters.AddWithValue("@TelefonoEmp", TelefonoEmp);
                cmd.Parameters.AddWithValue("@EmailEmp", EmailEmp);
                cmd.Parameters.AddWithValue("@FechaContratacion", FechaContratacion);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void UpdateEmpleado(int IDEmpleado, int IDArea, String NombreEmp, String ApellidoEmp, String SexoEmp, String EstadoEmp, String CiudadEmp, int CodigoPostalEmp, String CalleEmp, String NumExtEmp, String TelefonoEmp, String EmailEmp, DateTime FechaContratacion)
        {
            string query = "UPDATE Empleado SET IDArea = @IDArea, NombreEmp = @NombreEmp, ApellidoEmp = @ApellidoEmp, SexoEmp = @SexoEmp, EstadoEmp = @EstadoEmp, CiudadEmp = @CiudadEmp, CodigoPostalEmp = @CodigoPostalEmp, CalleEmp = @CalleEmp, NumExtEmp = @NumExtEmp, TelefonoEmp = @TelefonoEmp, EmailEmp = @EmailEmp, FechaContratacion = @FechaContratacion WHERE IDEmpleado = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", IDEmpleado);
                cmd.Parameters.AddWithValue("@IDArea", IDArea);
                cmd.Parameters.AddWithValue("@NombreEmp", NombreEmp);
                cmd.Parameters.AddWithValue("@ApellidoEmp", ApellidoEmp);
                cmd.Parameters.AddWithValue("@SexoEmp", SexoEmp);
                cmd.Parameters.AddWithValue("@EstadoEmp", EstadoEmp);
                cmd.Parameters.AddWithValue("@CiudadEmp", CiudadEmp);
                cmd.Parameters.AddWithValue("@CodigoPostalEmp", CodigoPostalEmp);
                cmd.Parameters.AddWithValue("@CalleEmp", CalleEmp);
                cmd.Parameters.AddWithValue("@NumExtEmp", NumExtEmp);
                cmd.Parameters.AddWithValue("@TelefonoEmp", TelefonoEmp);
                cmd.Parameters.AddWithValue("@EmailEmp", EmailEmp);
                cmd.Parameters.AddWithValue("@FechaContratacion", FechaContratacion);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void DeleteEmpleado(int IDEmpleado)
        {
            string query = "DELETE FROM Empleado WHERE IDEmpleado = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", IDEmpleado);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public List<Puesto> ReadPuestos()
        {
            List<Puesto> puestosList = new List<Puesto>();
            string query = "EXEC ReadPuestos";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                try
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Puesto puesto = new Puesto();
                        puesto.IDArea = reader.GetInt32(0);
                        puesto.AreaNombre = reader.GetString(1);
                        puesto.SalarioMonto = reader.GetInt32(2);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
            return puestosList;
        }

        public Puesto LoadPuesto(int ID)
        {
            Puesto puesto = new Puesto();
            string query = "SELECT IDArea, AreaNombre, SalarioMonto FROM Puesto WHERE IDArea = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", ID);
                try
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    puesto.IDArea = reader.GetInt32(0);
                    puesto.AreaNombre = reader.GetString(1);
                    puesto.SalarioMonto = reader.GetInt32(2);
                    reader.Close();
                    return puesto;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void CreatePuesto(string AreaNombre, int SalarioMonto)
        {
            string query = "INSERT INTO Puesto (AreaNombre, SalarioMonto) VALUES (@AreaNombre, @SalarioMonto)";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@AreaNombre", AreaNombre);
                cmd.Parameters.AddWithValue("@SalarioMonto", SalarioMonto);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void UpdatePuesto(int IDArea, string AreaNombre, int SalarioMonto)
        {
            string query = "UPDATE Puesto SET AreaNombre = @AreaNombre, SalarioMonto = @SalarioMonto WHERE IDArea = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", IDArea);
                cmd.Parameters.AddWithValue("@AreaNombre", AreaNombre);
                cmd.Parameters.AddWithValue("@SalarioMonto", SalarioMonto);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void DeletePuesto(int IDArea)
        {
            string query = "DELETE FROM Puesto WHERE IDArea = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@IDArea", IDArea);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public List<Cliente> ReadClientes()
        {
            List<Cliente> clientesList = new List<Cliente>();
            string query = "EXEC ReadClientes";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                try
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.IDCliente = reader.GetInt32(0);
                        cliente.NombreCliente = reader.GetString(1);
                        cliente.ApellidoCliente = reader.GetString(2);
                        cliente.FechaNacCliente = reader.GetDateTime(3);
                        cliente.TelefonoCliente = reader.GetString(4);
                        cliente.ClienteRFC = reader.GetString(5);
                        cliente.EmailCliente = reader.GetString(6);
                        cliente.EstadoCliente = reader.GetString(7);
                        cliente.CiudadCliente = reader.GetString(8);
                        cliente.CodigoPostalCliente = reader.GetString(9);
                        cliente.CalleCliente = reader.GetString(10);
                        cliente.NumExtCliente = reader.GetString(11);
                        clientesList.Add(cliente);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
            return clientesList;
        }

        public Cliente LoadCliente(int ID)
        {
            Cliente cliente = new Cliente();
            string query = "SELECT IDCliente, NombreCliente, ApellidoCliente, FechaNacCliente, TelefonoCliente, ClienteRFC, EmailCliente, EstadoCliente, CiudadCliente, CodigoPostalCliente, CalleCliente, NumExtCliente FROM Cliente WHERE IDCliente = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", ID);
                try
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    cliente.IDCliente = reader.GetInt32(0);
                    cliente.NombreCliente = reader.GetString(1);
                    cliente.ApellidoCliente = reader.GetString(2);
                    cliente.FechaNacCliente = reader.GetDateTime(3);
                    cliente.TelefonoCliente = reader.GetString(4);
                    cliente.ClienteRFC = reader.GetString(5);
                    cliente.EmailCliente = reader.GetString(6);
                    cliente.EstadoCliente = reader.GetString(7);
                    cliente.CiudadCliente = reader.GetString(8);
                    cliente.CodigoPostalCliente = reader.GetString(9);
                    cliente.CalleCliente = reader.GetString(10);
                    cliente.NumExtCliente = reader.GetString(11);
                    reader.Close();
                    return cliente;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void CreateCliente(String NombreCliente, String ApellidoCliente, DateTime FechaNacCliente, String TelefonoCliente, String ClienteRFC, String EmailCliente, String EstadoCliente, String CiudadCliente, String CodigoPostalCliente, String CalleCliente, String NumExtCliente)
        {
            string query = "INSERT INTO Venta (NombreCliente, ApellidoCliente, FechaNacCliente, TelefonoCliente, ClienteRFC, EmailCliente, EstadoCliente, CiudadCliente, CodigoPostalCliente, CalleCliente, NumExtCliente) VALUES (@NombreCliente, @ApellidoCliente, @FechaNacCliente, @TelefonoCliente, @ClienteRFC, @EmailCliente, @EstadoCliente, @CiudadCliente, @CodigoPostalCliente, @CalleCliente, @NumExtCliente)";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@NombreCliente", NombreCliente);
                cmd.Parameters.AddWithValue("@ApellidoCliente", ApellidoCliente);
                cmd.Parameters.AddWithValue("@FechaNacCliente", FechaNacCliente);
                cmd.Parameters.AddWithValue("@TelefonoCliente", TelefonoCliente);
                cmd.Parameters.AddWithValue("@ClienteRFC", ClienteRFC);
                cmd.Parameters.AddWithValue("@EmailCliente", EmailCliente);
                cmd.Parameters.AddWithValue("@EstadoCliente", EstadoCliente);
                cmd.Parameters.AddWithValue("@CiudadCliente", CiudadCliente);
                cmd.Parameters.AddWithValue("@CodigoPostalCliente", CodigoPostalCliente);
                cmd.Parameters.AddWithValue("@CalleCliente", CalleCliente);
                cmd.Parameters.AddWithValue("@NumExtCliente", NumExtCliente);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void UpdateCliente(int IDCliente, String NombreCliente, String ApellidoCliente, DateTime FechaNacCliente, String TelefonoCliente, String ClienteRFC, String EmailCliente, String EstadoCliente, String CiudadCliente, String CodigoPostalCliente, String CalleCliente, String NumExtCliente)
        {
            string query = "UPDATE Cliente SET NombreCliente = @NombreCliente, ApellidoCliente = @ApellidoCliente, FechaNacCliente = @FechaNacCliente, TelefonoCliente = @TelefonoCliente, ClienteRFC = @ClienteRFC, EmailCliente = @EmailCliente, EstadoCliente = @EstadoCliente, CiudadCliente = @CiudadCliente, CodigoPostalCliente = @CodigoPostalCliente, CalleCliente = @CalleCliente, NumExtCliente = @NumExtCliente WHERE IDCliente = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", IDCliente);
                cmd.Parameters.AddWithValue("@NombreCliente", NombreCliente);
                cmd.Parameters.AddWithValue("@ApellidoCliente", ApellidoCliente);
                cmd.Parameters.AddWithValue("@FechaNacCliente", FechaNacCliente);
                cmd.Parameters.AddWithValue("@TelefonoCliente", TelefonoCliente);
                cmd.Parameters.AddWithValue("@ClienteRFC", ClienteRFC);
                cmd.Parameters.AddWithValue("@EmailCliente", EmailCliente);
                cmd.Parameters.AddWithValue("@EstadoCliente", EstadoCliente);
                cmd.Parameters.AddWithValue("@CiudadCliente", CiudadCliente);
                cmd.Parameters.AddWithValue("@CodigoPostalCliente", CodigoPostalCliente);
                cmd.Parameters.AddWithValue("@CalleCliente", CalleCliente);
                cmd.Parameters.AddWithValue("@NumExtCliente", NumExtCliente);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void DeleteCliente(int IDCliente)
        {
            string query = "DELETE FROM Cliente WHERE IDCliente = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", IDCliente);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public List<Proveedor> ReadProveedores()
        {
            List<Proveedor> proveedoresList = new List<Proveedor>();
            string query = "EXEC ReadProveedores";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                try
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Proveedor proveedor = new Proveedor();
                        proveedor.IDProveedor = reader.GetInt32(0);
                        proveedor.IDMarca = reader.GetInt32(1);
                        proveedor.NombreProveedor = reader.GetString(2);
                        proveedor.EmpresaProveniente = reader.GetString(3);
                        proveedor.ProveedorRFC = reader.GetString(4);
                        proveedoresList.Add(proveedor);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
            return proveedoresList;
        }

        public Proveedor LoadProveedor(int ID)
        {
            Proveedor proveedor = new Proveedor();
            string query = "SELECT IDProveedor, IDMarca, NombreProveedor, EmpresaProveniente, ProveedorRFC FROM Proveedor WHERE IDProveedor = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", ID);
                try
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    proveedor.IDProveedor = reader.GetInt32(0);
                    proveedor.IDMarca = reader.GetInt32(1);
                    proveedor.NombreProveedor = reader.GetString(2);
                    proveedor.EmpresaProveniente = reader.GetString(3);
                    proveedor.ProveedorRFC = reader.GetString(4);
                    reader.Close();
                    return proveedor;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void CreateProveedor(int IDMarca, String NombreProveedor, String EmpresaProveniente, String ProveedorRFC)
        {
            string query = "INSERT INTO Proveedor (IDMarca, NombreProveedor, EmpresaProveniente, ProveedorRFC) VALUES (@IDMarca, @NombreProveedor, @EmpresaProveniente, @ProveedorRFC)";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@IDMarca", IDMarca);
                cmd.Parameters.AddWithValue("@NombreProveedor", NombreProveedor);
                cmd.Parameters.AddWithValue("@EmpresaProveniente", EmpresaProveniente);
                cmd.Parameters.AddWithValue("@ProveedorRFC", ProveedorRFC);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void UpdateProveedor(int IDProveedor, int IDMarca, String NombreProveedor, String EmpresaProveniente, String ProveedorRFC)
        {
            string query = "UPDATE Proveedor SET IDMarca = @IDMarca, NombreProveedor = @NombreProveedor, EmpresaProveniente = @EmpresaProveniente, ProveedorRFC = @ProveedorRFC WHERE IDProveedor = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", IDProveedor);
                cmd.Parameters.AddWithValue("@IDMarca", IDMarca);
                cmd.Parameters.AddWithValue("@NombreProveedor", NombreProveedor);
                cmd.Parameters.AddWithValue("@EmpresaProveniente", EmpresaProveniente);
                cmd.Parameters.AddWithValue("@ProveedorRFC", ProveedorRFC);

                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void DeleteProveedor(int IDProveedor)
        {
            string query = "DELETE FROM Proveedor WHERE IDProveedor = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", IDProveedor);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public List<Categoria> ReadCategorias()
        {
            List<Categoria> categoriasList = new List<Categoria>();
            string query = "EXEC ReadCategorias";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                try
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Categoria categoria = new Categoria();
                        categoria.IDCategoria = reader.GetInt32(0);
                        categoria.NombreCategoria = reader.GetString(1);
                        categoria.Presentacion = reader.GetString(2);
                        categoriasList.Add(categoria);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
            return categoriasList;
        }

        public Categoria LoadCategoria(int ID)
        {
            Categoria categoria = new Categoria();
            string query = "SELECT IDCategoria, NombreCategoria, Presentacion FROM Categoria WHERE IDCategoria = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", ID);
                try
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    categoria.IDCategoria = reader.GetInt32(0);
                    categoria.NombreCategoria = reader.GetString(1);
                    categoria.Presentacion = reader.GetString(2);
                    reader.Close();
                    return categoria;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void CreateCategoria(string NombreCategoria, string Presentacion)
        {
            string query = "INSERT INTO Categoria (NombreCategoria, Presentacion) VALUES (@NombreCategoria, @Presentacion)";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@NombreCategoria", NombreCategoria);
                cmd.Parameters.AddWithValue("@Presentacion", Presentacion);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void UpdateCategoria(int IDCategoria, string NombreCategoria, string Presentacion)
        {
            string query = "UPDATE Categoria SET NombreCategoria = @NombreCategoria, Presentacion = @Presentacion WHERE IDCategoria = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", IDCategoria);
                cmd.Parameters.AddWithValue("@NombreCategoria", NombreCategoria);
                cmd.Parameters.AddWithValue("@Presentacion", Presentacion);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void DeleteCategoria(int IDCategoria)
        {
            string query = "DELETE FROM Categoria WHERE IDCategoria = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", IDCategoria);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public List<Marca> ReadMarcas()
        {
            List<Marca> marcasList = new List<Marca>();
            string query = "EXEC ReadMarcas";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                try
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Marca marca = new Marca();
                        marca.IDMarca = reader.GetInt32(0);
                        marca.NombreMarca = reader.GetString(1);
                        marca.TelefonoEmpresa = reader.GetString(2);
                        marcasList.Add(marca);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
            return marcasList;
        }

        public Marca LoadMarca(int ID)
        {
            Marca marca = new Marca();
            string query = "SELECT IDMarca, NombreMarca, TelefonoEmpresa FROM Marca WHERE IDMarca = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", ID);
                try
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    marca.IDMarca = reader.GetInt32(0);
                    marca.NombreMarca = reader.GetString(1);
                    marca.TelefonoEmpresa = reader.GetString(2);
                    reader.Close();
                    return marca;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void CreateMarca(string NombreMarca, string TelefonoEmpresa)
        {
            string query = "INSERT INTO Marca (NombreMarca, TelefonoEmpresa) VALUES (@NombreMarca, @TelefonoEmpresa)";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@NombreMarca", NombreMarca);
                cmd.Parameters.AddWithValue("@TelefonoEmpresa", TelefonoEmpresa);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void UpdateMarca(int IDMarca, string NombreMarca, string TelefonoEmpresa)
        {
            string query = "UPDATE Marca SET NombreMarca = @NombreMarca, TelefonoEmpresa = @TelefonoEmpresa WHERE IDMarca = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", IDMarca);
                cmd.Parameters.AddWithValue("@NombreMarca", NombreMarca);
                cmd.Parameters.AddWithValue("@TelefonoEmpresa", TelefonoEmpresa);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void DeleteMarca(int IDMarca)
        {
            string query = "DELETE FROM Marca WHERE IDUnidad = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", IDMarca);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public List<UnidadMedida> ReadUnidades()
        {
            List<UnidadMedida> unidadesList = new List<UnidadMedida>();
            string query = "EXEC ReadUnidades";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                try
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        UnidadMedida unidad = new UnidadMedida();
                        unidad.IDUnidad = reader.GetInt32(0);
                        unidad.Magnitud = reader.GetString(1);
                        unidad.Cantidad = reader.GetInt32(2);
                        unidad.Unidad = reader.GetString(3);
                        unidad.Simbolo = reader.GetString(4);
                        unidadesList.Add(unidad);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
            return unidadesList;
        }

        public UnidadMedida LoadUnidad(int ID)
        {
            UnidadMedida unidad = new UnidadMedida();
            string query = "SELECT IDUnidad, Magnitud, Cantidad, Unidad, Simbolo FROM UnidadMedida WHERE IDUnidad = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", ID);
                try
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    unidad.IDUnidad = reader.GetInt32(0);
                    unidad.Magnitud = reader.GetString(1);
                    unidad.Cantidad = reader.GetInt32(2);
                    unidad.Unidad = reader.GetString(3);
                    unidad.Simbolo = reader.GetString(4);
                    reader.Close();
                    return unidad;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void CreateUnidad(string Magnitud, int Cantidad, string Unidad, string Simbolo)
        {
            string query = "INSERT INTO UnidadMedida (Magnitud, Cantidad, Unidad, Simbolo) VALUES (@Magnitud, @Cantidad, @Unidad, @Simbolo)";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@Magnitud", Magnitud);
                cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
                cmd.Parameters.AddWithValue("@Unidad", Unidad);
                cmd.Parameters.AddWithValue("@Simbolo", Simbolo);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void UpdateUnidad(int IDUnidad, string Magnitud, int Cantidad, string Unidad, string Simbolo)
        {
            string query = "UPDATE UnidadMedida SET Magnitud = @Magnitud, Cantidad = @Cantidad, Unidad = @Unidad, Simbolo = @Simbolo WHERE IDUnidad = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", IDUnidad);
                cmd.Parameters.AddWithValue("@Magnitud", Magnitud);
                cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
                cmd.Parameters.AddWithValue("@Unidad", Unidad);
                cmd.Parameters.AddWithValue("@Simbolo", Simbolo);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }

        public void DeleteUnidad(int IDUnidad)
        {
            string query = "DELETE FROM UnidadMedida WHERE IDUnidad = @ID";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", IDUnidad);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos. " + ex.Message);
                }
            }
        }       

    }    
    public class Empresa
    {
        public string? NombreEmpresa { get; set; }
        public string? Slogan { get; set; }
        public string? Fundador { get; set; }
        public string? Telefono { get; set; }
        public string? Estado { get; set; }
        public string? Ciudad { get; set; }
        public int CodigoPostal { get; set; }
        public string? Calle { get; set; }
        public string? CodigoIdentificacionFiscal { get; set; }

    }

    public class Venta
    {
        public int IDTicket { get; set; }
        public int IDCliente { get; set; }
        public int IDEmpleado { get; set; }
        public DateTime FechaVenta { get; set; }
    }

    public class DetalleTicket
    {
        public int IDTicket { get; set; }
        public int IDProducto { get; set; }
        public int PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
    }

    public class Factura
    {
        public int IDFactura { get; set; }
        public int IDTicket { get; set; }
        public int IDCliente { get; set; }
        public string? Nombre { get; set; }
        public DateTime FechaFactura { get; set; }
    }

    public class DetalleFactura
    {
        public int IDFactura { get; set; }
        public int IDProducto { get; set; }
        public int PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
    }

    public class Orden
    {
        public int IDOrdenCompra { get; set; }
        public int IDProveedor { get; set; }
        public DateTime FechaOrden { get; set; }
    }

    public class DetalleOrden
    {
        public int IDOrdenCompra { get; set; }
        public int IDProducto { get; set; }
        public string? NombreMarca { get; set; }
        public int Costo { get; set; }
        public int Cantidad { get; set; }
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

    public class Empleado
    {
        public int IDEmpleado { get; set; }
        public int IDArea { get; set; }
        public string? NombreEmp { get; set; }
        public string? ApellidoEmp { get; set; }
        public string? SexoEmp { get; set; }
        public string? EstadoEmp { get; set; }
        public string? CiudadEmp { get; set; }
        public int CodigoPostalEmp { get; set; }
        public string? CalleEmp { get; set; }
        public string? NumExtEmp { get; set; }
        public string? TelefonoEmp { get; set; }
        public string? EmailEmp { get; set; }
        public DateTime FechaContratacion { get; set; }
    }

    public class Puesto
    {
        public int IDArea { get; set; }
        public string? AreaNombre { get; set; }
        public int SalarioMonto { get; set; }
    }

    public class Cliente
    {
        public int IDCliente { get; set; }
        public string? NombreCliente { get; set; }
        public string? ApellidoCliente { get; set; }
        public DateTime FechaNacCliente { get; set; }
        public string? TelefonoCliente { get; set; }
        public string? ClienteRFC { get; set; }
        public string? EmailCliente { get; set; }
        public string? EstadoCliente { get; set; }
        public string? CiudadCliente { get; set; }
        public string? CodigoPostalCliente { get; set; }
        public string? CalleCliente { get; set; }
        public string? NumExtCliente { get; set; }
    }

    public class Proveedor
    {
        public int IDProveedor { get; set; }
        public int IDMarca { get; set; }
        public string? NombreProveedor { get; set; }
        public string? EmpresaProveniente { get; set; }
        public string? ProveedorRFC { get; set; }
    }

    public class Categoria
    {
        public int IDCategoria { get; set; }
        public string? NombreCategoria { get; set; }
        public string? Presentacion { get; set; }
    }

    public class Marca
    {
        public int IDMarca { get; set; }
        public string? NombreMarca { get; set; }
        public string? TelefonoEmpresa { get; set; }
    }

    public class UnidadMedida
    {
        public int IDUnidad { get; set; }
        public string? Magnitud { get; set; }
        public int Cantidad { get; set; }
        public string? Unidad { get; set; }
        public string? Simbolo { get; set; }
    }
    
}