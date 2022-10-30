USE [USUARIOS]
GO
insert into dbo.usuario (Nombre,Apellido,Telefono,Direccion,NumeroIdentificacion,Email,TipoIdentificacion,FechaCreacion) values ('Miguel','mesa','1234567','calle falsa 1223','123456789','nn@nn.com','CC',GETDATE())
insert into dbo.login(Usuario,Pass,FechaCreacion,IdUsuario)values('MIGUEL',PWDENCRYPT('platano'),GETDATE(),1)

