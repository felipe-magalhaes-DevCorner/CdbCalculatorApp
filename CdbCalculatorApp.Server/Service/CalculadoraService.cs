using CdbCalculatorApp.Server.Models;

namespace CdbCalculatorApp.Server.Service
{
    public class CalculadoraService
    {
        private const decimal CDI = 0.009m; // 0,9%
        private const decimal TB = 1.08m;   // 108%
        public CdbCalculationResult CalcularRetorno(decimal valorInicial, int prazoMeses)
        {
            if (valorInicial <= 0)
            {
                throw new ArgumentException("O valor inicial deve ser positivo");
            }
            if (prazoMeses <= 1)
            {
                throw new ArgumentException("O prazo deve ser maior que 0.");
            }
            decimal valorBruto = valorInicial;
            decimal taxaMensal = 1 + (CDI * TB); // 1 + (0,009 * 1,08) = 1,00972

            for (int i = 0; i < prazoMeses; i++)
            {
                valorBruto *= taxaMensal;
            }

            decimal rendimento = valorBruto - valorInicial;

            decimal aliquota = GetAliquota(prazoMeses);

            decimal imposto = rendimento * aliquota;
            decimal valorLiquido = valorBruto - imposto;

            var oRetorno = new CdbCalculationResult
            {
                ValorBruto = Math.Round(valorBruto, 2),
                ValorLiquido = Math.Round(valorLiquido, 2)
            };
            return oRetorno;
        }
        public static decimal GetAliquota(int meses)
        {
            if (meses <= 6) return 0.225m;
            if (meses <= 12) return 0.20m;
            if (meses <= 24) return 0.175m;
            return 0.15m;
        }
    }
}
