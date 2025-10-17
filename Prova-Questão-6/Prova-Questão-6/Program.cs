int pesos, media = 0, nota1 = 0, nota2 = 0, nota3 = 0, peso1 = 1, peso2 = 2, peso3 = 3;

Console.Write("Digite três notas.\n");

nota1 = int.Parse(Console.ReadLine());
nota2 = int.Parse(Console.ReadLine());
nota3 = int.Parse(Console.ReadLine());

pesos = peso1 + peso2 + peso3;

media = (nota1 * peso1) + (nota2 * peso2) + (nota3 * peso3);

media = media / pesos;

if (media >= 7)
{
    Console.Write("Aprovado");
}
else if (5 <= media && media < 7)
{
    Console.Write("Recuperação");
}
else
{
    Console.Write("Reprovado");
}