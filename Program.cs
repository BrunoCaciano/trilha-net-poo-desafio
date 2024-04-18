using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "123456789", modelo: "Modelo 2", imei: "2222222", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Fre-Fire");