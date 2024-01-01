using DesafioPOO.Models;
// Implementado!!!!
Console.WriteLine("Aparelho Nokia");
Nokia celular1 = new Nokia(numero: "999999999", modelo: "Modelo Nokia 1", imei: "1111111111", memoria: 16);
celular1.Ligar();
celular1.ReceberLigacao();
celular1.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Aparelho Iphone");
Iphone celular2 = new Iphone(numero: "98888-7777", modelo: "Iphone13", imei: "2222222222", memoria: 64);
celular2.Ligar();
celular2.ReceberLigacao();
celular2.InstalarAplicativo("Telegram");