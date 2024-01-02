// Exercício!!
// Um animal contém nome, comprimento, número de patas (padrão 4), cor,
// ambiente e velocidade (em m/s).
// Um peixe é um animal, tem 0 patas, seu ambiente é mar(padrão), cor cinzeta
// (padrão). Além disso tem como características barbatanas e cauda.
// Um mamífero é um animal e seu ambiente padrão é terra.
// Um urso é um mamifero, cor castanho e seu alimento preferido é o mel.

// Crie as classes Animal, Peixe, Mamífero.
// Para a classe Animal, coloque os atributos:
// * Nome, comprimento, patas, cor, ambiente, velocidade
// Para a classe Peixe, codifique o atributo características.
// Para a classe Mamifero, coloque o atributo alimento.

// Por último, crie uma classe teste de forma a ter um jardim zoológico com os
// seguintes animais: camelo, tubarão, urso-do-canadá.

using AnimalPOO;

internal class Program
{
    private static void Main(string[] args)
    {
        Animal camelo = new();
        camelo.Nome = "Camelo";
        camelo.Comprimento = 150;
        camelo.Cor = "Amarelo";
        camelo.Velocidade = 2;

        Peixe tubarao = new();
        tubarao.Nome = "Tubarão";
        tubarao.Comprimento = 300;
        tubarao.Velocidade = 1.5;

        Mamifero urso = new();
        urso.Nome = "Urso-do-Canadá";
        urso.Comprimento = 180;
        urso.Cor = "Vermelho";
        urso.Velocidade = 0.5;

        Animal[] animais = new Animal[3];
        animais[0] = camelo;
        animais[1] = tubarao;
        animais[2] = urso;

        Console.WriteLine("--------------");
        foreach (Animal animal in animais)
        {
            Console.WriteLine(animal.ToString());
            Console.WriteLine("-----------------");
        }

    }
}