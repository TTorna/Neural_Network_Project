Use BDC;

Drop procedure Actualizar_Activo;

Delimiter $$
Create Procedure Actualizar_Activo (
Actividad integer
,_IdActivo integer
,_NombreActivo Varchar(30)
,_LinkGrafico Varchar(30)
)
Begin
	Declare Agregar INT;
	Declare Sacar INT;
		declare exit handler for sqlexception
			BEGIN
            rollback;
            end;
            
	start transaction;

	If Actividad=0 then
        Insert INTO BDC.Activo(
		NombreActivo
		,LinkGrafico)
		Values(
		_NombreActivo
		,_LinkGrafico);
    
	Else
		Delete From BDC.Activo
        Where IdActivo=_IdActivo
        And NombreActivo=_NombreActivo;
        
	End if;
    
    commit;
End$$
Delimiter ;

Call Actualizar_Activo(1, "");
Call Register('Ejemplo@gmail.com', 'Ivan', 'Oro', '1512341234', 'Activo','1234567');
Call Login('Ejemplo@gmail.com', 'Ivan', 'Oro', '1234567');