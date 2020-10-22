using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace App_Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";

            while (opcao != "0")
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Escrever todos os número até ao número escolhido");
                //Console.WriteLine("2 - Criar um array e coloca-lo por ordem crescente");
                Console.WriteLine("0 - Sair\n");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        string num = "0";
                        Console.Write("Indique o número: ");
                        num = Console.ReadLine();

                        int numConvert = 0;

                        if (int.TryParse(num, out numConvert))
                        {
                            if (numConvert > 0)
                            {
                                for (int i = 1; i <= numConvert; i++)
                                {
                                    Console.WriteLine(i + ";");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Valor não aceitavel");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Valor não aceitavel");
                        }

                        break;

                   /* case "2":

                        List<int> array = new List<int>();
                        List<int> finalArray = new List<int>();
                        string opcao2 = "0";
                        int j = 1, opcao2Confirm = 0;

                        if (opcao2 == "0")
                        {
                            for (int i = 0; i < j; i++)
                            {
                                Console.WriteLine("Escrava os números (escreva qualquer caracter para sair)");
                                opcao2 = Console.ReadLine();

                                if (int.TryParse(opcao2, out opcao2Confirm))
                                {
                                    opcao2Confirm = int.Parse(opcao);
                                    array.Add(opcao2Confirm);
                                    opcao2Confirm = 0;
                                    j++;
                                }
                                else
                                {
                                    j = i;
                                }
                            }

                            if (array.Count > 0)
                            {
                                for (int i = 0; i < array.Count; i++)
                                {
                                    if (array > array[i + 1])
                                    {
                                        finalArray[i] = array[i];
                                    }
                                    else
                                    {
                                        finalArray[i] = array[i + 1];
                                    }
                                }
                            }
                        }
                        break;
                   */
                    default:
                        break;
                }
            }
            Environment.Exit(0);
        }
    }
}
