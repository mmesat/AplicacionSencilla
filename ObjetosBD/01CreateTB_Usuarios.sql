USE [USUARIOS]
GO
-- =============================================
-- Author:		Miguel Mesa
-- Create date: <05-16-2021>
-- Description:	<SP de consulta.>
-- =============================================
/****** Object:  Table [dbo].[usuario]    Script Date: 16/5/2021 11:46:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[NumeroIdentificacion] [varchar](50) NULL,
	[Email] [varchar](100) NULL,
	[TipoIdentificacion] [varchar](2) NULL,
	[FechaCreacion] [datetime] NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'tabla de usuarios' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'usuario'
GO


