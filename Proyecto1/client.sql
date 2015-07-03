USE MASTER;
GO

/**********************************************************************/
---------VALIDACION PARA DETERMINAR SI EXISTE UNA BASE DE DATOS--------
/**********************************************************************/
GO
IF EXISTS(SELECT * FROM sys.databases WHERE name = 'DB_FLIGHTS')
BEGIN
	DROP DATABASE DB_FLIGHTS;
END

/***********************************************************************/
------------------------------CREA BASE DE DATOS------------------------
/***********************************************************************/
GO
CREATE DATABASE DB_FLIGHTS;


/***********************************************************************/
----------------------------------CREA TABLAS---------------------------
/***********************************************************************/
GO
USE DB_FLIGHTS;
CREATE TABLE Client(
        id varchar(50) NOT NULL ,
        name varchar(50) NOT NULL,
        lastname varchar(50) NOT NULL,
        email varchar(50),
        phone varchar(50),
		clientState varchar(50) NOT NULL,
        clientType varchar(50) NOT NULL
);
 
	
GO
CREATE PROCEDURE sp_Register
   
	@pId varchar(50),
    @pName varchar(50),
    @pLastname varchar(50),
    @pEmail varchar(50),
    @pPhone varchar(50),
    @pClientState varchar(50),
    @pClientType varchar(10)
AS 
BEGIN
	INSERT INTO Client (id,name,lastname,email,phone,clientState,clientType)
	VALUES (@pId, @pName,@pLastname,@pEmail,@pPhone,@pClientState,@pClientType)
END

GO
CREATE PROCEDURE sp_UpdateClient(
	
	@pId varchar(50),
    @pName varchar(50),
    @pLastname varchar(50),
    @pEmail varchar(50),
    @pPhone varchar(50),
    @pClientState varchar(50),
    @pClientType varchar(50)
	)
AS 
	BEGIN
	UPDATE Client
	SET
	    id=@pId,
        name=@pName,
        lastname=@pLastname,
        email=@pEmail,
        phone=@pPhone,
        clientState=@pClientState,
        clientType=@pClientType
		WHERE id=@pId
END

GO
CREATE PROCEDURE sp_listClients

	AS
	BEGIN
	SELECT id AS ID, name AS NAME, lastname AS LASTNAME,
		   email AS eMail, phone AS PHONE, clientState AS MARITAL_STATUS, clientType AS CUSTOMER_TYPE	
	FROM Client;
END

GO
CREATE PROCEDURE sp_searchById
	(
		@pId varchar (50)
	)
AS
	BEGIN
	SELECT * FROM Client
	WHERE id =@pId
END


 
--select * from Client
