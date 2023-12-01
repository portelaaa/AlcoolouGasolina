double Etanol;
double Gasolina;
double razao;
double percentualIdeal;

double CalcularRazaoPreco()
{
    return Etanol / Gasolina * 100;
}

bool ValeAPenaAbastecerComGasolina()
{
    percentualIdeal = 73; 
    return razao >= percentualIdeal;
}

           
Console.Write("Digite o preço do Etanol: ");
Etanol = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o preço da Gasolina: ");
Gasolina = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

razao = CalcularRazaoPreco();

Console.WriteLine($"Razão entre os preços é {razao:F2}% ");

if (ValeAPenaAbastecerComGasolina())
{
    Console.WriteLine("Abastecer com Gasolina ");
}
else
{
    Console.WriteLine("Abastecer com Etanol ");
}