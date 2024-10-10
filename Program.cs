using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "12345678", modelo: "modelo 1", imei:"222222222", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone (numero: "87654321", modelo: "modelo 2", imei:"111111111", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");