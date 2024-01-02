using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("(81) 98408-8888", "N68ko", "88888888", 128);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");

Iphone iphone = new Iphone("(82) 9177-5132", "iPhone 15", "55555555", 256);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegran");


