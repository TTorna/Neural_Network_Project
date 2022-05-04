Use BDC;

Drop procedure Prediccionar;

Delimiter $$
Create Procedure Prediccionar (
vActivo integer
,vBanderin integer
,vCanales Integer
,vMACD INTEGER
,vFibbonacci integer
,vTipo integer
)
Begin
	
End$$
Delimiter ;

Call Prediccionar('Ejem@gmail.com', 'Ivan', 'Oro', '1234567');