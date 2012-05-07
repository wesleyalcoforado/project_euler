using System;

class CollatzProblem
{
	static void Main(string[] args)
	{
		int menorNumero = 1, maiorCadeia = 1;

		for (int inicioCadeia = 1000000; inicioCadeia > 2; inicioCadeia--)
		{
			int tamanhoCadeia = TamanhoCadeia(inicioCadeia);
			if (tamanhoCadeia > maiorCadeia) 
			{
				menorNumero = inicioCadeia;
				maiorCadeia = tamanhoCadeia;
			}
		}

		Console.WriteLine("O menor numero abaixo de 1 milhao que produz a maior cadeia eh: {0}", menorNumero);
	}

	private static int TamanhoCadeia(int numero) 
	{
		int tamanhoCadeia = 1;

		for (ulong i = (ulong)numero; i > 1; i = ProximoNumero(i))
		{
			tamanhoCadeia++;
		}

		return tamanhoCadeia;
	}

	private static ulong ProximoNumero(ulong n)
	{
		if (n % 2 == 0)
			return n / 2;

		return 3 * n + 1;
	}
}
