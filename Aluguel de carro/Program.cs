using Aluguel_de_carro;
using System.Threading.Channels;

Console.WriteLine("-=-=-=-=Aluguel de de carro=-=-=-=-");
Console.WriteLine("Entre com a quantidade de dias que você deseja alugar o carro:");
double dias = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a quilometragem inicial:");
double inicial = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a quilometragem final:");
double final = double.Parse(Console.ReadLine());
Console.WriteLine("o valor do alguel é de {0}", Aluguel.alugar(dias, inicial, final));