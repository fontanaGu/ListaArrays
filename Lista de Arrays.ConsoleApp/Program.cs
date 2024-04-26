namespace Lista_Arrays.ConsoleApp;

internal class Program
{
    private static void Main(string[] args)
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
        var valorRemover = int.Parse(Console.ReadLine());
        valores = RemoverItem(valores, valorRemover);
        MostrarValores(valores);
    }

    private static void MostrarValores(int[] array)
    {
        Console.WriteLine("\nValores da sequência:");
        foreach (var valor in array) Console.Write(valor + " ");
    }

    private static void EncontrarMaiorValor(int[] array)
    {
        var maiorValor = array.Max();
        Console.WriteLine("\nMaior valor da sequência: " + maiorValor);
    }

    private static void EncontrarMenorValor(int[] array)
    {
        var menorValor = array.Min();
        Console.WriteLine("Menor valor da sequência: " + menorValor);
    }

    private static void EncontrarValorMedio(int[] array)
    {
        var valorMedio = array.Average();
        Console.WriteLine("Valor médio da sequência: " + valorMedio);
    }

    private static void EncontrarTresMaioresValores(int[] array)
    {
        var tresMaiores = array.OrderByDescending(x => x).Take(3);
        Console.WriteLine("Os três maiores valores da sequência:");
        foreach (var valor in tresMaiores) Console.Write(valor + " ");
        Console.WriteLine();
    }

    private static void EncontrarValoresNegativos(int[] array)
    {
        var negativos = array.Where(x => x < 0);
        Console.WriteLine("Valores negativos da sequência:");
        foreach (var valor in negativos) Console.Write(valor + " ");
        Console.WriteLine();
    }

    private static int[] RemoverItem(int[] array, int valor)
    {
        var index = Array.IndexOf(array, valor);
        if (index != -1)
        {
            var novoArray = new int[array.Length - 1];
            Array.Copy(array, 0, novoArray, 0, index);
            Array.Copy(array, index + 1, novoArray, index, array.Length - index - 1);
            return novoArray;
        }

        Console.WriteLine("O valor informado não foi encontrado na sequência.");
        return array;
    }
}