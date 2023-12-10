using DesafioPOO.Models;

Console.WriteLine("Testando o Nokia:");
Nokia nokia = new(numero:"5",modelo:"XL",imei:"imei",memoria:16);

nokia.InstalarAplicativo("Youtube");
nokia.Ligar();
nokia.ReceberLigacao();



Console.WriteLine("\n------------------------\n"+
"Testando o Iphone:");
Iphone iphone = new(numero:"10",modelo:"XS",imei:"imei",memoria:256);

iphone.InstalarAplicativo("Youtube");
iphone.Ligar();
iphone.ReceberLigacao();