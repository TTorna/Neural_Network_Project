Use BDC;

Insert into BDC.Activo(NombreActivo,LinkGrafico)
Values("BTC/USDT","https://es.tradingview.com/symbols/BTCUSDT/");

Insert into BDC.Activo(NombreActivo,LinkGrafico)
Values("BNB/USDT","https://es.tradingview.com/symbols/BNBUSDT/");

Insert into BDC.Activo(NombreActivo,LinkGrafico)
Values("XRP/USDT","https://es.tradingview.com/symbols/XRPUSDT/");

Insert into BDC.Activo(NombreActivo,LinkGrafico)
Values("ETH/USDT","https://es.tradingview.com/symbols/ETHUSDT/");

Insert into BDC.Rubros(Tipo,Descripcion)
Values(1,"Criptocurrency");

Insert into BDC.Rubros(Tipo,Descripcion)
Values(2,"Acciones");


Select * From Indicadores;