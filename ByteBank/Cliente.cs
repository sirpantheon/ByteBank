using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Titular
{
    public class Cliente
    {
        public string Nome 
        {
            get
            {
                return Nome;
            }

            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Nome Invalido...");
                }
                else
                {
                    Nome = value;
                }
            }
        }
        public string Cpf 
        {
            get
            {
                return Cpf;
            }

            set
            {
                if (value.Length == 11)
                {
                    Console.WriteLine("Cpf Invalido...");
                }
                else
                {
                    Cpf = value;
                }
            }
        }
        public string Profissao { get; set; }

    }
}
