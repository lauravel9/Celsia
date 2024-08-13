-- Active: 1723584019525@@b3lkvue9kxnupvr2mxf3-mysql.services.clever-cloud.com@3306
CREATE TABLE Cliente (
    ID_Cliente INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(100) NOT NULL,
    Identificacion VARCHAR(50) UNIQUE NOT NULL,
    Direccion VARCHAR(255),
    Telefono VARCHAR(15),
    Correo_Electronico VARCHAR(100) UNIQUE
);


CREATE TABLE Plataforma_Pago (
    ID_Plataforma INT PRIMARY KEY AUTO_INCREMENT,
    Nombre_Plataforma VARCHAR(100) NOT NULL
);

CREATE TABLE Estado_Transaccion (
    ID_Estado INT PRIMARY KEY AUTO_INCREMENT,
    Descripcion_Estado VARCHAR(50) NOT NULL
);

CREATE TABLE Factura (
    ID_Factura INT PRIMARY KEY AUTO_INCREMENT,
    Numero_Factura VARCHAR(50) UNIQUE NOT NULL,
    Fecha_Facturacion DATE NOT NULL,
    Monto_Facturado DECIMAL(10, 2) NOT NULL,
    Monto_Pagado DECIMAL(10, 2)
);

CREATE TABLE Transaccion (
    ID_Transaccion INT PRIMARY KEY AUTO_INCREMENT,
    Fecha_Hora DATETIME NOT NULL,
    ID_Plataforma INT,
    ID_Cliente INT,
    ID_Factura INT,
    ID_Estado INT,
    FOREIGN KEY (ID_Plataforma) REFERENCES Plataforma_Pago(ID_Plataforma),
    FOREIGN KEY (ID_Cliente) REFERENCES Cliente(ID_Cliente),
    FOREIGN KEY (ID_Factura) REFERENCES Factura(ID_Factura),
    FOREIGN KEY (ID_Estado) REFERENCES Estado_Transaccion(ID_Estado)
);
