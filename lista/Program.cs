using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXE01- Escreva um programa que verifique se um número fornecido pelo usuário é positivo, negativo ou zero.

            int n1 = 0;
            Console.Write("Digite um numero: ");
            n1= int.Parse(Console.ReadLine());

            if (n1 == 0) 
            {
                Console.WriteLine("Você digitou 0");
            }
            else if (n1 >= 1) {
               Console.WriteLine("Seu numero é positivo");
            }
            else { Console.WriteLine(" seu numero é negativo");
            }

            //Escreva um programa que leia um mês do ano e informe quantos dias ele tem.
              Console.WriteLine("EXERCICIO02");
            Console.WriteLine("");

            int mes = 0;
            Console.Write("Digite o numero do mês: ");
            mes = int.Parse(Console.ReadLine());

            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                Console.WriteLine(" O mês que você escolheu tem 31 dias");
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                Console.WriteLine(" O mês que você escolheu tem 30 dias");
            }
            else { Console.WriteLine( " Você escolheu fevereiro que se for ano bissexto tem 29 dias, caso contrário terá 28!"); }

            //Faça um programa que leia a nota de um aluno e informe se ele está aprovado (nota maior ou igual a 7), em recuperação (nota entre 5 e 7) ou reprovado (nota menor que 5).
            Console.WriteLine("EXERCICIO 03");
            Console.WriteLine("");

            int nota = 0;
            Console.Write("Digite qual foi a sua nota: ");
            nota = int.Parse(Console.ReadLine());

            if (nota >= 7)
            {
                Console.WriteLine("Você está aprovado!");
            }
            else if (nota >= 5)
            {
                Console.WriteLine ("Você está de recuperação nb");
            }
            else { Console.WriteLine("Você está reprovado"); }

            //Calcule a soma de todos os números de 1 a 100 utilizando um laço de repetição.
            Console.WriteLine("EXERCICIO 04");
            Console.WriteLine("");

            int num = 0;

            for (int j= 0; j<=100; j++)
            {
            
               num = j + num;
                Console.WriteLine(num);
            }

            // Implemente uma contagem regressiva de 10 até 0 utilizando um laço de repetição.
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 05");
          
            for (int i =10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            //Faça um programa que leia o nome de um aluno e suas três notas, calcule a média e informe se ele está aprovado (média maior ou igual a 7) ou reprovado
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 06");

            string nome = "";
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            float n2 = 0;
            Console.Write("Digite a primeira nota: ");
            n2 = float.Parse(Console.ReadLine());

            float n3 = 0;
            Console.Write("Digite a primeira nota: ");
            n3 = float.Parse(Console.ReadLine());

            float n4 = 0;
            Console.Write("Digite a primeira nota: ");
            n4 = float.Parse(Console.ReadLine());

            float media = (n2 + n3 + n4) / 3;
            Console.WriteLine("Sua média é : " + media);

            if (media >= 7)
            {
                Console.WriteLine("Você está aprovado!");
            }
            else if (nota <= 6)
            {
                Console.WriteLine("Você está reprovado");
            }

            //Faça um programa que peça ao usuário para digitar um ano e verifique se é bissexto.
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 07");

            int bissexto = 0;
            Console.Write("Digite um ano: ");
            bissexto = int.Parse(Console.ReadLine());

            if (bissexto % 4 == 0 && bissexto % 100 != 0)
            {
                Console.WriteLine("você escolheu um bissexto");
            }

            else { Console.WriteLine("Não é bissexto"); }



        }
    }
}
