using poo_desafio.Models;


Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero:"123456", modelo:"Modelo 1", imei:"11111", memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero:"4987", modelo:"Modelo 2", imei:"22222", memoria:128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
