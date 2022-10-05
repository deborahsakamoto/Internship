using System.Globalization;

namespace ExercicioEstoqueOrdenacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produtos obj = new Produtos();

            Console.Write("Informe quantos produtos serão cadastrados: ");
            obj.n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            obj.nome = new string[obj.n];
            obj.preco = new double[obj.n];
            obj.qtd = new int[obj.n];

            for (int i = 0; i < obj.n; i++)
            {
                Console.Write("Nome do produto: ");
                obj.nome[i] = Console.ReadLine();
                Console.Write("Preço do produto: ");
                obj.preco[i] = double.Parse((Console.ReadLine()), CultureInfo.InvariantCulture);
                Console.Write("Quantidade do produto: ");
                obj.qtd[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
                        
            int aux2 = 0;

            Console.WriteLine("_________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Para ordenar pelo PREÇO digite [1]");
            Console.WriteLine("Para ordenar pela QUANTIDADE digite [2]");
            Console.WriteLine();
            int aux1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            do
            {
                
                if (aux1 == 1)
                {
                    Console.WriteLine("_________________________________________________________");
                    Console.WriteLine();
                    Console.WriteLine("Você escolheu ordenar pelo PREÇO");
                    Console.WriteLine();
                    Console.WriteLine("Para ordenar por ordem CRESCENTE digite [1]");
                    Console.WriteLine("Para ordenar por ordem DECRESCENTE digite [2]");
                    Console.WriteLine();
                    aux2 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    obj.OrdenarPreco();

                    if (aux2 == 1)
                    {
                        Console.WriteLine("Ordenado por ordem CRESCENTE");
                        Console.WriteLine();
                        for (int i = 0; i < obj.n; i++)
                        {
                            Console.WriteLine("Produto: " + obj.nome[i]);
                            Console.WriteLine("Preço: R$ " + obj.preco[i].ToString("f2", CultureInfo.InvariantCulture));
                            Console.WriteLine("Quantidade: " + obj.qtd[i]);
                            Console.WriteLine();
                        }
                        Console.WriteLine("_________________________________________________________");
                        Console.WriteLine();
                    }
                    else if (aux2 == 2)
                    {
                        Console.WriteLine("Ordenado por ordem DECRESCENTE");
                        Console.WriteLine();
                        for (int i = (obj.n - 1); i >= 0; i--)
                        {
                            Console.WriteLine("Produto: " + obj.nome[i]);
                            Console.WriteLine("Preço: R$ " + obj.preco[i].ToString("f2", CultureInfo.InvariantCulture));
                            Console.WriteLine("Quantidade: " + obj.qtd[i]);
                            Console.WriteLine();
                        }
                        Console.WriteLine("_________________________________________________________");
                        Console.WriteLine();
                    }

                }
                else if (aux1 == 2)
                {
                    Console.WriteLine("_________________________________________________________");
                    Console.WriteLine();
                    Console.WriteLine("Você escolheu ordenar pela QUANTIDADE");
                    Console.WriteLine();
                    Console.WriteLine("Para ordenar por ordem CRESCENTE digite [1]");
                    Console.WriteLine("Para ordenar por ordem DECRESCENTE digite [2]");
                    Console.WriteLine();
                    aux2 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    obj.OrdenarQtd();

                    if (aux2 == 1)
                    {
                        Console.WriteLine("Ordenado por ordem CRESCENTE");
                        Console.WriteLine();
                        for (int i = 0; i < obj.n; i++)
                        {
                            Console.WriteLine("Produto: " + obj.nome[i]);
                            Console.WriteLine("Preço: R$ " + obj.preco[i].ToString("f2", CultureInfo.InvariantCulture));
                            Console.WriteLine("Quantidade: " + obj.qtd[i]);
                            Console.WriteLine();
                        }
                        Console.WriteLine("_________________________________________________________");
                        Console.WriteLine();
                    }
                    else if (aux2 == 2)
                    {
                        Console.WriteLine("Ordenado por ordem DECRESCENTE");
                        Console.WriteLine();
                        for (int i = (obj.n - 1); i >= 0; i--)
                        {
                            Console.WriteLine("Produto: " + obj.nome[i]);
                            Console.WriteLine("Preço: R$ " + obj.preco[i].ToString("f2", CultureInfo.InvariantCulture));
                            Console.WriteLine("Quantidade: " + obj.qtd[i]);
                            Console.WriteLine();
                        }
                        Console.WriteLine("_________________________________________________________");
                        Console.WriteLine();
                    }

                }

                Console.WriteLine("_________________________________________________________");
                Console.WriteLine();
                Console.WriteLine("Para ordenar pelo PREÇO digite [1]");
                Console.WriteLine("Para ordenar pela QUANTIDADE digite [2]");
                Console.WriteLine("Para SAIR digite qualquer outro número");
                Console.WriteLine();
                aux1 = int.Parse(Console.ReadLine());
                Console.WriteLine();

            } while (aux1 == 1 || aux1 == 2);

            Console.WriteLine("Estoque finalizado!");
            Console.WriteLine();
        }
    }
}


































// Criado por Deborah Sakamoto em 28/09/2022