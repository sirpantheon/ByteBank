
using ByteBank.Titular;

namespace ByteBank{

    public class ContaCorrente
    {
        public Cliente titular;
        public string conta;
        public int numero_agencia;
        public string nome_agencia;
        private double _saldo;
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
            if(_saldo < valor)
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
                destino._saldo =  destino._saldo - valor;
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

    //public void Set_Saldo(double valor)
    //    {
    //        if (valor < 0)
    //        {
    //            return;
    //        }
    //        saldo = valor;
    //    }


    //public double Get_Saldo()
    //    {
    //        return saldo;
    //    }

    public double Saldo
        {
            get { return _saldo; }
            set 
            {
                if (value<0)
                {
                    return;
                }
                _saldo = value; 
            }
        }

    }


}