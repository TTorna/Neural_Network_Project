use BDC; 

Drop procedure Predictor_Completo;

delimiter //
create procedure Predictor_Completo (
vIdUsuario integer
,vResultado varchar(30)
, vIndi1 integer
, vIndi2 integer
, vIndi3 integer
, vIndi4 integer
, vIndi5 integer
, vIndi6 integer
, vIndi7 integer
, vIndi8 integer
, vIndi9 integer
, vIndi10 integer
, vIndi11 integer
, vIndi12 integer
, vIndi13 integer
, vIndi14 integer  
)
Begin
declare fechaDeHoy date; 
declare vidPrediccion int; 

select now() into fechaDeHoy;

insert into Predictor (Fecha_Predic, Resultado) values(fechahoy, vResultado);


select idPrediccion into vidPrediccion from Predictor where fecha = fechaDeHoy and resultado = vResultado order by idPrediccion desc limit 1; 

insert into Rel_Predic_usuario(idUsuario, idPrediccion) values (vIdUsuario, vidPrediccion);


insert into Rel_Ind_Predic(idIndicadores,idPrediccion,Valor) values (1, vIdPrediccion, vIndi1); 
insert into Rel_Ind_Predic(idIndicadores,idPrediccion,Valor) values (2, vIdPrediccion, vIndi2); 
insert into Rel_Ind_Predic(idIndicadores,idPrediccion,Valor) values (3, vIdPrediccion, vIndi3); 
insert into Rel_Ind_Predic(idIndicadores,idPrediccion,Valor) values (4, vIdPrediccion, vIndi4); 
insert into Rel_Ind_Predic(idIndicadores,idPrediccion,Valor) values (5, vIdPrediccion, vIndi5); 
insert into Rel_Ind_Predic(idIndicadores,idPrediccion,Valor) values (6, vIdPrediccion, vIndi6); 
insert into Rel_Ind_Predic(idIndicadores,idPrediccion,Valor) values (7, vIdPrediccion, vIndi7); 
insert into Rel_Ind_Predic(idIndicadores,idPrediccion,Valor) values (8, vIdPrediccion, vIndi8); 
insert into Rel_Ind_Predic(idIndicadores,idPrediccion,Valor) values (9, vIdPrediccion, vIndi9); 
insert into Rel_Ind_Predic(idIndicadores,idPrediccion,Valor) values (10, vIdPrediccion, vIndi10); 
insert into Rel_Ind_Predic(idIndicadores,idPrediccion,Valor) values (11, vIdPrediccion, vIndi11); 
insert into Rel_Ind_Predic(idIndicadores,idPrediccion,Valor) values (12, vIdPrediccion, vIndi12); 
insert into Rel_Ind_Predic(idIndicadores,idPrediccion,Valor) values (13, vIdPrediccion, vIndi13); 
insert into Rel_Ind_Predic(idIndicadores,idPrediccion,Valor) values (14, vIdPrediccion, vIndi14);

end //
delimiter ;


call Predictor_Completo(1,"resultado",1,2,3,4,5,6,7,8,9,10,11,12,13,14)