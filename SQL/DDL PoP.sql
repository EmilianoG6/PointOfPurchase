CREATE DATABASE PoP
USE PoP

CREATE TABLE Empresa(
	NombreEmpresa VARCHAR(50) NOT NULL,
	Slogan VARCHAR(150) NOT NULL,
	Fundador VARCHAR(100) NOT NULL,	
	Telefono VARCHAR(15) NOT NULL,
	Estado VARCHAR(50) NOT NULL,
	Ciudad VARCHAR(50) NOT NULL,
	CodigoPostal INT NOT NULL,
	Calle VARCHAR(100) NOT NULL,
	CodigoIdentificacionFiscal VARCHAR(50) NOT NULL
)

CREATE TABLE Cliente(
	IDCliente INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	NombreCliente VARCHAR(50) NOT NULL,
	ApellidoCliente VARCHAR(50) NOT NULL,
	FechaNacCliente DATE,
	TelefonoCliente VARCHAR(15) NOT NULL,
	ClienteRFC VARCHAR(50),
	EmailCliente VARCHAR(50) NOT NULL,
	EstadoCliente VARCHAR(50),
	CiudadCliente VARCHAR(50),
	CodigoPostalCliente VARCHAR(50),
	CalleCliente VARCHAR(50),
	NumExtCliente VARCHAR(20)
)

CREATE TABLE Puesto(
	IDArea INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	AreaNombre VARCHAR(50) NOT NULL,
	SalarioMonto MONEY NOT NULL
)

CREATE TABLE Empleado(
	IDEmpleado INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	IDArea INT NOT NULL,
	CONSTRAINT FK_EmpleadoPuesto FOREIGN KEY (IDArea) REFERENCES Puesto(IDArea),
	NombreEmp VARCHAR(50) NOT NULL,
	ApellidoEmp VARCHAR(50) NOT NULL,
	SexoEmp VARCHAR(2) NOT NULL,
	EstadoEmp VARCHAR(50) NOT NULL,
	CiudadEmp VARCHAR(50) NOT NULL,
	CodigoPostalEmp INT NOT NULL,
	CalleEmp VARCHAR(50) NOT NULL,
	NumExtEmp VARCHAR(20) NOT NULL,
	TelefonoEmp VARCHAR(20) NOT NULL,
	EmailEmp VARCHAR(50) NOT NULL,
	FechaContratacion DATE NOT NULL,
)

CREATE TABLE Categoria(
	IDCategoria INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	NombreCategoria VARCHAR(50) NOT NULL,
	Presentacion VARCHAR(50)
)

CREATE TABLE Marca(
	IDMarca INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	NombreMarca VARCHAR(50) NOT NULL,
	TelefonoEmpresa VARCHAR(15) NOT NULL
)

CREATE TABLE Proveedor(
	IDProveedor INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	IDMarca INT NOT NULL,
	CONSTRAINT FK_ProveedorMarca FOREIGN KEY (IDMarca) REFERENCES Marca(IDMarca),
	NombreProveedor VARCHAR(50) NOT NULL,
	EmpresaProveniente VARCHAR(50) NOT NULL,
	ProveedorRFC VARCHAR(20) NOT NULL,
)

CREATE TABLE UnidadMedida(
	IDUnidad INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Magnitud VARCHAR(20) NOT NULL,
	Cantidad INT NOT NULL,
	Unidad VARCHAR(20) NOT NULL,
	Simbolo VARCHAR(5) NOT NULL,
)

CREATE TABLE Producto(
	IDProducto INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	IDCategoria INT NOT NULL,
	CONSTRAINT FK_ProductoCategoria FOREIGN KEY (IDCategoria) REFERENCES Categoria(IDCategoria),
	IDMarca INT NOT NULL,
	CONSTRAINT FK_ProductoMarca FOREIGN KEY (IDMarca) REFERENCES Marca(IDMarca),
	IDProveedor INT NOT NULL,
	CONSTRAINT FK_ProductoProveedor FOREIGN KEY (IDProveedor) REFERENCES Proveedor(IDProveedor),
	IDUnidad INT NOT NULL,
	CONSTRAINT FK_ProductoUnidad FOREIGN KEY (IDUnidad) REFERENCES UnidadMedida(IDUnidad),
	Descripcion VARCHAR(200),
	PrecioUnitario INT NOT NULL,
	UnidadEnStock INT NOT NULL,
	Descontinuado BIT NOT NULL,
)

CREATE TABLE Venta(
	IDTicket INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	IDCliente INT NOT NULL,
	CONSTRAINT FK_VentaCliente FOREIGN KEY (IDCliente) REFERENCES Cliente(IDCliente),
	IDEmpleado INT NOT NULL,
	CONSTRAINT FK_VentaEmpleado FOREIGN KEY (IDEmpleado) REFERENCES Empleado(IDEmpleado),
	FechaVenta DATE NOT NULL,
)

CREATE TABLE DetalleTicket(
	IDTicket INT NOT NULL,
	CONSTRAINT FK_DetalleTicketTicket FOREIGN KEY (IDTicket) REFERENCES Venta(IDTicket),
	IDProducto INT NOT NULL,
	CONSTRAINT FK_DetalleTicketProducto FOREIGN KEY (IDProducto) REFERENCES Producto(IDProducto),
	PrecioUnitario MONEY NOT NULL,
	Cantidad INT NOT NULL,
)

CREATE TABLE OrdenCompra(
	IDOrdenCompra INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	IDProveedor INT NOT NULL,
	CONSTRAINT FK_OrdenCompraProveedor FOREIGN KEY (IDProveedor) REFERENCES Proveedor(IDProveedor),
	FechaOrden DATE NOT NULL
)

CREATE TABLE DetalleOrdenCompra(
	IDOrdenCompra INT NOT NULL,
	CONSTRAINT FK_DetalleOrdenCompraOrdenCompra FOREIGN KEY (IDOrdenCompra) REFERENCES OrdenCompra(IDOrdenCompra),
	IDProducto INT NOT NULL,
	CONSTRAINT FK_DetalleOrdenCompraProducto FOREIGN KEY (IDProducto) REFERENCES Producto(IDProducto),
	NombreMarca VARCHAR(50) NOT NULL,
	Costo INT NOT NULL,
	Cantidad INT NOT NULL,
)

CREATE TABLE Factura(
	IDFactura INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	IDTicket INT NOT NULL,
	CONSTRAINT FK_FacturaTicket FOREIGN KEY (IDTicket) REFERENCES Venta(IDTicket),
	IDCliente INT NOT NULL,
	CONSTRAINT FK_FacturaCliente FOREIGN KEY (IDCliente) REFERENCES Cliente(IDCliente),
	Nombre VARCHAR(200),
	FechaFactura DATE NOT NULL,
)

CREATE TABLE DetalleFactura(
	IDFactura INT NOT NULL,
	CONSTRAINT FK_DetalleFacturaFactura FOREIGN KEY (IDFactura) REFERENCES OrdenCompra(IDOrdenCompra),
	IDProducto INT NOT NULL,
	CONSTRAINT FK_DetalleFacturaProducto FOREIGN KEY (IDProducto) REFERENCES Producto(IDProducto),
	PrecioUnitario INT NOT NULL,
	Cantidad INT NOT NULL,
)