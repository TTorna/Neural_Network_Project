Use BDC;

Drop procedure Pedir_Historial;

Delimiter $$
Create Procedure Pedir_Historial (
vFecha_Predic Date /* Apartir de esta fecha se buscan predicciones */

)
Begin
    
    Select P.idPrediccion, P.Fecha_Predic, P.Resultado, Rpu.idUsuario from Predictor P
    inner join Rel_Predic_usuario Rpu ON P.idPrediccion=Rpu.idPrediccion
	Where Fecha_Predic>vFecha_Predic;
    
End$$
Delimiter ;

Call Pedir_Historial(20/11/2021);
Call Register('Ejemplo@gmail.com', 'Ivan', 'Oro', '1512341234', 'Activo','1234567');
Call Login('Ejemplo@gmail.com', 'Ivan', 'Oro', '1234567');