using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos1
{
    internal class AutenticacaoHelper
    {
        public bool CompararSenhas(string senhaVerdadeira, string senhaTentativa)
        {
            if(senhaVerdadeira == senhaTentativa)
            {
                Console.WriteLine("senha correta");
            }

            else
            {
                Console.WriteLine("senha incorreta");
            }

            return senhaVerdadeira == senhaTentativa;
        }
    }
}
