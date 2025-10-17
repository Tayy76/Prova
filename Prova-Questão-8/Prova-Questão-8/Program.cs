int a = 1, voto = 1, c1 = 0, c2 = 0, c3 = 0;

if (voto != 0)
{
    while (true && voto > 0)
    {
        Console.WriteLine($"Vamos votar.\n1) candidato 1: {c1} votos\n2) candidato 2: {c2} votos\n3) candidato 3: {c3} votos\n9) voto nulo");

        voto = int.Parse(Console.ReadLine());

        if (voto == 1)
        {
            c1 = c1 + 1;
        }
        else if (voto == 2)
        {
            c2 = c2 + 1;
        }
        else if (voto == 3)
        {
            c3 = c3 + 1;
        }
        else if (voto == 9)
        {

        }

    }


}
