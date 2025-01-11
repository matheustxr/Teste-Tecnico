using System;

namespace TesteTecnico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Calcular valor da variável SOMA");
            Console.WriteLine("2 - Verificar se um número pertence à sequência de Fibonacci");
            Console.WriteLine("3 - Analisar faturamento diário");
            Console.WriteLine("4 - Calcular percentual de faturamento por estado");
            Console.WriteLine("5 - Inverter uma string");
            Console.WriteLine("6 - Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CalcularSoma();
                    break;
                case "2":
                    VerificarFibonacci();
                    break;
                case "3":
                    AnalisarFaturamento();
                    break;
                case "4":
                    CalcularPercentualFaturamento();
                    break;
                case "5":
                    InverterString();
                    break;
                case "6":
                    Console.WriteLine("Encerrando o programa.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        static void CalcularSoma()
        {
            int INDICE = 13, SOMA = 0, K = 0;
            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }
            Console.WriteLine($"O valor final de SOMA é: {SOMA}");
        }

        static void VerificarFibonacci()
        {
            Console.Write("Informe um número para verificar se pertence à sequência de Fibonacci: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                int a = 0, b = 1;
                while (b < numero)
                {
                    int temp = b;
                    b = a + b;
                    a = temp;
                }

                if (b == numero || numero == 0)
                {
                    Console.WriteLine("O número pertence à sequência.");
                }
                else
                {
                    Console.WriteLine("O número não pertence à sequência.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
            }
        }

        static void AnalisarFaturamento()
        {
            double[] faturamento = { 100.0, 200.0, 0.0, 300.0, 500.0, 0.0, 0.0, 600.0 };
            double menor = double.MaxValue;
            double maior = double.MinValue;
            double soma = 0.0;
            int diasComFaturamento = 0;

            foreach (double valor in faturamento)
            {
                if (valor > 0)
                {
                    menor = Math.Min(menor, valor);
                    maior = Math.Max(maior, valor);
                    soma += valor;
                    diasComFaturamento++;
                }
            }

            double media = soma / diasComFaturamento;
            int diasAcimaDaMedia = 0;

            foreach (double valor in faturamento)
            {
                if (valor > media)
                {
                    diasAcimaDaMedia++;
                }
            }

            Console.WriteLine($"Menor faturamento: R${menor:F2}");
            Console.WriteLine($"Maior faturamento: R${maior:F2}");
            Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaDaMedia}");
        }

        static void CalcularPercentualFaturamento()
        {
            var faturamentoPorEstado = new System.Collections.Generic.Dictionary<string, double>
            {
                { "SP", 67836.43 },
                { "RJ", 36678.66 },
                { "MG", 29229.88 },
                { "ES", 27165.48 },
                { "Outros", 19849.53 }
            };

            double total = 0;

            foreach (var valor in faturamentoPorEstado.Values)
            {
                total += valor;
            }

            foreach (var estado in faturamentoPorEstado)
            {
                double percentual = (estado.Value / total) * 100;
                Console.WriteLine($"{estado.Key}: {percentual:F2}%");
            }
        }

        static void InverterString()
        {
            Console.Write("Informe uma string para inverter: ");
            string entrada = Console.ReadLine();
            string invertida = "";

            for (int i = entrada.Length - 1; i >= 0; i--)
            {
                invertida += entrada[i];
            }

            Console.WriteLine($"String invertida: {invertida}");
        }
    }
}
