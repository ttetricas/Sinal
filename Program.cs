int numero;

Console.Write("Digite um número: ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero < 0)
{
    Console.WriteLine ("Este é um número negativo!");
}
else if (numero > 0)
{
    Console.WriteLine ("Este é um número positivo!");
}
else
{
    Console.WriteLine ("Zero");
}