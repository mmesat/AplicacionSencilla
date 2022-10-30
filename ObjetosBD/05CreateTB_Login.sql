USE [USUARIOS]
GO

/****** Object:  Table [dbo].[login]    Script Date: 16/05/2021 08:32:05 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[login](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NULL,
	[Pass] [varbinary](max) NOT NULL,
	[FechaCreacion] [datetime] NULL,
	[IdUsuario] [int] NULL,
 CONSTRAINT [PK_login] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[login]  WITH CHECK ADD  CONSTRAINT [FK_login_usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[usuario] ([Id])
GO

ALTER TABLE [dbo].[login] CHECK CONSTRAINT [FK_login_usuario]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'tabla de login' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'login'
GO


