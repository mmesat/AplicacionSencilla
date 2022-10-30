USE [USUARIOS]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Mesa
-- Create date: <05-16-2021>
-- Description:	<SP de insert.>
-- =============================================
CREATE PROCEDURE AgregarUsuario(
	@Nombre varchar(50),
	@Apellido varchar(50),
	@Direccion varchar(50),
	@Telefono varchar(50),
	@NumeroIdentificacion varchar(50),
	@Email varchar(100),
	@TipoIdentificacion varchar(2),
	@Usuario varchar(50),
	@Pass varchar(MAX)

)
AS
BEGIN
	Declare @IdUsuario as int
	insert into dbo.usuario (Nombre,Apellido,Telefono,Direccion,NumeroIdentificacion,Email,TipoIdentificacion,FechaCreacion) values (@Nombre,@Apellido,@Telefono,@Direccion,@NumeroIdentificacion,@Email,@TipoIdentificacion,GETDATE())
	set	@IdUsuario = @@identity
	--set @Pass = PWDENCRYPT(@Pass)
	insert into dbo.login(Usuario,Pass,FechaCreacion,IdUsuario)values(@Usuario,PWDENCRYPT(@Pass),GETDATE(),@IdUsuario)
END
GO