using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ProjetoCalcCompleta
{
    internal class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }
        static void Main(string[] args)
        {
            bool escolheuSair = false;

            while (!escolheuSair)
            {
                Console.WriteLine("=================================");
                Console.WriteLine("Seja Bem Vindo A Calculadora do G");
                Console.WriteLine("=================================");
                Console.WriteLine("Selecione o calculo desejado:");
                Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Divisão\n4 - Multiplicação\n5 - Potência\n6 - Raiz\n7 - Sair");
                Console.WriteLine("=================================");
                Console.Write("Opção a ser selecionada:");
                Menu opcaoSelecionada = (Menu)int.Parse(Console.ReadLine());

                switch (opcaoSelecionada)
                {
                    case Menu.Soma:
                        Soma();
                        RetornarMenu();
                        break;

                    case Menu.Subtracao:
                        Subtracao();
                        RetornarMenu();
                        break;

                    case Menu.Divisao:
                        Divisao();
                        RetornarMenu();
                        break;

                    case Menu.Multiplicacao:
                        Multiplicacao();
                        RetornarMenu();
                        break;

                    case Menu.Potencia:
                        Potencia();
                        RetornarMenu();
                        break;

                    case Menu.Raiz:
                        Raiz();
                        RetornarMenu();
                        break;

                    case Menu.Sair:
                        Sair();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção Invalida! \nAperte ENTER para continuar");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }
        static void Soma()
        {
            Console.Clear(); //Limpar o console ao abrir o Menu

            int contagemMenu = 3;
            while (contagemMenu >= 0) // Contagem para exibir o menu 
            {
                Console.WriteLine($"Carregando Menu Soma, Aguarde {contagemMenu} Segundos ... ");
                contagemMenu--;
                Thread.Sleep(850);
                Console.Clear();
            }

            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("          Menu Soma              ");
            Console.WriteLine("=================================\n");
            Console.Write("Digite o primeiro numero: ");
            float num1 = float.Parse(Console.ReadLine()); //Armazenar o primeiro numero digitado

            Console.Write("\nDigite o segundo numero:");
            float num2 = float.Parse(Console.ReadLine()); //Armazenar o segundo numero digitado
            Console.Clear();
            float resultado = num1 + num2; //Formula para calcular o resultado

            Thread.Sleep(250);
            Console.WriteLine("==========================");
            Console.WriteLine($"Conta a ser feita: {num1} + {num2}"); //Exibe a conta selecionada
            Console.WriteLine($"Resultado = {resultado}");            //Exibe o resultado da conta
            Console.WriteLine("==========================");
            Console.WriteLine("Aperte ENTER para continuar");
            Console.ReadLine();
            Console.Clear();
        }

        static void Subtracao()
        {
            Console.Clear();

            int contagemMenu = 3;
            while (contagemMenu >=0) // Contagem para exibir o menu
            {
                Console.WriteLine($"Carregando menu subtração, aguarde {contagemMenu} segundos ...");
                contagemMenu--;
                Thread.Sleep(850);
                Console.Clear();
            }

            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("        Menu Subtração           ");
            Console.WriteLine("=================================\n");
            Console.Write("Digite o primeiro numero:  ");
            float num1 = float.Parse(Console.ReadLine()); // Armazena o primeiro valor

            Console.Write("\nDigite o segundo numero: ");
            float num2 = float.Parse(Console.ReadLine()); // Armazena o segundo valor
            Console.Clear();
            float resultado = num1 - num2; // Formula para realizar o calculo

            Thread.Sleep(250);
            Console.WriteLine("==========================");
            Console.WriteLine($"Conta a ser feita: {num1} - {num2}"); // Exibe a conta a ser calculada
            Console.WriteLine($"Resultado = {resultado}"); // Exibe o resultado do calculo
            Console.WriteLine("==========================");
            Console.WriteLine("Aperte ENTER para continuar");
            Console.ReadLine();
            Console.Clear();
        }

        static void Divisao()
        {
            Console.Clear();
            int contagemMenu = 3;
            while(contagemMenu >=0) // Contagem para abrir o menu
            {
                Console.WriteLine($"Carregando menu divisão, aguarde {contagemMenu} segundos ...");
                contagemMenu--;
                Thread.Sleep(250);
                Console.Clear() ;
            }

            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("        Menu Divisão           ");
            Console.WriteLine("=================================\n");
            Console.Write("Digite o primeiro valor:");
            float num1 = float.Parse(Console.ReadLine()); // Armazena o primeiro valor

            Console.Write("\nDigite o segundo valor: ");
            float num2 = float.Parse(Console.ReadLine()); // Armazena o segundo valor
            float resultado = num1 / num2; // Formula para realizar o calculo
            Console.Clear();

            Thread.Sleep(850);
            Console.WriteLine("===============================");
            Console.WriteLine($"Conta a ser feita: {num1} / {num2} "); // Exibe a conta a ser calculada
            Console.WriteLine($"Resultado = {resultado}"); // Exibe o resultado do calculo.
            Console.WriteLine("===============================");
            Console.WriteLine("Aperte ENTER para continuar");
            Console.ReadLine();
            Console.Clear();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            int contagemMenu = 3;
            while(contagemMenu >=0) // Contagem para exibir o menu
            {
                Console.WriteLine($"Carregando, aguarde {contagemMenu} segundos ...");
                contagemMenu--;
                Thread.Sleep(500);
                Console.Clear();
            }
            Console.WriteLine("===================================");
            Console.WriteLine("         Menu Multiplicação        ");
            Console.WriteLine("===================================\n");
            Console.Write("Digite o primeiro valor: ");
            float num1 = float.Parse(Console.ReadLine()); // Armazena o primeiro valor

            Console.Write("\nDigite o segundo valor: ");
            float num2 = float.Parse(Console.ReadLine()); // Armazena o segundo valor
            float resultado = num1 * num2; // Formula para calcular o resultado
            Console.Clear();

            Thread.Sleep(850);
            Console.WriteLine("=======================================");
            Console.WriteLine($"Conta a ser calculada: {num1} x {num2}"); // Exibe a conta a ser calculada
            Console.WriteLine($"Resultado = {resultado}"); // Exibe o resultado do calculo
            Console.WriteLine("=======================================");
            Console.WriteLine("Aperte ENTER para continuar.");
            Console.ReadLine();
            Console.Clear();
        }

        static void Potencia()
        {
            Console.Clear();
            int contagemMenu = 3;
            while (contagemMenu >= 0) // Contagem para exibir o menu
            {
                Console.WriteLine($"Carregando, aguarde {contagemMenu} segundos ...");
                contagemMenu--;
                Thread.Sleep(500);
                Console.Clear();
            }
            Console.WriteLine("=============================");
            Console.WriteLine("        Menu Potencia        ");
            Console.WriteLine("=============================\n");
            Console.Write("Digite o primeiro valor:");
            float num1 = (float)int.Parse(Console.ReadLine()); // Armazena o primeiro valor

            Console.Write("\nDigite a potência do valor: ");
            float numPotencia = (float)int.Parse(Console.ReadLine()); // Armazena o segundo valor

            double resultado = Math.Pow(num1, numPotencia); // Formula para calcular a potência
            Console.Clear();

            Console.WriteLine("=============================");
            Console.WriteLine($"Conta a ser feita: {num1} ^ {numPotencia}"); // Exibe a conta a ser calculada
            Console.WriteLine($"Resultado = {resultado}"); // Exibe o resultado do calculo
            Console.WriteLine("=============================");
            Console.WriteLine("Aperte ENTER para continuar");
            Console.ReadLine();
            Console.Clear();
        }

        static void Raiz()
        {
            Console.Clear();
            int contagemMenu = 3;
            while(contagemMenu >= 0) // Contagem para exibir o menu
            {
                Console.WriteLine($"Carregando, aguarde {contagemMenu} segundos ..."); 
                contagemMenu--;
                Thread.Sleep(500);
                Console.Clear();
            }

            Console.WriteLine("===========================");
            Console.WriteLine("         Menu Raiz         ");
            Console.WriteLine("===========================\n");
            Console.Write("Digite o numero : ");
            float numRaiz = float.Parse(Console.ReadLine()); // Armazena o valor digitado
            float resultado = (float)Math.Sqrt(numRaiz); // Formula para calcular a potência
            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine($"Valor Digitado: {numRaiz}"); // Exibe a conta a ser calculada
            Console.WriteLine($"Resultado = {resultado}"); // Exibe o resultado do calculo
            Console.WriteLine("=================================");
            Console.WriteLine("Aperte ENTER para continuar");
            Console.ReadLine();
            Console.Clear();
        }

        static void Sair()
        {
            bool opcaoSelecionada = true;
            while (opcaoSelecionada)
            {

                Console.Clear();
                int contagemMenu = 3;
                while (contagemMenu >= 0) // Contagem para exibir o menu
                {
                    Console.WriteLine($"Carregando, aguarde {contagemMenu} segundos ..."); 
                    contagemMenu--;
                    Thread.Sleep(500);
                    Console.Clear();
                }

                Console.WriteLine("=================================");
                Console.WriteLine("Você deseja realmente sair?");
                Console.WriteLine("1 - Sim\n2 - Não");
                Console.WriteLine("=================================");
                Console.Write("Opção a ser selecionada:");
                int escolhaSair = int.Parse(Console.ReadLine()); // Armazena a opção selecionada

                if (escolhaSair == 1) // Caso escolha sair
                {
                    int contagemSair = 3;
                    while (contagemSair >= 0)
                    {
                        Console.WriteLine($"Fechando o progama, aguarde {contagemSair} segundos ...");
                        contagemSair--;
                        Thread.Sleep(500);
                        Console.Clear();
                    }
                    Environment.Exit(0);
                }
                else if (escolhaSair == 2) // Caso deseje ficar
                {
                    int contagemVoltar = 3;
                    while (contagemVoltar >= 0)
                    {
                        Console.WriteLine($"Redirecionando novamente para o menu, aguarde {contagemVoltar} segundos ...");
                        contagemVoltar--;
                        Thread.Sleep(500);
                        Console.Clear();
                        opcaoSelecionada = false;
                    }
                }
                else // Caso digite opção invalida
                {
                    Console.WriteLine("Opção invalida! Aperte ENTER para continuar. ");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
        static void RetornarMenu()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Você deseja voltar ao menu?");
            Console.WriteLine("1 - Sim\n2 - Não");
            Console.WriteLine("=================================");
            Console.Write("Opção a ser selecionada:");
            int escolhaSair = int.Parse(Console.ReadLine()); //Armazena a opção selecionada

            if(escolhaSair == 1) //Caso ele escolha ficar
            {
                int contagemVoltar = 3;
                while (contagemVoltar >= 0)
                {
                    Console.WriteLine($"Carregando menu, aguarde {contagemVoltar} segundos ...");
                    Thread.Sleep(500);
                    contagemVoltar--;

                    Console.Clear();
                }
            } 
            else if (escolhaSair == 2)// Caso ele escolha sair
            {
                Console.Clear();
                int contagemSair = 3;
                while (contagemSair >= 0)
                {
                    Console.WriteLine($"Fechando o progama em {contagemSair} ...");
                    Thread.Sleep(500);
                    contagemSair--;
                    Console.Clear();
                }
                Environment.Exit(0);
            }
            else // Caso digite opção invalida
            {
                Console.Clear();
                Console.WriteLine("Opção invalida!\nAperte ENTER para continuar.");
                Console.ReadKey();
                Console.Clear();
            }
                Console.Clear();
        }
    }
       
}