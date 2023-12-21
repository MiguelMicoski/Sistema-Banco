using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {

            //CalcularBonificacao();

            UsarSistema();


            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            Sistemainterno sistemaInterno = new Sistemainterno();

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            ParceiroComercial parceiro = new ParceiroComercial();

            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(roberta, "12354");
        }

        public static void CalcularBonificacao() 
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            ParceiroComercial parceiro = new ParceiroComercial();

            parceiro.Senha = "123456";

            

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            

            Console.WriteLine("Total de Bonificações: " + gerenciadorBonificacao.GetTotalBonificacao());
        }

    }
}
