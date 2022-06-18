using System.Globalization;

namespace ContaCorrente
{
    class Conta
    {
        private string _nroConta;
        private string _nomeTitular;
        private double _saldo;
        private const double TAXASAQUE=5;

        public string NomeTitular { get; set; }

        public Conta(string nroConta, string nomeTitular)
        {
            this._nroConta = nroConta;
            this._nomeTitular = nomeTitular;
            this._saldo = 0.0;
        }

        public Conta(string nroConta, string nomeTitular, double saldo) : this(nroConta, nomeTitular)
        {
            this._saldo = saldo;
        }

        public string NroConta { get { return _nroConta; } private set { } }

        public void Deposito (double valor)
        {
            _saldo += valor;
        }

        public void Saque (double valor)
        {
            _saldo -= (valor + TAXASAQUE);
        }

        public override string ToString()
        {
            return "Conta " + _nroConta  + " titular: " + _nomeTitular + " Saldo: $ " + _saldo.ToString("F2",CultureInfo.InvariantCulture); 
        }
    }
}
