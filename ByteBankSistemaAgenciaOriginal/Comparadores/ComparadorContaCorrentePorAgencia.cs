using ByteBank.Modelos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankSistemaAgenciaOriginal.Comparadores
{
    internal class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {
            if(x == y) //ambos nulos
            {
                return 0;
            }

            if (y == null)
            {
                return -1;
            }

            if (x == null) 
            {
                return -1;
            }    
                
            return x.Agencia.CompareTo(y.Agencia);
            
            if (x.Agencia < y.Agencia)
            {
                return -1;     //x fica na frente de y
            }

            if(x.Agencia == y.Agencia)
            {
                return 0;       //são iguais
            }

            return 1; // y fica na frente de y

            //dois modos de comparar (Como o int possui Icomparable é possível utilizá-lo).
        }
    }
}
