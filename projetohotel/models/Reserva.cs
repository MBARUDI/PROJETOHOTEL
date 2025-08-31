using System;
using System.Collections.Generic;

namespace ProjetoHotel
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        // O modificador 'required' garante que a propriedade 'Suite'
        // precisa ser inicializada no momento da criação do objeto.
        public required Suite Suite { get; set; } 
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            Hospedes = new List<Pessoa>();
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Validação de capacidade
            if (hospedes.Count > Suite.Capacidade)
            {
                throw new InvalidOperationException("A capacidade da suíte é menor que o número de hóspedes.");
            }
            Hospedes = hospedes;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorTotal = DiasReservados * Suite.ValorDiaria;

            // Aplica desconto de 10% se a reserva for de 10 dias ou mais
            if (DiasReservados >= 10)
            {
                valorTotal *= 0.90m;
            }

            return valorTotal;
        }
    }
}