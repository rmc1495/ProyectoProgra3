USE Flights
DROP TABLE Ticket
CREATE TABLE Ticket
(
		idTicket int IDENTITY(1,1) PRIMARY KEY,
        price money NOT NULL,
        currency int NOT NULL,
		ticketState varchar(50) NOT NULL,
        idClient varchar(50) NOT NULL,
		idFlight int NOT NULL,
		numSeat int
);
	
 
CREATE PROCEDURE sp_RegisterTicket
   
    @pPrice money,
	@pCurrency int,
	@pTicketState varchar(50),
    @pIdClient varchar(50),
	@pIdFlight int,
	@pNumSeat int

AS 
BEGIN
	INSERT INTO Ticket (price,currency,ticketState,idClient,idFlight,numSeat)
	VALUES (@pPrice,@pCurrency,@pTicketState,@pIdClient,@pIdFlight,@pNumSeat)
END


ALTER PROCEDURE sp_UpdateTicket
	
	@pId varchar(50),
    @pPrice money,
	@pCurrency int,
	@pTicketState varchar(50),
    @pIdClient varchar(50),
	@pIdFlight int,
	@pNumSeat int
	
AS 
	BEGIN
	UPDATE Ticket
	SET
	    idTicket=@pId,
        price=@pPrice,
        currency=@pCurrency,
        ticketState=@pTicketState,
        idClient=@pIdClient,
        idFlight=@pIdFlight,
        numSeat=@pNumSeat
		WHERE idTicket=@pId
END

GO
CREATE PROCEDURE sp_listTickets

	AS
	BEGIN
	SELECT idTicket AS IdTiquete, price AS Precio, currency AS Moneda,
		   ticketState AS Estado, idClient AS Cliente, idFlight AS Vuelo, numSeat AS Asiento	
	FROM Ticket;
END

GO
CREATE PROCEDURE sp_searchById
	@pId INT
AS
	BEGIN
	SELECT idTicket AS IdTiquete, price AS Precio, currency AS Moneda,
		   ticketState AS Estado, idClient AS Cliente, idFlight AS Vuelo, numSeat AS Asiento	
	FROM Ticket	WHERE idTicket = @pId
END

GO
CREATE PROCEDURE sp_searchByClienteByVuelo
	@pIdCliente varchar (50),
	@pIdFlight int
AS
	BEGIN
	SELECT idTicket AS IdTiquete, price AS Precio, currency AS Moneda,
		   ticketState AS Estado, idClient AS Cliente, idFlight AS Vuelo, numSeat AS Asiento	
	FROM Ticket	WHERE idClient = @pIdCliente OR idFlight = @pIdFlight  
END
 

select * from Ticket