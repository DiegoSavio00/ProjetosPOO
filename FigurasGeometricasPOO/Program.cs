// Exercício!!
// Escreva uma classe FiguraGeometrica com atributos nome e cor. Escreva
// uma classe Figura2D e uma classe Figura3D. Ambas classes Figura2D e Figura3D
// são subclasses da classe FiguraGeometrica. Crie ainda as classes, Circulo,
// Quadrado e Triangulo que estendem a classe Figura2D e crie também as classes
// Cubo e Cilindro e Piramide que estendem a classe Figura3D.

// Escreva a interface DimensãoSuperficial que contém o método CalcularArea.
// Escre a interface DimensaoVolumetrica que contém o método CalcularVolume.
// Aplique a interface DimensaoSuperficial em todas as subclasses de Figura2D
// e Figura3D, implementando seus métodos de acordo com as regras de cada figura
// geométrica(crie os atributos necessários).

// Crie pelo menos uma instância de cada classe e adicione em um array do tipo
// FiguraGeometrica. Itere esses array, imprimindo na tela a area e o volume
// (quando aplicável). Dica: você pode usar o operador InstanceOf.

using FigurasGeometricasPOO;

internal class Program
{
    private static void Main(string[] args)
    {
        Quadrado q1 = new();
        q1.Lado = 2;
        q1.Nome = "Quadrado";

        Circulo c1 = new();
        c1.Raio = 2;
        c1.Nome = "Circulo";

        Triangulo t1 = new();
        t1.Altura = 2;
        t1.Base = 3;
        t1.Nome = "Triangulo";

        Cubo cu1 = new();
        cu1.Lado = 3;
        cu1.Nome = "Cubo";

        Cilindro ci1 = new();
        ci1.Altura = 3;
        ci1.Raio = 2;
        ci1.Nome = "Cilindro";

        Piramide pi1 = new();
        pi1.Altura = 3;
        pi1.Apotema = 4;
        pi1.ArestaBase = 2;
        pi1.NumPoliBase = 4;
        pi1.Base = q1;
        pi1.Nome = "Pirâmide";

        FiguraGeometrica[] figuras = new FiguraGeometrica[6];
        figuras[0] = q1;
        figuras[1] = c1;
        figuras[2] = t1;
        figuras[3] = cu1;
        figuras[4] = ci1;
        figuras[5] = pi1;

        foreach (FiguraGeometrica figura in figuras)
        {
            Console.WriteLine("----------------");
            Console.WriteLine(figura.Nome);

            Figura2D f2d = (Figura2D)figura;
            Console.WriteLine(f2d.CalcularArea());

            Figura3D f3d = (Figura3D)figura;
            Console.WriteLine(f3d.CalcularArea());
            Console.WriteLine(f3d.CalcularVolume());
        }

    }
}