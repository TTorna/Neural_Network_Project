Use BDC;

Drop procedure Actualizar_Rubro;

Delimiter $$
Create Procedure Actualizar_Rubro (
Actividad integer
,_IdRubro integer
,_Tipo Integer
,_Descripcion Varchar(30)
)
Begin
	Declare Agregar INT;
	Declare Sacar INT;

	If Actividad=0 then
        Insert INTO BDC.Rubros(
		Tipo
		,Descripcion)
		Values(
		_Tipo
		,_Descripcion);
    
	Else
		Delete From BDC.Rubros
        Where IdRubro=_IdRubro
        And Tipo=_Tipo;
        
	End if;

End$$
Delimiter ;

Call Actualizar_Rubro();
Call Register('Ejemplo@gmail.com', 'Ivan', 'Oro', '1512341234', 'Activo','1234567');
Call Login('Ejemplo@gmail.com', 'Ivan', 'Oro', '1234567');