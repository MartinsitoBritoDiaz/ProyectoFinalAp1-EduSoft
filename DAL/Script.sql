Use master
drop database FinalDb

Create database FinalDb

Use FinalDb

Create table Usuarios(
	UsuarioId int primary key identity,
	Nombre varchar(max),
	Celular varchar(max),
	Cedula varchar(max),
	Genero int,
	Email varchar(max),
	Tipo varchar(max),
	Usuario varchar(max),
	Contraseña varchar(max)
);

Create table Profesores(
	ProfesorId int primary key identity,
	Nombre varchar(max),
	Telefono varchar(max),
	Celular varchar(max),
	Cedula varchar(max),
	Genero int,
	Email varchar(max),
	Direccion varchar(max),
	Foto varbinary(max),
	UsuarioId int constraint FK_UsuarioId foreign key (UsuarioId) references Usuarios(UsuarioId),
	Usuario varchar(max),
);

create table Estudiantes(
	EstudianteId int primary key identity,
	Matricula int,
	Nombre varchar(max),
	Telefono varchar(max),
	Celular varchar(max),
	Cedula varchar(max),
	Genero int,
	Email varchar(max),
	Direccion varchar(max),
	Foto varbinary(max),
	UsuarioId int constraint FK_UsuarioId_Estudiantes foreign key (UsuarioId) references Usuarios(UsuarioId),
	Usuario varchar(max)
);

Create table Semestres(
	SemestreId int primary key identity,
	FechaInicio datetime,
	FechaFin datetime,
	Activo bit,
	UsuarioId int constraint FK_UsuarioId_Semestres foreign key (UsuarioId) references Usuarios(UsuarioId),
	Usuario varchar(max)
);

Create table Asignaturas(
	AsignaturaId int primary key identity,
	Nombre varchar(max),
	Creditos int,
	Descripcion varchar(max),
	ProfesorId int constraint FK_ProfesorId foreign key (ProfesorId) references Profesores(ProfesorId),
	NombreProfesor varchar(max),
	UsuarioId int constraint FK_UsuarioId_Asignaturas foreign key (UsuarioId) references Usuarios(UsuarioId),
	Usuario varchar(max)
);

Create table CategoriasAsignaciones(
	CategoriaAsignacionId int primary key identity,
	Nombre varchar(max),
	UsuarioId int constraint FK_UsuarioId_CategoriasAsignaciones foreign key (UsuarioId) references Usuarios(UsuarioId),
	Usuario varchar(max)
);

Create table Asignaciones(
	AsignacionId int primary key identity,
	Nombre varchar(max),
	Categoria varchar(max),
	FechaCreacion datetime,
	FechaEntrega datetime,
	Descripcion varchar(max),
	AsignaturaId int constraint FK_AsignaturaId foreign key (AsignaturaId) references Asignaturas(AsignaturaId)
	On delete cascade
	On update cascade,
	Asignatura varchar(max),
	UsuarioId int constraint FK_UsuarioId_Asignaciones foreign key (UsuarioId) references Usuarios(UsuarioId),
	Usuario varchar(max)
);

Create table Inscripciones(
	InscripcionId int primary key identity,
	SemestreId int constraint FK_SemestreId_Inscripciones foreign key (SemestreId) references Semestres(SemestreId)
	On delete cascade
	On update cascade,
	Fecha datetime default getdate(),
	Asignatura varchar(max) not null,
	CantidadEstudiantes int,
	UsuarioId int constraint FK_UsuarioId_Inscripciones foreign key (UsuarioId) references Usuarios(UsuarioId),
	Usuario varchar(max)
);

Create table EstudiantesDetalles(
	EstudiantesDetalleId int primary key identity,
	InscripcionId int constraint FK_InscripcionId_EstudiantesDetalle foreign key (InscripcionId) references Inscripciones(InscripcionId)
	On delete cascade
	On update cascade,
	Nombre varchar(max),
	Matricula int,
	Asignatura varchar(max)
);

Create table Asistencias(
	AsistenciaId int primary key identity,
	Fecha datetime default getdate(),
	Profesor varchar(max) not null,
	Total int not null,
	CantidadPresentes int default 0,
	CantidadAusentes int default 0,
	CantidadExcusas int default 0,
	SemestreId int constraint FK_SemestreId_Asistencias foreign key (SemestreId) references Semestres(SemestreId) 
	on delete cascade 
	on update cascade,
	UsuarioId int constraint FK_UsuarioId_Asistencias foreign key (UsuarioId) references Usuarios(UsuarioId),
	Usuario varchar(max),
);

Create table EstudiantesAsistenciasDetalles(
	EstudianteId int primary key identity,
	Nombre varchar(max),
	Presente bit default 0,
	Ausente bit default 0,
	Excusa bit default 0,
	Matricula int,
	AsistenciaId int constraint FK_AsistenciaId_EstudiantesAsistenciasDetalle foreign key (AsistenciaId) references Asistencias(AsistenciaId)
	on delete cascade 
	on update cascade
);

