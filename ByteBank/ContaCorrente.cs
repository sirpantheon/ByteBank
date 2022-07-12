
using ByteBank.Titular;

namespace ByteBank{

    public class ContaCorrente
    {

        public Cliente Titular { get; set; }

        private string _conta;
        public string conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                else
                {
                    _conta = value;
                }
            }
        }

        private int _numero_agencia;
        public int numero_agencia
        {
            get
            {
                return _numero_agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                else
                {
                    _numero_agencia = value;
                }
            }
        }

        private double _saldo;
        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        public string nome_agencia { get; set; }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                _saldo = _saldo - valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            _saldo = _saldo + valor;
        }

        public bool Tranferir(double valor, ContaCorrente destino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                _saldo = _saldo - valor;
                destino._saldo = destino._saldo - valor;
                return true;
            }
        }

        public void ExibirDadosDaConta()
        {
            Console.WriteLine("Titular: " + titular);
            Console.WriteLine("Conta: " + conta);
            Console.WriteLine("Número Agencia: " + numero_agencia);
            Console.WriteLine("Nome Agência: " + nome_agencia);
            Console.WriteLine("saldo: " + _saldo);
        }

        public ContaCorrente(int Numero_agencia, string Conta, Cliente titular)
        {
            numero_agencia = Numero_agencia;
            conta = Conta;
            Titular = titular;
            TotalDeContasCriadas += 1;
        }

        public static int TotalDeContasCriadas { get; set; }


    }


}