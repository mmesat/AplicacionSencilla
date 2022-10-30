USE [USUARIOS]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Mesa
-- Create date: <05-16-2021>
-- Description:	<SP de delete.>
-- =============================================
CREATE PROCEDURE SP_BorrarUsuario(
	@Id int
)
AS
BEGIN
	delete from dbo.login where IdUsuario = @Id
	delete from dbo.usuario where id = @Id
END
GO
