// Conversor de moedas

using ConversorMoedas;

bool sair = false;
// Limpa a tela do console
Console.Clear();

while (!sair)
{

	// Cria um menu de controle do programa
	Conversor conversor = new Conversor();

	Console.WriteLine("Bem-vindo ao Conversor de Moedas!");
	Console.WriteLine("Selecione a operação desejada:");
	Console.WriteLine("0. Sair");
	Console.WriteLine("1. Real para Dólar");
	Console.WriteLine("2. Dólar para Real");
	Console.WriteLine("3. Real para Euro");
	Console.WriteLine("4. Euro para Real");

	Console.Write("Opção: ");
	int opcao;
	if (int.TryParse(Console.ReadLine(), out opcao))
	{
		switch (opcao)
		{
			case 0:
				sair = true; // Define sair como true para finalizar o loop
				break;
			// Verifica as conversãoes de moedas
			case 1:
				Console.Write("Digite o valor em Reais: ");
				double valorRealParaDolar = Convert.ToDouble(Console.ReadLine());
				double valorDolar = conversor.ConverterRealParaDolar(valorRealParaDolar);
				Console.WriteLine($"Valor em Dólar: ${valorDolar:F2}");
				break;
			case 2:
				Console.Write("Digite o valor em Dólares: ");
				double valorDolarParaReal = Convert.ToDouble(Console.ReadLine());
				double valorReal = conversor.ConverterDolarParaReal(valorDolarParaReal);
				Console.WriteLine($"Valor em Reais: R${valorReal:F2}");
				break;
			case 3:
				Console.Write("Digite o valor em Reais: ");
				double valorRealParaEuro = Convert.ToDouble(Console.ReadLine());
				double valorEuro = conversor.ConverterRealParaEuro(valorRealParaEuro);
				Console.WriteLine($"Valor em Euro: €{valorEuro:F2}");
				break;
			case 4:
				Console.Write("Digite o valor em Euros: ");
				double valorEuroParaReal = Convert.ToDouble(Console.ReadLine());
				double valorRealDoEuro = conversor.ConverterEuroParaReal(valorEuroParaReal);
				Console.WriteLine($"Valor em Reais: R${valorRealDoEuro:F2}");
				break;
			default:
				Console.WriteLine("Opção inválida. Tente novamente.");
				break;
		}
		// Espera para mostrar o resultado
		Console.WriteLine("Pressione qualquer tecla para continuar...");
		Console.ReadKey(); // Aguarda o usuário pressionar qualquer tecla
		// Limpa a tela do console
		Console.Clear();
	}
	else
	{
		Console.WriteLine("Opção inválida. Tente novamente.");
	}

	// Exibe uma mensagem para o usuário
	// Executa um bloco de código se sair for false
	if (sair == true)
	{
		Console.WriteLine("Pressione qualquer tecla para continuar..."); // Exibe uma mensagem para o usuário
		Console.ReadKey(); // Aguarda o usuário pressionar qualquer tecla
	}
}

