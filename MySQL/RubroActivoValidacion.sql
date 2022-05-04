Use BDC;

Drop procedure RAValidacion;

Delimiter $$
Create Procedure RAValidacion (
Actividad integer
)
Begin
	Declare ActCont INT;
	Declare RubCont INT;

	If Actividad=0 then
        Select Count(*)
		INTO ActCont
		From Activo;
        
        Select ActCont;
        
	Else
		Select Count(*)
		INTO RubCont
		From Rubros;
        
		Select RubCont;
        
	End if;

End$$
Delimiter ;

Call RAValidacion();
Call Register('Ejemplo@gmail.com', 'Ivan', 'Oro', '1512341234', 'Activo','1234567');
Call Login('Ejemplo@gmail.com', 'Ivan', 'Oro', '1234567');