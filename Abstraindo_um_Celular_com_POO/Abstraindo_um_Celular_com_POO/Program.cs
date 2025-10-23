using Abstraindo_um_Celular_com_POO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone = new Iphone("123456789", "iPhone 13", "IMEI123456", 128);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");
iphone.ReceberLigacao();

Console.WriteLine("\n");

Nokia nokia = new Nokia("987654321", "Nokia 3310", "IMEI987654", 32);
nokia.Ligar();
nokia.InstalarAplicativo("Snake");
nokia.ReceberLigacao();


