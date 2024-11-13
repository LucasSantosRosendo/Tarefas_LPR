using System;
using System.Collections.Generic;

public class Cliente
{
    public string Nome { get; set; }
    public List<Reserva> Reservas { get; private set; }

    public Cliente(string nome)
    {
        Nome = nome;
        Reservas = new List<Reserva>();
    }
    public void AdicionarReserva(Reserva reserva)
    {
        reserva.Cliente = this;
        Reservas.Add(reserva);
    }
    public void ListarReservasFuturas()
    {
        Console.WriteLine($"Reservas futuras para o cliente {Nome}:");
        foreach (var reserva in Reservas)
        {
            if (reserva.DataReserva > DateTime.Now)
            {
                Console.WriteLine($"Reserva em: {reserva.DataReserva.ToShortDateString()}");
            }
        }
    }
}

public class Reserva
{
    public DateTime DataReserva { get; set; }
    public Cliente Cliente { get; set; }

    public Reserva(DateTime dataReserva)
    {
        DataReserva = dataReserva;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cliente cliente1 = new Cliente("João Silva");
        Cliente cliente2 = new Cliente("Maria Souza");
        Reserva reserva1 = new Reserva(DateTime.Now.AddDays(5));
        Reserva reserva2 = new Reserva(DateTime.Now.AddDays(-2));
        Reserva reserva3 = new Reserva(DateTime.Now.AddDays(10));
        
        cliente1.AdicionarReserva(reserva1);
        cliente1.AdicionarReserva(reserva2);
        cliente2.AdicionarReserva(reserva3);
        cliente1.ListarReservasFuturas();
        cliente2.ListarReservasFuturas();
    }
}
