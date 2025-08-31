using System;
using System.Collections.Generic;

namespace ProjetoHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teste 1: Reserva normal (sem desconto)
            Console.WriteLine("--- Teste de Reserva Normal ---");
            Suite suiteNormal = new Suite("Standard", 3, 100.00m);
            List<Pessoa> hospedesNormal = new List<Pessoa>
            {
                new Pessoa("Ana", "Cunha"),
                new Pessoa("Carlos", "Lima")
            };

            // A propriedade 'Suite' é inicializada aqui para cumprir o 'required'
            Reserva reservaNormal = new Reserva(5) { Suite = suiteNormal }; 
            reservaNormal.CadastrarHospedes(hospedesNormal);

            Console.WriteLine($"Suíte: {reservaNormal.Suite.TipoSuite}");
            Console.WriteLine($"Capacidade: {reservaNormal.Suite.Capacidade}");
            Console.WriteLine($"Hóspedes: {reservaNormal.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Dias: {reservaNormal.DiasReservados}");
            Console.WriteLine($"Valor total: R$ {reservaNormal.CalcularValorDiaria():F2}");
            Console.WriteLine("------------------------------\n");

            // Teste 2: Reserva com desconto (>= 10 dias)
            Console.WriteLine("--- Teste de Reserva com Desconto ---");
            Suite suiteDesconto = new Suite("Família", 6, 200.00m);
            List<Pessoa> hospedesDesconto = new List<Pessoa>
            {
                new Pessoa("João", "Silva"),
                new Pessoa("Maria", "Souza"),
                new Pessoa("Pedro", "Santos")
            };

            // A propriedade 'Suite' é inicializada aqui
            Reserva reservaDesconto = new Reserva(12) { Suite = suiteDesconto };
            reservaDesconto.CadastrarHospedes(hospedesDesconto);
            
            Console.WriteLine($"Suíte: {reservaDesconto.Suite.TipoSuite}");
            Console.WriteLine($"Hóspedes: {reservaDesconto.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Dias: {reservaDesconto.DiasReservados}");
            Console.WriteLine($"Valor total (com desconto de 10%): R$ {reservaDesconto.CalcularValorDiaria():F2}");
            Console.WriteLine("------------------------------------\n");

            // Teste 3: Validação de capacidade (deve lançar uma exceção)
            Console.WriteLine("--- Teste de Validação de Capacidade ---");
            Suite suitePequena = new Suite("Solteiro", 1, 50.00m);
            List<Pessoa> hospedesMuitos = new List<Pessoa>
            {
                new Pessoa("Lucas", "Oliveira"),
                new Pessoa("Isabela", "Pereira")
            };
            
            // A propriedade 'Suite' é inicializada aqui
            Reserva reservaInvalida = new Reserva(3) { Suite = suitePequena };

            try
            {
                reservaInvalida.CadastrarHospedes(hospedesMuitos);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"ERRO: {ex.Message}");
            }
            Console.WriteLine("--------------------------------------\n");
        }
    }
}