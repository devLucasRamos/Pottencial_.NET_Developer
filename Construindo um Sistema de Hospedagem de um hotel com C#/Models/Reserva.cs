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
            if (Suite.Capacidade >= ObterQuantidadeHospedes(hospedes))
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Capacidade menor que o numero de hóspedes recebidos!!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes(List<Pessoa> hospedes)
        {
            int quantidade = 0;
            foreach (object hospede in hospedes)
            {
                quantidade++;
            }
            return quantidade;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;
            if (DiasReservados >= 10)
            {
                decimal desconto = valor / 10;
                valor -= desconto;
            }
            return valor;
        }
    }
}