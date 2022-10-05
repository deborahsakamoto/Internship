using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEstoqueOrdenacao
{
    internal class Produtos
    {

        public int n;

        public string[] nome;

        public double[] preco;

        public int[] qtd;

        public void OrdenarPreco()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n-1 ; j++)
                {
                    if (preco[j] > preco[j + 1])
                    {
                        double auxpreco = preco[j + 1];
                        preco[j + 1] = preco[j];
                        preco[j] = auxpreco;

                        string auxnome = nome[j + 1];
                        nome[j + 1] = nome[j];
                        nome[j] = auxnome;

                        int auxqtd = qtd[j + 1];
                        qtd[j + 1] = qtd[j];
                        qtd[j] = auxqtd;

                    }
                }
            }
        }

        public void OrdenarQtd()
        {
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (qtd[j] > qtd[j + 1])
                    {
                        int auxqtd = qtd[j + 1];
                        qtd[j + 1] = qtd[j];
                        qtd[j] = auxqtd;

                        string auxnome = nome[j + 1];
                        nome[j + 1] = nome[j];
                        nome[j] = auxnome;

                        double auxpreco = preco[j + 1];
                        preco[j + 1] = preco[j];
                        preco[j] = auxpreco;

                    }
                }
            }
        }






    }
}


































// Criado por Deborah Sakamoto em 28/09/2022