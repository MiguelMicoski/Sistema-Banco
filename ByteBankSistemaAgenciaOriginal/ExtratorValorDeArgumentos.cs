using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankSistemaAgenciaOriginal
{
    public class ExtratorValorDeArgumentos
    {
        private readonly string _argumentos;
        public string URL { get;}
        public ExtratorValorDeArgumentos(string url)
        {


        
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento não pode ser nulo ou vazio", nameof(url));

            }

            URL = url;

            int IndiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(IndiceInterrogacao + 1);
        }
        public string GetValor(string nomeParametro)
        {

            nomeParametro = nomeParametro.ToUpper();
            
            string argumentoEmCaixaAlta = _argumentos.ToUpper();
            
            string termo = nomeParametro + "="; //moedaDestino=
            int indiceTermo = argumentoEmCaixaAlta.IndexOf(termo);

            string resultado = _argumentos.Substring(indiceTermo + termo.Length);

            int indiceEComercial = resultado.IndexOf('&');

            if(indiceEComercial == -1)
            {
                return resultado;
            }

            return resultado.Remove(indiceEComercial);

            return "";
            // int indiceParametro = _argumentos.IndexOf
        }
    }
}
