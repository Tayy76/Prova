using System.ComponentModel.DataAnnotations;
int sla = 0;
string nome;

string[] nomes = { "Taylan", "Agatha", "Mauricio", "Diego", "Calvin" };

Console.WriteLine("Pesquise um nome.");

nome = Console.ReadLine();

for  (int i = 0; i < nomes.Length; i++)
    if (sla == 0)
    {
        {
            if (nome == nomes[i])
            {
                Console.WriteLine($"{nomes[i]} foi encontrado(a).");
                sla = 1;
            }
            else if (nome != nomes[i] && i >= 4)
            { Console.WriteLine("Esse usuário não foi encontrado(a)."); }

        }
    }
