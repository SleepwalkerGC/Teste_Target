using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Exec_3
{
        class Faturamento
        {
            public int dia { get; set; }
            public double valor { get; set; }
        }
    class Exec_3 {
        static void Main(string[] args)
        {
            // Carregar o arquivo JSON
            string caminhoArquivo = "dados.json"; // Substitua pelo caminho correto, se necessário.
            string json = File.ReadAllText(caminhoArquivo);

            // Desserializar os dados do JSON
            List<Faturamento> faturamentoMensal = JsonConvert.DeserializeObject<List<Faturamento>>(json);

            // Filtrar apenas os dias com faturamento > 0
            var faturamentoValido = faturamentoMensal.Where(f => f.valor > 0).ToList();

            // Calcular o menor e maior valor de faturamento
            double menorFaturamento = faturamentoValido.Min(f => f.valor);
            double maiorFaturamento = faturamentoValido.Max(f => f.valor);

            // Calcular a média mensal (considerando apenas dias com faturamento > 0)
            double mediaMensal = faturamentoValido.Average(f => f.valor);

            // Calcular o número de dias com faturamento acima da média mensal
            int diasAcimaDaMedia = faturamentoValido.Count(f => f.valor > mediaMensal);

            // Exibir os resultados
            Console.WriteLine($"Menor valor de faturamento: {menorFaturamento}");
            Console.WriteLine($"Maior valor de faturamento: {maiorFaturamento}");
            Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");
            Console.ReadKey();
        }
    }
}