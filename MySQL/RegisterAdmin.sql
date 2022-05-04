Use BDC;

Drop procedure RegisterAdmin;

Delimiter $$
Create Procedure RegisterAdmin (
_Mail Varchar(30),
_Nombre Varchar(30),
_Apellido Varchar(30),
_Numero_Telefonico Varchar(30),
_Perfil INT,
_Contraseña Varchar(30)
)
Begin
	Declare Devolucion INT;
    declare exit handler for sqlexception
			BEGIN
            rollback;
            end;
            
	start transaction;
    
    Insert INTO Usuarios(
	Mail
	,Nombre
    ,Apellido
    ,Numero_Telefonico
    ,Contraseña)
    Values(
    _Mail
	,_Nombre
    ,_Apellido
    ,_Numero_Telefonico
    ,_Contraseña
    );
    
    Insert into Rel_Rol_Usuario(
    IdUsuario
    ,IdRol
    )Values(last_insert_id(),2);
    
	Insert into Rel_Usuario_Perfil(
    IdPerfil
    ,IdUsuario
    )Values(_Perfil,last_insert_id());
    
    Select Devolucion;
    
        commit;
End$$
Delimiter ;

Call RegisterAdmin('Admin@gmail.com', 'Tomas', 'Tornamira', '123456789017', 1,'ClaveRed');