-- Active: 1723584019525@@b3lkvue9kxnupvr2mxf3-mysql.services.clever-cloud.com@3306
CREATE TABLE Clientes (
    IdCliente INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(100) NOT NULL,
    Identificacion VARCHAR(50) UNIQUE NOT NULL,
    Direccion VARCHAR(255),
    Telefono VARCHAR(15),
    CorreoElectronico VARCHAR(100) UNIQUE
);


CREATE TABLE PlataformaPago (
    IdPlataformaPago INT PRIMARY KEY AUTO_INCREMENT,
    NombrePlataforma VARCHAR(100) NOT NULL
);

CREATE TABLE EstadoTransaccion (
    IdEstadoTransaccion INT PRIMARY KEY AUTO_INCREMENT,
    DescripcionEstado VARCHAR(50) NOT NULL
);

CREATE TABLE Factura (
    IdFactura INT PRIMARY KEY AUTO_INCREMENT,
    NumeroFactura VARCHAR(50) UNIQUE NOT NULL,
    FechaFacturacion DATE NOT NULL,
    MontoFacturado DECIMAL(10, 2) NOT NULL,
    MontoPagado DECIMAL(10, 2)
);

DROP TABLE Cliente;

CREATE TABLE Transacciones (
    IdTransaccion INT PRIMARY KEY AUTO_INCREMENT,
    FechaHora DATETIME NOT NULL,
    IdPlataformaPago INT,
    IdCliente INT,
    IdFactura INT,
    IdEstadoTransaccion INT,
    FOREIGN KEY (IdPlataformaPago) REFERENCES PlataformaPago(IdPlataformaPago),
    FOREIGN KEY (IdCliente) REFERENCES Clientes(IdCliente),
    FOREIGN KEY (IdFactura) REFERENCES Factura(IdFactura),
    FOREIGN KEY (IdEstadoTransaccion) REFERENCES EstadoTransaccion(IdEstadoTransaccion)
);

INSERT INTO Clientes (Nombre, Identificacion, Direccion, Telefono, CorreoElectronico)
VALUES
('Juan Pérez', '123456789', 'Calle Falsa 123', '3001234567', 'juan.perez@example.com'),
('María López', '987654321', 'Avenida Siempre Viva 742', '3009876543', 'maria.lopez@example.com'),
('Carlos Gómez', '456789123', 'Carrera 45 #12-34', '3004567891', 'carlos.gomez@example.com');

INSERT INTO PlataformaPago (NombrePlataforma)
VALUES
('Tarjeta de Crédito'),
('Transferencia Bancaria'),
('Pago en Efectivo');


INSERT INTO EstadoTransaccion (DescripcionEstado)
VALUES
('Pendiente'),
('Completada'),
('Fallida');


INSERT INTO Factura (NumeroFactura, FechaFacturacion, MontoFacturado, MontoPagado)
VALUES
('FAC-001', '2024-08-01', 150.00, 150.00),
('FAC-002', '2024-08-02', 200.00, 0.00),
('FAC-003', '2024-08-03', 300.00, 300.00);



INSERT INTO Transacciones (FechaHora, IdPlataformaPago, IdCliente, IdFactura, IdEstadoTransaccion)
VALUES
(NOW(), 1, 1, 1, 1),  -- Juan Pérez, Plataforma de Pago 1, Factura 1, Estado 1
(NOW(), 2, 2, 2, 2),  -- María López, Plataforma de Pago 2, Factura 2, Estado 2
(NOW(), 1, 3, 3, 1);  -- Carlos Gómez, Plataforma de Pago 1, Factura 3, Estado 1



DROP TABLE Factura;