int resultado, num1, num2;

Console.WriteLine("Vamos fazer uma tabuada. Digite um numero inicial e um numero final.");

num1 = int.Parse(Console.ReadLine());
num2 = int.Parse(Console.ReadLine());


for (int i = 1; i < num2; i++)
{
    resultado = num1 * i;
    Console.WriteLine(resultado);
}
