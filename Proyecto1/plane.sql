USE Flights
DROP TABLE Plane
CREATE TABLE Plane
(
		idPlane int IDENTITY(1,1) PRIMARY KEY,
		marca varchar(50),
		qtyAsiento int
);
GO
ALTER PROCEDURE sp_listPlane
AS
BEGIN
	SELECT idPlane AS ID, marca AS Marca, qtyAsiento AS CantidadAsientos FROM Plane;
END


INSERT INTO Plane (marca,qtyAsiento) values ('Taca','40');
INSERT INTO Plane (marca,qtyAsiento) values ('Avianca','35');
INSERT INTO Plane (marca,qtyAsiento) values ('jetBlue','50');
INSERT INTO Plane (marca,qtyAsiento) values ('American Airlines','45');

EXEC sp_listPlane
