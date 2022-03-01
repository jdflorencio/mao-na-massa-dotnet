using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void ImprimeNaTela(string texto)
        {
            Console.WriteLine(texto);
        }


        static void Encerrar()
        {
            Console.Clear();
            System.Environment.Exit(0);
        }

        static void Menu()
        {
            Console.Clear();
            ImprimeNaTela("O que Deseja fazer?");
            ImprimeNaTela("1 - operações de soma");
            ImprimeNaTela("2 - operações de subtração");
            ImprimeNaTela("3 - operações de Multiplicação");
            ImprimeNaTela("4 - operações de Divisão");
            ImprimeNaTela("5 - Encerrar");

            ImprimeNaTela("");
            Console.Write("Selecione uma opção: ");
            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: Encerrar(); break;
                default: Menu(); break;
            }
        }


        static float ReceberValor()
        {
            try
            {
                Console.Write("Valor: ");
                var valor = Console.ReadLine();
                if (valor == "")
                {
                    Console.WriteLine("O valor nao pode ser vazio");
                    ReceberValor();
                }

                return float.Parse(valor);
            }
            catch (System.Exception)
            {

                Console.WriteLine("erro");
                Menu();
            }
        }
        static void Soma()
        {
            Console.Clear();
            ImprimeNaTela(" **  Somando **");

            var v1 = ReceberValor();
            var v2 = ReceberValor();

            float resultado = v1 + v2;
            Console.Write($"O Resultado da soma é: {resultado}");
            Console.ReadKey();

            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            var v1 = ReceberValor();
            var v2 = ReceberValor();
            float resultado = v1 - v2;
            Console.Write($"O Resultado da subtração é: {resultado}");
            Console.ReadKey();
            Menu();

        }

        static void Divisao()
        {
            Console.Clear();
            var v1 = ReceberValor();
            var v2 = ReceberValor();
            float resultado = (v1 / v2);
            Console.Write($"O Resultado da Divisao é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            var v1 = ReceberValor();
            var v2 = ReceberValor();
            float resultado = (v1 * v2);
            Console.Write($"O Resultado da Multiplicao é: {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}
