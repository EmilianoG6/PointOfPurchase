USE PoP

CREATE PROCEDURE ReadVentas
AS
BEGIN
	IF EXISTS (SELECT IDTicket, IDCliente, IDEmpleado, FechaVenta FROM Venta)
	SELECT IDTicket, IDCliente, IDEmpleado, FechaVenta FROM Venta
	ELSE SELECT 'No existen registros de ventas.'
END
GO

CREATE PROCEDURE ReadFacturas
AS
BEGIN
	IF EXISTS (SELECT IDFactura, IDTicket, IDCliente, Nombre, FechaFactura FROM Factura)
	SELECT IDFactura, IDTicket, IDCliente, Nombre, FechaFactura FROM Factura
	ELSE SELECT 'No existen registros de facturas.'
END
GO

CREATE PROCEDURE ReadOrdenes
AS
BEGIN
	IF EXISTS (SELECT IDOrdenCompra, IDProveedor, FechaOrden FROM OrdenCompra)
	SELECT IDOrdenCompra, IDProveedor, FechaOrden FROM OrdenCompra
	ELSE SELECT 'No existen registros de órdenes de venta.'
END
GO

CREATE PROCEDURE ReadDetalleTicket
AS
BEGIN 
	IF EXISTS (SELECT IDTicket, IDProducto, PrecioUnitario, Cantidad FROM DetalleTicket)
	SELECT IDTicket, IDProducto, PrecioUnitario, Cantidad FROM DetalleTicket
	ELSE SELECT 'No existen registros de detalles de ventas.'
END
GO

CREATE PROCEDURE ReadDetalleFactura
AS
BEGIN
	IF EXISTS (SELECT IDFactura, IDProducto, PrecioUnitario, Cantidad FROM DetalleFactura)
	SELECT IDFactura, IDProducto, PrecioUnitario, Cantidad FROM DetalleFactura
	ELSE SELECT 'No existen registros de detalles de facturas.'
END
GO

CREATE PROCEDURE ReadDetalleOrdenCompra
AS
BEGIN
	IF EXISTS (SELECT IDOrdenCompra, IDProducto, NombreMarca, Costo, Cantidad FROM DetalleOrdenCompra)
	SELECT IDOrdenCompra, IDProducto, NombreMarca, Costo, Cantidad FROM DetalleOrdenCompra
	ELSE SELECT 'No existen registros de detalles de órdenes de compra.'
END
GO


CREATE PROCEDURE ReadProductos
AS
BEGIN
	IF EXISTS (SELECT IDProducto, IDCategoria, IDMarca, IDProveedor,IDUnidad, Descripcion,
	PrecioUnitario, UnidadEnStock, Descontinuado FROM Producto)
	SELECT IDProducto, IDCategoria, IDMarca, IDProveedor,IDUnidad, Descripcion,
	PrecioUnitario, UnidadEnStock, Descontinuado FROM Producto 
	ELSE SELECT 'No existen registros de productos.'
END
GO

CREATE PROCEDURE ReadEmpleados
AS
BEGIN
	IF EXISTS (SELECT IDEmpleado, IDArea, NombreEmp, ApellidoEmp, SexoEmp, EstadoEmp,
	CiudadEmp, CodigoPostalEmp, CalleEmp, NumExtEmp, TelefonoEmp, EmailEmp, 
	FechaContratacion FROM Empleado)
	SELECT IDEmpleado, IDArea, NombreEmp, ApellidoEmp, SexoEmp, EstadoEmp,
	CiudadEmp, CodigoPostalEmp, CalleEmp, NumExtEmp, TelefonoEmp, EmailEmp, 
	FechaContratacion FROM Empleado
	ELSE SELECT 'No existen registros de empleados.'
END
GO

CREATE PROCEDURE ReadPuestos 
AS
BEGIN 
	IF EXISTS(SELECT IDArea, AreaNombre, SalarioMonto FROM Puesto)
	SELECT IDArea, AreaNombre, SalarioMonto FROM Puesto
	ELSE SELECT 'No existen registros de puestos.'

END
GO

CREATE PROCEDURE ReadClientes
AS
BEGIN
	IF EXISTS (SELECT IDCliente, NombreCliente, ApellidoCliente, FechaNacCliente,
	TelefonoCliente, ClienteRFC, EmailCliente, EstadoCliente, CiudadCliente,
	CodigoPostalCliente, CalleCliente, NumExtCliente FROM Cliente)
	SELECT IDCliente, NombreCliente, ApellidoCliente, FechaNacCliente,
	TelefonoCliente, ClienteRFC, EmailCliente, EstadoCliente, CiudadCliente,
	CodigoPostalCliente, CalleCliente, NumExtCliente FROM Cliente
	ELSE SELECT 'No existen resgistros de clientes.'
END
GO

CREATE PROCEDURE ReadProveedores
AS
BEGIN
	IF EXISTS (SELECT IDProveedor, IDMarca, NombreProveedor, EmpresaProveniente,
	ProveedorRFC FROM Proveedor)
	SELECT IDProveedor, IDMarca, NombreProveedor, EmpresaProveniente,
	ProveedorRFC FROM Proveedor
	ELSE SELECT 'No existen registros de proveedores.'
END
GO

CREATE PROCEDURE ReadCategorias
AS
BEGIN
	IF EXISTS (SELECT IDCategoria, NombreCategoria, Presentacion FROM Categoria)
	SELECT IDCategoria, NombreCategoria, Presentacion FROM Categoria
	ELSE SELECT 'No existen registros de categorías.'
END
GO

CREATE PROCEDURE ReadMarcas
AS
BEGIN
	IF EXISTS (SELECT IDMarca, NombreMarca, TelefonoEmpresa FROM Marca)
	SELECT IDMarca, NombreMarca, TelefonoEmpresa FROM Marca
	ELSE SELECT 'No existen registros de marcas.'
END
GO

CREATE PROCEDURE ReadUnidades
AS
BEGIN
	IF EXISTS (SELECT IDUnidad, Magnitud, Cantidad, Unidad, Simbolo FROM UnidadMedida)
	SELECT IDUnidad, Magnitud, Cantidad, Unidad, Simbolo FROM UnidadMedida
	ELSE SELECT 'No existen registros de unidades de medida.'
END
GO