
-- Tabla producto
CREATE TABLE producto(
    idproducto INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
    nombre VARCHAR(100),
    precioProducto DECIMAL(5,2),
    stock INT
);

-- Tabla cliente
CREATE TABLE cliente(
    idcliente INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
    nombres VARCHAR(100),
    appaterno VARCHAR(100),
    apmaterno VARCHAR(100)
);

/*Ingresando Registro de PRUEBA*/

insert into cliente(nombres,appaterno,apmaterno) values ("Agustin", "Urtubia", "Gonzales");

/*MOSTRAR TODOS LOS CLIENTES*/
select idcliente,nombres,appaterno, apmaterno from cliente;

-- Tabla factura
CREATE TABLE factura(
    idfactura INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
    fechaFactura DATE,
    fkcliente INT,
    FOREIGN KEY(fkcliente) REFERENCES cliente(idcliente)
);

-- Tabla detalle
CREATE TABLE detalle(
    iddetalle INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
    fkfactura INT,
    FOREIGN KEY(fkfactura) REFERENCES factura(idfactura),
    fkproducto INT,
    FOREIGN KEY(fkproducto) REFERENCES producto(idproducto),
    cantidad INT,
    precio DECIMAL(5,2)
);