using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Aula0305
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // >>>>>>>>>>>>>>>>>Lista de Exercícios_ IfElse.<<<<<<<<<<<<<<<<<<<<<


            //1. Faça um Programa que peça dois números e imprima o maior deles.
             ex1();

            //2. Faça um Programa que peça um valor e mostre na tela se o valor é positivo ou negativo.
            // ex2();

            /*3.Faça um Programa que verifique se uma letra digitada é & quot; F & quot; ou & quot; M & quot; ou “O”. Conforme a letra escrever:
                F - Feminino, M - Masculino, O - Outro.*/
            //ex3();

            //4. - Faça um Programa que verifique se uma letra digitada é vogal ou consoante.
            //ex4();


            /* 5. - Faça um programa para a leitura de duas notas parciais de um aluno.
            O programa deve calcular a média alcançada por aluno e apresentar:
            A mensagem &quot; Aprovado & quot;, se a média alcançada for maior ou igual a sete;
            A mensagem &quot; Reprovado & quot;, se a média for menor do que sete;
            A mensagem & quot; Aprovado com Distinção & quot;, se a média for igual*/
            //ex5();


            Console.ReadKey();

        }

        static void ex1()
        {
            Console.WriteLine("Digite o primeiro numero:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 == n2)
            {
                Console.WriteLine("Os numeros sao iguais");
            }
            else
            {
                Console.WriteLine($"O maior numero é: {Math.Max(n1, n2)}");
            }
        }

        static void ex2()
        {
            Console.WriteLine("Digite um valor:");
            int value = int.Parse(Console.ReadLine());


            if (value >0)
            {
                Console.WriteLine("O valor é positivo");
            }
            else
            {
                Console.WriteLine("O valor é negativo");
            }
        }

        static void ex3()
        {
            Console.WriteLine("Digite F para Feminino, M para Masculino ou  O para Outro.:");
            char letter = char.ToLower(Convert.ToChar(Console.ReadLine()));


            if (letter == 'f')
            {
                Console.WriteLine("Feminino");
            }
            else if (letter == 'm')
            {
                Console.WriteLine("Masculino");
            }
            else if (letter == 'o')
            {
                Console.WriteLine("Outro");
            }
            else
            {
                Console.WriteLine("Valor do input não identificado");
            }
        }

        static void ex4()
        {
            Console.WriteLine("Digite uma letra");
            char letra = char.ToLower(Convert.ToChar(Console.ReadLine()));
            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
            {
                Console.WriteLine("Vogal");
            }
            else if (letra >= 'a' && letra <= 'z')
            {
                Console.WriteLine("Consoante");
            }
            else
            {
                Console.WriteLine("Numero");
            }
        }


        static void ex5()
        {
            Console.WriteLine("Nota1: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota2: ");
            double nota2 = double.Parse(Console.ReadLine());
            double media = (nota1 + nota2) / 2;

            if (media == 10)
            {
                Console.WriteLine("Aprovado com distinção");
            }
            else if (media >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }

    }
}