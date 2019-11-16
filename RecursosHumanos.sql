create database RecursosHumanos
go
use RecursosHumanos
go

create table cargos(
		id int primary key identity (1,1),
		code_crg varchar (5) not null,
		cargo varchar (50) not null
)
go
create table departamentos(
		id int primary key identity (1,1),
		code_Dpt varchar (5) not null,
		Nombre varchar (100) not null,
		Encargado int not null Constraint FK_Encargado FOREIGN KEY (Encargado) REFERENCES cargos(id),

)

go

create table empleados (
		id int  primary key identity (1,1),
		code_empleado varchar (5) not null,
		nombre varchar (100) not null,
		apellido varchar (200) not null,
		telefono varchar (10) not null,
		Departamento int not null Constraint FK_Departamentos FOREIGN KEY (Departamento) REFERENCES departamentos(Id),
		Cargo int not null Constraint FK_Cargos  FOREIGN KEY (Cargo) REFERENCES cargos(Id),
		fecha_ingreso date,
		salario int not null,
		estatus varchar (1) not null 
)
go

insert into cargos(code_crg, cargo)values
	('CG1', 'Presidente'),--1
	('CG2', 'Encargado Administracion'),--2
	('CG3', 'Encargado de Finanzas'),--3
	('CG4', 'Encargado Recursos Humanos'),--4
	('CG5', 'Encargado de Marketing'),--

	('CG1', 'Gerente de Operaciones'), --6

	
	('CG2', 'Supervisor de Produccion'), --7

	
	('CG3', 'Contable'),--8

	
	('CG4', 'Contrataciones'),--9
	('CG4', 'Capacitador'), --10
	('CG4', 'Seguros'), --11

	
	('CG5', 'Publicista'), --12
	('CG5', 'Redes Sociales'), --13
	('CG5', 'Vendedor') --14
go


insert into departamentos(code_Dpt, Nombre, Encargado) values
('DG1', 'Gerencia', 1),
('DA1', 'Administracion', 2),
('DF1', 'Finanzas', 3),
('DF1', 'Recursos Humanos', 4),
('DF1', 'Marketing', 5)
go

insert into empleados (code_empleado, nombre,apellido,telefono,Departamento,Cargo,fecha_ingreso,salario,estatus)values
('EDG', 'Jesus Manuel', 'De la Cruz Medrano', '8297805945', 1, 1, '2019-04-01', 50000, 'A'),
('EDA', 'Alita', 'Romero', '8097805945', 2, 2, '2019-04-11', 49000, 'A'),
('EDF', 'Margaret', 'Amabel', '8097005945', 3, 3, '2019-04-11', 50000, 'A'),
('EDRH', 'Evelyn', 'Magdalena', '8297005945', 4, 4, '2019-04-15', 35000, 'A'),
('EDM', 'Miguel', 'Cespedes', '8093005945', 5, 5, '2019-05-15', 30000, 'A')


go


create table nomina(
		id int primary key identity,
		anio int,
		mes varchar (30),
		total_Mnt int not null
)
go

create table salida (
		idEmpleado int not null Constraint FK_empleadoDespido FOREIGN KEY (idEmpleado) REFERENCES empleados(Id),
 		tpSalida varchar (40) not null,
		Motivo varchar (200) not null,
		Fecha_Salida date,
		
)
go




create table vacaciones (
	empleado int not null constraint FK_empleadoVacaciones foreign key (empleado) references empleados(id),
	inicio date,
	hasta date,
	comentarios varchar (200)
)
go


create table permisos (
	empleado int not null constraint FK_empleadoPermiso foreign key (empleado) references empleados(id),
	inicio date,
	hasta date,
	comentarios varchar (200) not null
)
go


create table licencias (
	empleado int not null constraint FK_empleadoLicencia foreign key (empleado) references empleados(id),
	inicio date,
	hasta date,
	comentarios varchar (200) not null
)
go



--*************************************************procesos de almacenado**************************************************

create procedure nuevoEmpleado
@code_empleado varchar (5),
@nombre varchar (100),
@apellido varchar (200),
@telefono varchar (10),
@departamento int,
@cargo int,
@fecha_ingreso date,
@salario int,
@estatus varchar
as
begin

insert into empleados values
(@code_empleado, @nombre, @apellido, @telefono, @departamento, @cargo, @fecha_ingreso, @salario, @estatus)

end

go


create procedure actualizarEmpleado
@nombre varchar(100),
@apellido varchar (100),
@telefono varchar (10),
@departamento int,
@cargo int,
@salario int,
@user int
as 
begin
update empleados set @nombre = nombre , @apellido = apellido, @telefono = telefono, @departamento = departamento , @cargo = cargo, @salario=salario  where @user =id

end
go


create procedure nominaCalculo

@anio int,
@mes varchar (30)
as
begin 
		declare 
		set @total = (select SUM(salario) from empleados where estatus = 'A')
		insert into nomina (anio, mes, total_Mnt) values (@mes, @anio, @total)
end
go





create procedure despedida
@empleado int,
@tpsalida varchar (250),
@motivo varchar (250),
@fecha_Salida date
as
begin 
insert into salida values (@empleado, @tpsalida, @motivo, @fecha_Salida)
update empleados set estatus = 'I' where @empleado = id
end
go



create procedure insertarVacaciones 
@empleado int,
@inicio date,
@hasta date,
@comentarios varchar (250)
as
begin
insert into vacaciones values (@empleado, @inicio, @hasta, @comentarios)
end
go

create procedure InsertarPermiso
@empleado int,
@inicio date,
@hasta date,
@comentarios varchar (250)
as
begin
insert into permisos values (@empleado, @inicio, @hasta, @comentarios)
end
go

create procedure insertarLicencia
@empleado int,
@inicio date,
@hasta date,
@comentarios varchar (250)
as
begin
insert into licencias values (@empleado, @inicio, @hasta, @comentarios)
end
go






/***************************************************************************************************************************/




create procedure empleadosActivos
as
begin
select empleados.id, empleados.code_empleado as [Codigo], empleados.nombre, empleados.apellido, empleados.telefono, departamentos.Nombre as [Departamento], cargos.cargo as [Cargo], empleados.salario, empleados.estatus, empleados.fecha_ingreso 
from empleados left join departamentos on departamentos.id = empleados.Departamento
  left join cargos on cargos.id = empleados.Cargo where empleados.estatus = 'A'
end

exec empleadosActivos

go

create procedure empleadosInactivos
as
begin
select salida.idEmpleado, salida.tpSalida, salida.Motivo, salida.Fecha_Salida, empleados.nombre from salida join empleados on salida.idEmpleado = empleados.id

end
go

create procedure departamentosE
as
begin
select empleados.id, departamentos.nombre as [Departamento], departamentos.code_Dpt as [Codigo], empleados.nombre as[Encargado] from empleados join departamentos on empleados.id = departamentos.Encargado
group by empleados.id, departamentos.nombre, empleados.nombre, departamentos.code_Dpt
end
go

create procedure cargosE
as
begin
select cargos.id, cargos.cargo as [Cargo], cargos.code_crg from cargos
end
go



create procedure empDepartamento
as
begin
select empleados.id, empleados.code_empleado as [Codigo], empleados.nombre, empleados.apellido, empleados.telefono, departamentos.Nombre as [Departamento], cargos.cargo as [Cargo], empleados.salario, empleados.estatus, empleados.fecha_ingreso 
from empleados  join departamentos on departamentos.id = empleados.id 
 join cargos on cargos.id = empleados.Cargo where departamentos.Nombre='Marketing'
end

go

create procedure buscarEmpleado
@codigo varchar (10)
as
begin
select empleados.id, empleados.code_empleado as [Codigo], empleados.nombre, empleados.apellido, empleados.telefono, departamentos.Nombre as [Departamento], cargos.cargo as [Cargo], empleados.salario, empleados.estatus, empleados.fecha_ingreso 
from empleados left join departamentos on departamentos.id = empleados.id 
left join cargos on cargos.id = empleados.Cargo where empleados.code_empleado = @codigo
end


create procedure buscarPorCargo
@cargo varchar (10)
as
begin
select empleados.id, empleados.code_empleado as [Codigo], empleados.nombre, empleados.apellido, empleados.telefono, departamentos.Nombre as [Departamento], cargos.cargo as [Cargo], empleados.salario, empleados.estatus, empleados.fecha_ingreso 
from empleados left join departamentos on departamentos.id = empleados.id 
left join cargos on cargos.id = empleados.Cargo where empleados.Cargo=@cargo and empleados.estatus='A'
end

create procedure buscarPorDepart
@departamento varchar (10)
as
begin
select empleados.id, empleados.code_empleado as [Codigo], empleados.nombre, empleados.apellido, empleados.telefono, cargos.cargo as [Cargo], empleados.salario, empleados.estatus, empleados.fecha_ingreso 
from empleados left join departamentos on departamentos.id = empleados.id 
left join cargos on cargos.id = empleados.Cargo where empleados.Departamento =@departamento and empleados.estatus='A'
end
go


create procedure MostrarVacaciones
as
begin
	select vacaciones.empleado as [ID], empleados.nombre, vacaciones.inicio, vacaciones.hasta, vacaciones.comentarios from vacaciones join empleados on empleados.id = vacaciones.empleado
end
go


create procedure MostrarLicencias
as
begin
	select licencias.empleado as [ID], empleados.nombre, licencias.inicio, licencias.hasta, licencias.comentarios from licencias join empleados on empleados.id = licencias.empleado
end
go



create procedure MostrarPermisos
as
begin
	select permisos.empleado as [ID], empleados.nombre, permisos.inicio, permisos.hasta, permisos.comentarios  from permisos join empleados on empleados.id = permisos.empleado
end
go








create procedure nominas
as
begin
	select nomina.id, nomina.mes, nomina.anio, nomina.total_Mnt from nomina
end
go

