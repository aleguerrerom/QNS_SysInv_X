using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNV_Inventario.MVCModel
{
    class Respaldo_BD
    {
        /*OJO RESPALDO DEL 29 DE MAYOOOOOOOOOO
 /////////////////////////TABLAS//////////////////////////
         alter TABLE AuditLog (
    ID int IDENTITY(1,1) PRIMARY KEY,
    usuario varchar(50) NOT NULL,
    fechaInicio datetime NOT NULL,
    fechaSalida datetime NULL
);


ALTER TABLE ROL
ADD bitacora bit NOT NULL

ALTER TABLE ROL (
    ID int IDENTITY(1,1) PRIMARY KEY,
    nombre varchar (30) NOT NULL,
    inventario bit NOT NULL,
    usuarios bit NOT NULL,
    prestamo bit NOT NULL,
    entrega bit NOT NULL,
    roles bit NOT NULL,
    bitacora bit NOT NULL,
);

CREATE TABLE MoviemientosLog(
	ID int IDENTITY(1,1) PRIMARY KEY,
	usuario varchar(50),
	fecha datetime NOT NULL,
	moviemiento varchar(50),
	detalle varchar (100)
)

CREATE TABLE Usuarios(
 usuario varchar(50) PRIMARY KEY,
 clave varchar(50) NOT NULL,
 activo bit NOT NULL,
 rol int NOT NULL,
 nombre varchar(50) NOT NULL,
 apellido varchar(50) NOT NULL,
 correo varchar(50) NOT NULL
)

CREATE TABLE Inventario (
ID int IDENTITY(1,1) PRIMARY KEY,
nombre varchar(50) NOT NULL,
tipo varchar(50) NOT NULL,
serialnumber varchar(50) NOT NULL,
marca varchar(50) NOT NULL,
modelo varchar(50) NOT NULL,
estado varchar(50) NOT NULL,
fechamodificacion datetime NOT NULL,
usuario varchar(50) NOT NULL
)
     
        ////////////////////SP///////////////////////
        ///
        USE [DB_CNV]
GO
/** Object:  StoredProcedure [dbo].[SPRoles]    Script Date: 29/05/2021 18:42:12 
        SET ANSI_NULLS ON
        GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure[dbo].[SPRoles]
        @opc int,  @nombre varchar(50)=null,@inventario bit = null, @usuarios bit=null, @prestamo bit = null,
           @entrega bit= null, @roles bit = null, @bitacora bit = null, @ID int = null
as
if @opc = 1
begin

    select* from Rol
end

if @opc = 2
begin
    insert into Rol values(@nombre, @inventario, @usuarios, @prestamo, @entrega, @roles, @bitacora)
end

if @opc = 3
begin
    delete from Rol where nombre = @nombre
end

if @opc = 4
begin
    update Rol set nombre=nombre,
	inventario=@inventario, usuarios = @usuarios, prestamo = @prestamo, entrega=@entrega,
	roles=@roles, bitacora=@bitacora where nombre=@nombre
end

if @opc = 5
begin
    select nombre from Rol
end

if @opc = 6
begin
    select A.ID, A.bitacora, A.entrega, A.inventario, A.prestamo, A.roles, A.usuarios from Rol A, Usuarios B where A.ID = b.rol and a.id = @ID
 end

        /////////////////////////////////////////////////////

        USE [DB_CNV]
GO
/** Object:  StoredProcedure [dbo].[SPUsuario]    Script Date: 29/05/2021 21:45:22 
        SET ANSI_NULLS ON
        GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure[dbo].[SPUsuario]
        @opc int, @usuario varchar(50)=null,@clave varchar(50)=null,@activo int=null, @rol int=null,
	@nombre varchar(50)= null, @apellido varchar(50) = null, @correo varchar(50) = null
as
if @opc = 1
begin

    select* from Usuarios
end

if @opc = 2
begin
    insert into Usuarios values(@usuario, @clave, @activo, @rol, @nombre, @apellido, @correo)
end

if @opc = 3
begin
    delete from Usuarios where usuario = @usuario
end

if @opc = 4
begin
    update Usuarios set usuario=@usuario,clave=@clave,
	activo=@activo,rol=@rol, nombre = @nombre, apellido = @apellido, correo = @correo where usuario=@usuario

end

if @opc = 5
begin


    select* from Usuarios where usuario = @usuario and clave = @clave and activo = 1
	
end


        /////////////////////////////////////////////
        USE [DB_CNV]
GO
/****** Object:  StoredProcedure [dbo].[SPBitacora]    Script Date: 29/05/2021 21:45:11 *
        SET ANSI_NULLS ON
        GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure[dbo].[SPBitacora]
        @opc int, @id int=null, @usuario varchar(50)=null,@fechainicio date = null, @fechaSalida date=null, @fecha date = null, @movimiento varchar(50)=null,
	@detalle varchar(100)=null
as
if @opc = 1
begin

    select* from AuditLog
end

if @opc = 2
begin
    insert into AuditLog values(@usuario, GETDATE(),NULL)
end

if @opc = 3
begin
    update AuditLog set fechaSalida=GETDATE() where usuario=@usuario
end

if @opc = 4
begin

    select* from MovimientosLog
end

if @opc = 5
begin

    insert into MovimientosLog values(@usuario, GETDATE(), @movimiento, @detalle)
end

        USE [DB_CNV]
GO


        ///////////////////////
/****** Object:  StoredProcedure [dbo].[SPInventario]    Script Date: 29/05/2021 21:46:16 ******
        SET ANSI_NULLS ON
        GO
SET QUOTED_IDENTIFIER ON
GO

ALTER procedure[dbo].[SPInventario]
        @opc int, @id int= null ,@nombre varchar(50)=null,@tipo varchar(50)=null,@serialnumber varchar(50)=null,@marca varchar(50)=null,
	@modelo varchar(50)= null, @estado varchar(50) = null, @fechamodificacion datetime = null, @usuario varchar(50)= null
as
if @opc = 1
begin

    select* from Inventario
end

if @opc = 2
begin
    insert into Inventario values(@nombre, @tipo, @serialnumber, @marca, @modelo, @estado, @fechamodificacion, @usuario)
end

if @opc = 3
begin
    delete from Inventario where nombre = @nombre
end

if @opc = 4
begin
    update Inventario set nombre=@nombre,tipo=@tipo,
	serialnumber=@serialnumber,marca=@marca, modelo =@modelo, estado = @estado, fechamodificacion = @fechamodificacion where  nombre = @nombre


end


         */
    }
}
