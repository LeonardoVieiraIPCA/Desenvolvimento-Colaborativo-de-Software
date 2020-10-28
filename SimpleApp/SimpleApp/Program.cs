using System;

namespace SimpleApp
{
    class Program
    {
        static void Main()
        {
            do
            {
                CreateMenu();
                int option = ChooseOption();

                switch (option)
                {
                    case 1:
                        DoOption1();
                        break;
                    case 0:
                        DoOption0();
                        break;
                    default:
                        Console.WriteLine("Erro: Opção inválida.\n");
                        break;
                }
            }
            while (true);
        }


        static public void CreateMenu()
        {
            Console.WriteLine("############################################################");
            Console.WriteLine("#   1 - Escrever todos os número até ao número escolhido   #");
            Console.WriteLine("#   0 - Sair                                               #");
            Console.WriteLine("############################################################");
            Console.Write("Escolha uma opção: ");
        }


        static public int ChooseOption()
        {
            return int.Parse(Console.ReadLine());
        }


        static public void DoOption1()
        {
            string num;
            Console.Write("Indique o número: ");
            num = Console.ReadLine();

            int numConverted;

            if (int.TryParse(num, out numConverted))
            {
                if (numConverted > 0)
                {
                    for (int i = 1; i <= numConverted; i++)
                    {
                        Console.WriteLine(i + ";");
                    }
                }
                else
                {
                    Console.WriteLine("Erro: Valor não aceitável.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Erro: Valor não aceitável.");
            }
            Console.WriteLine();
        }


        static public void DoOption0()
        {
            Environment.Exit(0);
        }
    }
}
