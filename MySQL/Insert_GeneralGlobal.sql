Use BDC;

Insert into BDC.Activo(NombreActivo)
Values("BTC/USDT");

Insert into BDC.Activo(NombreActivo)
Values("BNB/USDT");

Insert into BDC.Activo(NombreActivo)
Values("XRP/USDT");

Insert into BDC.Activo(NombreActivo)
Values("ETH/USDT");

Insert into BDC.Grafico(Link)
Values("https://es.tradingview.com/symbols/BTCUSDT/");

Insert into BDC.Grafico(Link)
Values("https://es.tradingview.com/symbols/BNBUSDT/");

Insert into BDC.Grafico(Link)
Values("https://es.tradingview.com/symbols/XRPUSDT/");

Insert into BDC.Grafico(Link)
Values("https://es.tradingview.com/symbols/ETHUSDT/");

Insert into BDC.Rubros(Tipo,Descripcion)
Values(1,"Criptocurrency");

Insert into BDC.Rubros(Tipo,Descripcion)
Values(2,"Acciones");

Insert into BDC.Indicadores(Descripcion,Mapeo)
Values("Activo",1);

Insert into BDC.Indicadores(Descripcion,Mapeo)
Values("Banderin",2);

Insert into BDC.Indicadores(Descripcion,Mapeo)
Values("Canales",3);

Insert into BDC.Indicadores(Descripcion,Mapeo)
Values("MACD",4);

Insert into BDC.Indicadores(Descripcion,Mapeo)
Values("Fibbonacci",5);

Insert into BDC.Indicadores(Descripcion,Mapeo)
Values("Roi",6);

Insert into BDC.Indicadores(Descripcion,Mapeo)
Values("Rubro",7);

Insert into BDC.Indicadores(Descripcion,Mapeo)
Values("Pasivo/Activo",8);

Insert into BDC.Indicadores(Descripcion,Mapeo)
Values("Conservador/Moderado/Agrecivo",9);

Insert into BDC.Indicadores(Descripcion,Mapeo)
Values("Repercucion",10);

Insert into BDC.Indicadores(Descripcion,Mapeo)
Values("ICC",11);

Insert into BDC.Indicadores(Descripcion,Mapeo)
Values("Acciones realizadas sobre el activo",12);

Insert into BDC.Perfil(Personalidad,Estrategia) 
Values ("Activo","Se tiene en cuenta que la prediccion puede ser arriesgada");

Insert into BDC.Perfil(Personalidad,Estrategia) 
Values ("Pasivo", "Se tiene en cuenta que la prediccion es poco arriesgada");

Insert into BDC.Rel_activo_grafico(idActivo,IdGrafico)
Values(1,1);

Insert into BDC.Rel_activo_grafico(idactivo,idgrafico)
Values(2,2);

Insert into BDC.Rel_activo_grafico(idactivo,idgrafico)
Values(3,3);

Insert into BDC.Rel_activo_grafico(idactivo,idgrafico)
Values(4,4);

Insert into BDC.Rel_rubro_activo(idactivo,idRubro)
Values(1,1);

Insert into BDC.Rel_rubro_activo(idactivo,idRubro)
Values(2,1);

Insert into BDC.Rel_rubro_activo(idactivo,idRubro)
Values(3,1);

Insert into BDC.Rel_rubro_activo(idactivo,idRubro)
Values(4,1);

Insert into BDC.Rel_Ind_activo(idactivo,idindicador)
Values(1,1);

Insert into BDC.Rel_Ind_activo(idactivo,idindicador)
Values(2,1);

Insert into BDC.Rel_Ind_activo(idactivo,idindicador)
Values(3,1);

Insert into BDC.Rel_Ind_activo(idactivo,idindicador)
Values(4,1);

Insert into BDC.Roles(Tipo,Descripcion) 
Values (1,"Usuario");

Insert into BDC.Roles(Tipo, Descripcion)
Values (2, "Admin");

Select * From Indicadores;