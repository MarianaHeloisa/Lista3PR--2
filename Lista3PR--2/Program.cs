﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3PR__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("======MENU======");
            Console.WriteLine("1 exercicio ");
            Console.WriteLine("2 exercicio 2 ");
            Console.WriteLine("3 exercicio 3 ");
            Console.WriteLine("4 exercicio 4 ");
            Console.WriteLine("5 exercicio 5 ");
            Console.WriteLine("================");

            numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Exercicio 1 executando...");

                    int number;


                    Console.WriteLine("=======MENU======");
                    Console.WriteLine("segunda");
                    Console.WriteLine("terça");
                    Console.WriteLine("quarta");
                    Console.WriteLine("quinta");
                    Console.WriteLine("sexta");
                    Console.WriteLine("sabado");
                    Console.WriteLine("domingo");
                    Console.WriteLine("==================");

                    Console.WriteLine("Escreva um numero de 1 á 7: ");
                    number = int.Parse(Console.ReadLine());

                    switch (number)
                    {
                        case 1:
                            Console.WriteLine("segunda");
                            break;
                        case 2:
                            Console.WriteLine("terça");
                            break;
                        case 3:
                            Console.WriteLine("quarta");
                            break;
                        case 4:
                            Console.WriteLine("quinta");
                            break;
                        case 5:
                            Console.WriteLine("sexta");
                            break;
                        case 6:
                            Console.WriteLine("sabado");
                            break;
                        case 7:
                            Console.WriteLine("domingo");
                            break;

                        default:
                            Console.WriteLine("Opção invalida!");
                            break;
                    }
                    break;

                    switch (numero)

                    {
                        case 2:

                            float n, valor, valdesconto, des;

                            Console.WriteLine("Digite o valor de sua compra: ");
                            valor = float.Parse(Console.ReadLine());

                            Console.WriteLine("======MENU======");
                            Console.WriteLine("1 - á vista no dinheiro ");
                            Console.WriteLine("2 - á vista no pix ");
                            Console.WriteLine("3 - compra no débito ");
                            Console.WriteLine("4 - compra no crédito ");
                            Console.WriteLine("================");

                            Console.WriteLine("Escolha uma forma de pagamento: ");
                            n = float.Parse(Console.ReadLine());

                            switch (numero)
                            {
                                case 1:
                                    des = (15 * valor) / 100;
                                    valdesconto = valor - des;
                                    Console.WriteLine("O valor da sua compra é: " + valdesconto);
                                    break;

                                case 2:
                                    des = (10 * valor) / 100;
                                    valdesconto = valor - des;
                                    Console.WriteLine("O valor da sua compra é: " + valdesconto);
                                    break;

                                case 3:
                                    des = (5 * valor) / 100;
                                    valdesconto = valor + des;
                                    Console.WriteLine("O valor da sua compra é: " + valdesconto);
                                    break;

                                case 4:
                                    des = (10 * valor) / 100;
                                    valdesconto = valor + des;
                                    Console.WriteLine("O valor da sua compra é: " + valdesconto);
                                    break;

                                default:
                                    Console.WriteLine("Opção invalida");
                                    break;
                            }
                            break;

                            switch (numero)

                            {
                                case 3:

                                    int meses;

                                    Console.WriteLine("Digite um numero");
                                    meses = int.Parse(Console.ReadLine());

                                    Console.WriteLine("======MENU======");
                                    Console.WriteLine("mês 1");
                                    Console.WriteLine("mês 2");
                                    Console.WriteLine("mês 3");
                                    Console.WriteLine("mês 4");
                                    Console.WriteLine("mês 5");
                                    Console.WriteLine("mês 6");
                                    Console.WriteLine("mês 7");
                                    Console.WriteLine("mês 8");
                                    Console.WriteLine("mês 9");
                                    Console.WriteLine("mês 10");
                                    Console.WriteLine("mês 11");
                                    Console.WriteLine("mês 12");
                                    Console.WriteLine("=================");

                                    Console.WriteLine("Diga mês e dia");

                                    switch (meses)

                                    {
                                        case 1:
                                            Console.WriteLine("Janeiro tem 31 dias ");
                                            break;

                                        case 2:
                                            Console.WriteLine("Fevereiro tem 28 dias mas se for ano bissexto tem 29 dias ");
                                            break;

                                        case 3:
                                            Console.WriteLine("Março tem 31 dias ");
                                            break;

                                        case 4:
                                            Console.WriteLine("Abril tem 30 dia ");
                                            break;

                                        case 5:
                                            Console.WriteLine("Maio tem 31 dias ");
                                            break;

                                        case 6:
                                            Console.WriteLine("Junho tem 30 dias ");
                                            break;

                                        case 7:
                                            Console.WriteLine("Julho tem 31 dias ");
                                            break;

                                        case 8:
                                            Console.WriteLine("Agosto tem 31 dias ");
                                            break;

                                        case 9:
                                            Console.WriteLine("Setembro tem 30 dias ");
                                            break;

                                        case 10:
                                            Console.WriteLine("Outubro tem 31 dias ");
                                            break;

                                        case 11:
                                            Console.WriteLine("Novembro tem 30 dias ");
                                            break;

                                        case 12:
                                            Console.WriteLine("Dezembro tem 31 dias ");
                                            break;

                                        default:
                                            Console.WriteLine("Opção invalida! ");
                                            break;
                                    }
                                    break;

                                    switch (numero)

                                    {
                                        case 4:

                                            int n1, n2, caracter, resultado;

                                            Console.WriteLine("Digite o primeiro numero: ");
                                            n1 = int.Parse(Console.ReadLine());

                                            Console.WriteLine("Digite o segundo numero: ");
                                            n2 = int.Parse(Console.ReadLine());

                                            Console.WriteLine("======MENU======");
                                            Console.WriteLine("1 - + ");
                                            Console.WriteLine("2 - - ");
                                            Console.WriteLine("3 - * ");
                                            Console.WriteLine("================");

                                            caracter = int.Parse(Console.ReadLine());

                                            switch (caracter)
                                            {
                                                case 1:
                                                    resultado = n1 + n2;
                                                    break;

                                                case 2:
                                                    resultado = n1 - n2;
                                                    break;

                                                case 3:
                                                    resultado = n1 * n2;
                                                    break;

                                                default:

                                                    Console.WriteLine("Opção invalida!");
                                                    break;

                                            }
                                            break;

                                            switch (numero)

                                            {
                                                case 5:

                                                    float N, salario, difsalario, novosalario;

                                                    Console.WriteLine("Digite seu salario: ");
                                                    salario = float.Parse(Console.ReadLine());

                                                    Console.WriteLine("Escolha um codigo: ");


                                                    Console.WriteLine("======MENU======");
                                                    Console.WriteLine("101");
                                                    Console.WriteLine("102");
                                                    Console.WriteLine("103");
                                                    Console.WriteLine("204");
                                                    Console.WriteLine("206");
                                                    Console.WriteLine("301");
                                                    Console.WriteLine("302");
                                                    Console.WriteLine("==================");

                                                    N = float.Parse(Console.ReadLine());

                                                    switch (numero)
                                                    {
                                                        case 101:
                                                            difsalario = (7.5f * salario) / 100;

                                                            novosalario = salario + difsalario;

                                                            Console.WriteLine("Olá Professora, o seu novo salario é: {0}, e o seu salario antigo é: {1} e a diferença é: {2}", novosalario, salario, difsalario);
                                                            break;

                                                        case 102:
                                                            difsalario = (9.7f * salario) / 100;

                                                            novosalario = salario + difsalario;

                                                            Console.WriteLine("Olá Secretária, o seu novo salario é: {0}, e o seu salario antigo é: {1} e a diferença é: {2}", novosalario, salario, difsalario);
                                                            break;

                                                        case 103:
                                                            difsalario = (11.7f * salario) / 100;

                                                            novosalario = salario + difsalario;

                                                            Console.WriteLine("Olá Publicitária, o seu novo salario é: {0}, e o seu salario antigo é: {1} e a diferença é: {2}", novosalario, salario, difsalario);
                                                            break;

                                                        case 204:
                                                            difsalario = (8.9f * salario) / 100;

                                                            novosalario = salario + difsalario;

                                                            Console.WriteLine("Olá Jornalista, o seu novo salario é: {0}, e o seu salario antigo é: {1} e a diferença é: {2}", novosalario, salario, difsalario);
                                                            break;

                                                        case 206:
                                                            difsalario = (13.24f * salario) / 100;

                                                            novosalario = salario + difsalario;

                                                            Console.WriteLine("Olá Mecânica, o seu novo salario é: {0}, e o seu salario antigo é: {1} e a diferença é: {2}", novosalario, salario, difsalario);
                                                            break;

                                                        case 301:
                                                            difsalario = (10.4f * salario) / 100;

                                                            novosalario = salario + difsalario;

                                                            Console.WriteLine("Olá Estagiária, o seu novo salario é: {0}, e o seu salario antigo é: {1} e a diferença é: {2}", novosalario, salario, difsalario);
                                                            break;

                                                        case 302:
                                                            difsalario = (14.6f * salario) / 100;

                                                            novosalario = salario + difsalario;

                                                            Console.WriteLine("Olá Técnica de TI, o seu novo salario é: {0}, e o seu salario antigo é: {1} e a diferença é: {2}", novosalario, salario, difsalario);
                                                            break;

                                                        default:
                                                            Console.WriteLine("Opção invalida! ");
                                                            break;
                                                    }
                                                    break;

                                                default:

                                                    Console.WriteLine("Opção invalida");

                                                    break;











                                            }
                                            Console.ReadKey();
                                    }
                            }
                    }
            }
        }     }    }         

