using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "(71) 9 9845-1256", modelo: "Nokia 5.4 128GB", imei: "977526421", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Nokia(numero: "(41) 9 9821-1629", modelo: "Iphone 11 64GB", imei: "728526497", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp 2");