using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasRepeticao_Exec
{
    class Program
    {
        static void Main(string[] args)
        {

            //1- A diretora de uma escola precisa de um programa C# que exiba a mesma mensagem de boas
            //   vindas para os 10 novos alunos da escola utilizando a estrutura foreach. */

            /* string[] Alunos = { "Ana", "João", "Paulo", "Leandro", "Carlos", "Pedro", "Diego", "Sabrina", "Evander", "Cunha" };

               foreach (string Aluno in Alunos)
               {
                   Console.WriteLine("Seja Bem-Vindo(a) " + Aluno + ", a sua nova escola." );
               }

               Console.ReadLine();
            */

            //-----------------------------//-------------------------

            //2- Crie um programa C# utilizando as etruturas de repetição, que contabilize a velocidade
            //   de um carro de formula 1, sem ultrapassar o limite de 200km/h permitido na pista,
            //   exiba uma mensagem no final informando que chegou no limite.

            /* int velocidade = 0;

            do
            {
                Console.WriteLine("Você está a " + velocidade + " km/h");
                velocidade+=10;
            } while (200 >= velocidade);

            Console.WriteLine("Você chegou no limite de velocidade permitida!");
            Console.ReadLine();
            */

            //-----------------------------//-------------------------

            //3- Crie um programa C# que exiba para os clientes de um mercado que está aberto
            //   sob a condição do seu horário de funcionamento das 7h às 17h após esse horário
            //   exibir uma mensagem de que se encontra fechado e indicando o horário de
            //   funcionamento deste estabelecimento.


            /*Console.WriteLine("Digite a hora desejada: ");
              int hora = int.Parse(Console.ReadLine());

              if (hora > 6 && hora < 18)
              {
                  Console.WriteLine("Estabelecimento aberto. Seja bem-vindo!");
              }else
                  Console.WriteLine("Estabelecimento fechado. Funcionamento de 7:00 as 17:00 hrs.");

              Console.ReadLine();
            */

            //-----------------------------//-------------------------

            // 4- Crie um programa C# que exiba um cardápio de uma pizzaria contando 10 sabores
            // de pizza, exiba na tela repetindo a frase: “ Temos o sabor: ” “Aproveite a refeição”
            // nos 10 sabores.

            /* string[] pizzas = { "Frango", "Calabresa", "Queijo", "Bacon", "Moda", "Milho", "Carne", "Brigadeiro", "Almondega", "Cogumelo"};

             foreach (string pizza in pizzas)
             {
                 Console.WriteLine("Temos o sabor: " + pizza + ". Aproveite a refeição!");
             }

             Console.ReadLine();
            */

            //-----------------------------//-------------------------

            //5- Utilizando as estruturas de repetição, crie um programa C# que Realize uma
            //   Contagem regressiva de 1000 a 1 para que um foguete seja lançado ao espaço.

           /* int contador = 1000;
              while (contador >=0)
              {
                  Console.WriteLine("Faltam " + contador + " segundos para o lançamento!");
                  contador--;
              }

              Console.WriteLine("LANÇADO COM SUCESSO!!");
              Console.ReadLine();
           */

        }
    }
}
