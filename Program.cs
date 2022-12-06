using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "44999552332", modelo: "Modelo 01", imei: "11111", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Uber");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Nokia(numero: "44999447117", modelo: "Modelo 02", imei: "22222", memoria: 120);
iphone.Ligar();
iphone.InstalarAplicativo("Spotify");