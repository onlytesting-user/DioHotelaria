﻿using System.Text;
using DesafioHospedagem.Models;

namespace DesafioHospedagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Pessoa> hospedes = new List<Pessoa>();

            Pessoa p1 = new Pessoa(nome: "Hóspede 1");
            Pessoa p2 = new Pessoa(nome: "Hóspede 2");
            Pessoa p3 = new Pessoa(nome: "Hospede 3");

            hospedes.Add(p1);
            hospedes.Add(p2);
            hospedes.Add(p3);

            Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 50);

            Reserva reserva = new Reserva(diasReservados: 10);
            reserva.CadastrarSuite(suite);
            reserva.CadastrarHospedes(hospedes);

            Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
        }
    }
}
