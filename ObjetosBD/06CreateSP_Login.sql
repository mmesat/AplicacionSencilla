USE [USUARIOS]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Mesa
-- Create date: <05-16-2021>
-- Description:	<SP de Login validacion.>
-- =============================================
CREATE	 PROCEDURE SP_Login
	@Usuario varchar(50),
	@Pass VARBINARY(MAX)
AS
BEGIN

declare @result as int

set @result =(SELECT count(Id)
  FROM dbo.Login where usuario = @Usuario and PWDENCRYPT(@Pass) = pass)

if (@result =0)
 begin
	RAISERROR('usuario y contrasña no coinciden',16,1)
 end
END
GO