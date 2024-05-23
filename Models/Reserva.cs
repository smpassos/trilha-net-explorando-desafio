using System.Linq.Expressions;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // *IMPLEMENTADO*
    
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // *IMPLEMENTADO* - O tratamento da exceção com os blocos Try/Catch esta em Program.cs 
                Console.WriteLine("Ocorreu uma exceção: A capacidade da suite não comporta esta quantidade de hóspedes.");
            }

        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // *IMPLEMENTADO*
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // *IMPLEMENTADO*
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // *IMPLEMENTADO*
            if (DiasReservados >= 10)
            {
                valor -= valor * 0.10M;
            }

            return valor;
        }
    }
}