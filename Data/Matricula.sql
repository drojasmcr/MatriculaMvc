use dbmatriculal;

CREATE TABLE MATERIAS(
	ID INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_MATERIAS PRIMARY KEY,
	CODIGO_MATERIA VARCHAR(10) NOT NULL,
	NOMBRE_MATERIA VARCHAR(120) NOT NULL,
	HORAS_TOTALES TINYINT NOT NULL DEFAULT 100,
	BORRADO_MATERIA BIT NOT NULL DEFAULT 0 --0 EQUIVALE A NO BORRADO, 1 EQUIVALE A BORRADO
)
    
insert into MATERIAS ( CODIGO_MATERIA , NOMBRE_MATERIA , HORAS_TOTALES  )
values ( 'EF002', 'Movimiento creativo', 78 )