Use BDC;

Drop procedure login;

Delimiter $$
Create Procedure Login (
Mail Varchar(30),
Nombre Varchar(30),
Apellido Varchar(30),
Contraseña Varchar(30)
)
Begin
	Declare Devolucion INT;
    
	Select Count(1)
    Into Devolucion
    From Usuarios
    Where (
    usuarios.Mail =Mail
    AND  usuarios.Nombre = Nombre
    And usuarios.Apellido = Apellido
    And usuarios.Contraseña=Contraseña
    );
    Select Devolucion;
End$$
Delimiter ;

Call Login('Ejem@gmail.com', 'Ivan', 'Oro', '1234567');