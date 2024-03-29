namespace Lista_Arrays.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1 };

            MostrarValores(valores);
            EncontrarMaiorValor(valores);
            EncontrarMenorValor(valores);
            EncontrarValorMedio(valores);
            EncontrarTresMaioresValores(valores);
            EncontrarValoresNegativos(valores);

            Console.WriteLine("\nRemover um item da sequência:");
            Console.Write("Informe o valor a ser removido: ");
            int valorRemover = int.Parse(Console.ReadLine());
            valores = RemoverItem(valores, valorRemover);
            MostrarValores(valores);
        }

        static void MostrarValores(int[] array)
        {
            Console.WriteLine("\nValores da sequência:");
            foreach (int valor in array)
            {
                Console.Write(valor + " ");
            }
        }

        static void EncontrarMaiorValor(int[] array)
        {
            int maiorValor = array.Max();
            Console.WriteLine("\nMaior valor da sequência: " + maiorValor);
        }

        static void EncontrarMenorValor(int[] array)
        {
            int menorValor = array.Min();
            Console.WriteLine("Menor valor da sequência: " + menorValor);
        }

        static void EncontrarValorMedio(int[] array)
        {
            double valorMedio = array.Average();
            Console.WriteLine("Valor médio da sequência: " + valorMedio);
        }

        static void EncontrarTresMaioresValores(int[] array)
        {
            var tresMaiores = array.OrderByDescending(x => x).Take(3);
            Console.WriteLine("Os três maiores valores da sequência:");
            foreach (int valor in tresMaiores)
            {
                Console.Write(valor + " ");
            }
            Console.WriteLine();
        }

        static void EncontrarValoresNegativos(int[] array)
        {
            var negativos = array.Where(x => x < 0);
            Console.WriteLine("Valores negativos da sequência:");
            foreach (int valor in negativos)
            {
                Console.Write(valor + " ");
            }
            Console.WriteLine();
        }

        static int[] RemoverItem(int[] array, int valor)
        {
            int index = Array.IndexOf(array, valor);
            if (index != -1)
            {
                int[] novoArray = new int[array.Length - 1];
                Array.Copy(array, 0, novoArray, 0, index);
                Array.Copy(array, index + 1, novoArray, index, array.Length - index - 1);
                return novoArray;
            }
            else
            {
                Console.WriteLine("O valor informado não foi encontrado na sequência.");
                return array;
            }
        }
    }
}