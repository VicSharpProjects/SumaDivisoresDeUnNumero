using System;

namespace CalculaSuma_DivisoresDeUnNumero
{
	class Program
	{
		static void Main(string[] args)
		{
			int multiploAExcluir1 = 0;
			int multiploAExcluir2 = 0;
			int suma = 0;
			int divisor = 1;
			Console.WriteLine("============ Programa que calcula la suma de los divisores de un número excepto de un numero dado ===========");
			Console.WriteLine("Ingrese un numero a contar los divisores seguido de 1 o 2 numeros a excluir");
			Console.Write("Entrada: ");
			string stringValues = Console.ReadLine();
			string[] arrValues = stringValues.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			int[] arrInts = Array.ConvertAll(arrValues, int.Parse);
			if(arrInts.Length == 0)
			{
				Console.WriteLine("Sin datos que validar. Fin del programa");
				Console.ReadKey();
				return;
			}
			if (arrInts.Length >= 2)
			{
				multiploAExcluir1 = arrInts[1];
			}
			if (arrInts.Length == 3)
			{
				multiploAExcluir2 = arrInts[2];
			}
			int numero = arrInts[0];
			while ( divisor <= numero)
			{
				if (arrInts.Length == 3)
				{
					if (numero % divisor == 0 && divisor % multiploAExcluir1 != 0 && divisor % multiploAExcluir2 != 0)
					{
						Console.WriteLine("divisor: {0}", divisor);
						suma += divisor;
					}
				}
				else if (arrInts.Length == 2)
				{
					if ( numero % divisor == 0 && divisor % multiploAExcluir1 != 0 ) 
					{
						Console.WriteLine("divisor: {0}", divisor);
						suma += divisor;
					}
				}
				else
				{
					if (numero % divisor == 0)
					{
						Console.WriteLine("divisor: {0}", divisor);
						suma += divisor;
					}
				}
				divisor++;
			}
			Console.WriteLine("Suma: {0}", suma);
			Console.ReadKey();

		}
	}
}
