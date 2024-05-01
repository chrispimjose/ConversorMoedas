using ConversorMoedas;

namespace ConversorMoedaTests
{
	public class ConversorMoedaTests
	{
		private Conversor conversor;

		public ConversorMoedaTests()
		{
			conversor = new Conversor();
		}

		[Fact (DisplayName ="Testa conversão real x dolar")]
		public void ConverterRealParaDolar_DeveRetornarValorCorreto()
		{
			// Arrange
			double valorEmReal = 100.0;
			double taxaDolarParaReal = 5.0;
			double valorEsperado = valorEmReal / taxaDolarParaReal;

			// Act
			double valorConvertido = conversor.ConverterRealParaDolar(valorEmReal);

			// Assert
			Assert.Equal(valorEsperado, valorConvertido, 2); // Comparação com precisão de 2 casas decimais
		}

		[Fact(DisplayName = "Testa conversão dolar x real")]
		public void ConverterDolarParaReal_DeveRetornarValorCorreto()
		{
			// Arrange
			double valorEmDolar = 50.0;
			double taxaDolarParaReal = 5.0;
			double valorEsperado = valorEmDolar * taxaDolarParaReal;

			// Act
			double valorConvertido = conversor.ConverterDolarParaReal(valorEmDolar);

			// Assert
			Assert.Equal(valorEsperado, valorConvertido, 2); // Comparação com precisão de 2 casas decimais
		}

		[Fact(DisplayName = "Testa conversão Real x Euro")]
		public void ConverterRealParaEuro_DeveRetornarValorCorreto()
		{
			// Arrange
			double valorEmReal = 200.0;
			double taxaEuroParaReal = 6.0;
			double valorEsperado = valorEmReal / taxaEuroParaReal;

			// Act
			double valorConvertido = conversor.ConverterRealParaEuro(valorEmReal);

			// Assert
			Assert.Equal(valorEsperado, valorConvertido, 2); // Comparação com precisão de 2 casas decimais
		}

		[Fact(DisplayName = "Testa conversão Euro x real")]
		public void ConverterEuroParaReal_DeveRetornarValorCorreto()
		{
			// Arrange
			double valorEmEuro = 50.0;
			double taxaEuroParaReal = 6.0;
			double valorEsperado = valorEmEuro * taxaEuroParaReal;

			// Act
			double valorConvertido = conversor.ConverterEuroParaReal(valorEmEuro);

			// Assert
			Assert.Equal(valorEsperado, valorConvertido, 2); // Comparação com precisão de 2 casas decimais
		}


	}
}