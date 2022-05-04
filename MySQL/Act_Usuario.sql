Use BDC;

Drop procedure Act_Usuario;

Delimiter $$
Create Procedure Act_Usuario (
Mail Varchar(30),
Nombre Varchar(30),
Apellido Varchar(30),
NumeroTelefonico Varchar(30)
)
Begin
	Declare Contraseña varchar(30);
		declare exit handler for sqlexception
			BEGIN
            rollback;
            end;
            
	start transaction;
    
	Select U.contraseña
    Into Contraseña
    From Usuarios U
    Where (
    U.Mail =Mail
    AND  U.Nombre = Nombre
    And U.Apellido = Apellido
    And U.Numero_Telefonico=NumeroTelefonico
    );
    
    Select Contraseña;
    
    commit;
End$$
Delimiter ;

Call Act_Usuario('Tototornamira@gmail.com', 'Tomas', 'Tornamira', '123456789012');