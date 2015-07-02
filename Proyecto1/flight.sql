USE Flights

CREATE TABLE Flight
(
		idFlight int IDENTITY(1,1) PRIMARY KEY,
		idTicket int NOT NULL FOREIGN KEY REFERENCES Ticket(idTicket),
		idPlane  int NOT NULL FOREIGN KEY REFERENCES dbo.Plane(idPlane),
		origen varchar (50),
		destino  varchar (50),
		horaPartida  varchar (50),
		horaLlegada  varchar (50)
);
	
 
CREATE PROCEDURE sp_RegisterFlight
   
	@idTicket int,
	@idPlane int,
    @origen varchar(50),
	@destino varchar(50),
	@horaPartida varchar(50),
	@horaLlegada varchar(50)

AS 
BEGIN
	INSERT INTO Flight (idTicket,idPlane,origen,destino,horaPartida,horaLlegada)
	VALUES (@idTicket,@idPlane,@origen,@destino,@horaPartida,@horaLlegada)
END


CREATE PROCEDURE sp_UpdateFlight
	@pId int,
	@idTicket int,
	@idPlane int,
    @origen varchar(50),
	@destino varchar(50),
	@horaPartida varchar(50),
	@horaLlegada varchar(50)
AS 
	BEGIN
	UPDATE Flight
	SET
	    idTicket=@idTicket,
        idPlane=@idPlane,
        origen=@origen,
        destino=@destino,
        horaPartida=@horaPartida,
        horaLlegada=@horaLlegada
		WHERE idFlight = @pId
END

GO
CREATE PROCEDURE sp_listFlights

	AS
	BEGIN
	SELECT *
	FROM Flights;
END

GO
CREATE PROCEDURE sp_searchById
	@pId INT
AS
	BEGIN
	SELECT *
	FROM Flights WHERE idFlight = @pId
END

GO

 

select * from Ticket