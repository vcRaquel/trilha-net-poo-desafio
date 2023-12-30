using DesafioPOO.Models;
// TODO: Realizar os testes com as classes Nokia e Iphone
using System;

class Program
{
    static void Main()
    {
        Nokia smartphone1 = new Nokia(numero: "923456789", modelo: "nokia50", imei: "abc1234", memoria: 128);
        Iphone smartphone2 = new Iphone(numero: "987654321", modelo: "iphone50", imei: "def5678", memoria: 128);

        Console.WriteLine("Smartphone Nokia:");
        smartphone1.Ligar();
        smartphone1.ReceberLigacao();
        smartphone1.InstalarAplicativo(nomeApp: "Whatsapp");

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone Iphone:");
        smartphone2.Ligar();
        smartphone2.ReceberLigacao();
        smartphone2.InstalarAplicativo(nomeApp: "PokemonGo");
    }
}