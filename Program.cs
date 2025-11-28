const double TaxaIOFMes = 0.0038;
const double TaxaIOFDia = 0.000082;

decimal totalFatura, valorPagamentoMinimo, valorNaopago;
decimal valorJuros, valorIOFMes, valorIOFDia, valorProximaFatura, custoRotativo;
double PagamentoMinimo, TaxaJuros;

Console.WriteLine("---Crédito Rotativo de Cartão de Credito---\n");

Console.Write("Valor total da fatura (R$)...: ");
totalFatura = Convert.ToDecimal(Console.ReadLine ());

Console.Write("Pagamento mínimo (%)........: ");
PagamentoMinimo = Convert.ToDouble(Console.ReadLine()) / 100;

Console.Write("Taxa de juros mensais (%).....: ");
TaxaJuros = Convert.ToDouble(Console.ReadLine()) / 100;

valorPagamentoMinimo = totalFatura * Convert.ToDecimal(PagamentoMinimo);

valorNaopago = totalFatura - valorPagamentoMinimo;
valorJuros = valorNaopago  * Convert.ToDecimal(TaxaJuros);
valorIOFMes = valorNaopago * Convert.ToDecimal(TaxaIOFMes);
valorIOFDia = valorNaopago * Convert.ToDecimal (TaxaIOFDia * 30);

valorProximaFatura = valorNaopago + valorIOFMes + valorIOFDia;
custoRotativo = valorProximaFatura - valorNaopago;

Console.WriteLine($"\nPagamento mínimo....................: {valorPagamentoMinimo:C}");

Console.WriteLine("\nCaso seja pago o valor mínimo: \n");

Console.WriteLine($"Valor não pago..............:{valorNaopago:C}");
Console.WriteLine($"Juros.......................:{valorJuros:C}");


Console.WriteLine($"\nValor a pagar na próxima fatura...: {valorProximaFatura:C}");
Console.WriteLine($"Custo do crédito rotativo........: {custoRotativo:C}");