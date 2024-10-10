using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "12345678");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone iPhoe:");
Smartphone iphone = new Iphone (numero: "87654321");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");