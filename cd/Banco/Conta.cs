namespace Banco
{
    class Conta
    {
        private double _taxaSaque = 5.0;
        public int Id { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Conta(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public Conta(int id, string nome, double depositoInicial) : this(id, nome)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= (valor + _taxaSaque);
        }


        public override string ToString()
        {
            return $"Conta {Id}, Titular: {Nome}, Saldo: $ {Saldo:F2}";
        }
    }
}
