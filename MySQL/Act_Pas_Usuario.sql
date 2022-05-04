Use BDC;

Drop procedure Act_Pas_Usuario;

Delimiter $$
Create Procedure Act_Pas_Usuario (
Mail Varchar(30),
Nombre Varchar(30),
Apellido Varchar(30),
NumeroTelefonico Varchar(30)
)
Begin
	Declare Perfil varchar(30);
		declare exit handler for sqlexception
			BEGIN
            rollback;
            end;
            
	start transaction;
    
	Select U.Perfil
    Into Perfil
    From Usuarios U
    Where (
    U.Mail =Mail
    AND  U.Nombre = Nombre
    And U.Apellido = Apellido
    And U.Numero_Telefonico=NumeroTelefonico
    );
    
    Select Perfil;
    
    commit;
End$$
Delimiter ;

select * from usuarios;

Call Act_Pas_Usuario('Tototornamira@gmail.com', 'Tomas', 'Tornamira', '123456789012');