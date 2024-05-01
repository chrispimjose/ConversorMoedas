using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoedas
{
	public class Conversor
	{
		private const double TaxaDolarParaReal = 5.0; // Exemplo de taxa de conversão USD para BRL
		private const double TaxaEuroParaReal = 6.0; // Exemplo de taxa de conversão EUR para BRL

		public double ConverterRealParaDolar(double valorEmReal)
		{
			return valorEmReal / TaxaDolarParaReal;
		}

		public double ConverterDolarParaReal(double valorEmDolar)
		{
			return valorEmDolar * TaxaDolarParaReal;
		}

		public double ConverterRealParaEuro(double valorEmReal)
		{
			return valorEmReal / TaxaEuroParaReal;
		}

		public double ConverterEuroParaReal(double valorEmEuro)
		{
			return valorEmEuro * TaxaEuroParaReal;
		}

	}
}
