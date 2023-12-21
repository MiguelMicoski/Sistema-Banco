using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBankSistemaAgenciaOriginal.Comparadores;
using ByteBankSistemaAgenciaOriginal.Extensoes;
using Humanizer;
using static System.Net.WebRequestMethods;

namespace ByteBankSistemaAgenciaOriginal
{
    public class Class1
    {

        static void Main(string[] args)
        {

            var ContaMinha = new ContaCorrente(55, 22);

            var Joao = new Cliente();

            Joao.Nome = "Joao";
            Joao.CPF = "123213";

            ContaMinha.Titular = Joao;

            ContaMinha.Sacar(150);

            Console.WriteLine(ContaMinha.ContadorSaquesNaoPermitidos);

            Console.ReadLine();



            
            
            
            
          
            
            
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(537, 125),
                null,
                new ContaCorrente(538, 123),
                null,
                new ContaCorrente(535, 124)

            };

            contas.AdicionarVarios(new ContaCorrente(667, 224), new ContaCorrente(667, 223));

;            //contas.Sort(); > Chama o IComparable

            //contas.Sort(new ComparadorContaCorrentePorAgencia());

            

            var contasOrdenadas = contas.Where
                (conta => conta != null)
                .OrderBy(conta => conta.Numero);

            foreach (var conta in contasOrdenadas)
            {
                    Console.WriteLine(conta);
          
            }

            
        }

        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(17);
            listaDeIdades.Adicionar(19);
            listaDeIdades.AdicionarVarios(20, 5, 6, 7);

            

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"mostrando idade no indice {i}: {idade}");
            }

            Console.ReadLine();

        }

        static string TesteParams(params string[] args)
        {
            
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }

            return "";
        }

        static int SomarVarios(params int[] numeros)
        {
            int acumlador = 0;

            foreach (int numero in numeros)
            {
                acumlador += numero;
            }
            return acumlador;
        }

        static void TestaContaCorrente()

        {
            ListadeContaCorrente lista = new ListadeContaCorrente();



            ContaCorrente contaMiguel = new ContaCorrente(3333, 3333);

            lista.Adicionar(contaMiguel);
            lista.Adicionar(new ContaCorrente(444, 64753));

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaMiguel,
                new ContaCorrente(444, 64753)

            };

            lista.AdicionarVarios(contas);



            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente ItemAtual = lista[i];
                Console.Write($"Item na posição {i} = Conta {ItemAtual.Numero}/{ItemAtual.Agencia} \n");
            }

            Console.ReadLine();
        }

























        static void TestaArraydeContaCorrente()
        {

            
            var contas = new ContaCorrente[]
            {
                new ContaCorrente(874, 3452),
                new ContaCorrente(325, 6581),
                new ContaCorrente(356, 5477),


            };

            for (int indices = 0; indices < contas.Length; indices++)
            {
                ContaCorrente contaAtual = contas[indices];
                Console.WriteLine($"Conta {indices} {contaAtual.Agencia}");
            }
        }

        
        
        
    
        static void TestaArrayInt()
        {
            //ARRAY de inteiros, com 5 posições!

            int[] idades = new int[5];


            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;




            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o valor idades no índice {indice}");
                Console.WriteLine($"Valor de idades [{indice}] = {idade}");



                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"A média dos indices é: {media}");

            Console.WriteLine();
            Console.ReadLine();

             
        }

        
        
        
            

        






    }

    
    
    
    
}
      
        
        
