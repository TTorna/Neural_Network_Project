Use BDC;

Drop procedure IndicadoresValidacion;

Delimiter $$
Create Procedure IndicadoresValidacion (
)
Begin
	Select Count(*)
    From indicadores;
End$$
Delimiter ;

Call IndicadoresValidacion();
Call Register('Ejemplo@gmail.com', 'Ivan', 'Oro', '1512341234', 'Activo','1234567');
Call Login('Ejemplo@gmail.com', 'Ivan', 'Oro', '1234567');