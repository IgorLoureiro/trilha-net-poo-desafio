using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("9999-8888", "S3", "111111", 64);
Console.WriteLine(nokia.Numero);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("77777-6666", "A5", "2222222", 128);
Console.WriteLine(iphone.Numero);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");