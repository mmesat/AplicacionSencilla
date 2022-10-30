USE [USUARIOS]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Mesa
-- Create date: <05-16-2021>
-- Description:	<SP de consulta.>
-- =============================================
CREATE	 PROCEDURE SP_ObtenerUsuarios
AS
BEGIN
SELECT A.Id,Nombre,Apellido,Direccion,Telefono,NumeroIdentificacion,Email,TipoIdentificacion,Usuario
  FROM dbo.usuario A
  inner join dbo.login B on A.Id = B.IdUsuario
END
GO
