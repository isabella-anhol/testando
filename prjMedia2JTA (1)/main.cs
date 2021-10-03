using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMedia2JTA
{
  class Program
  {
    public static void Main(string[] args)
    {

      ConsoleKeyInfo tecla; // armazena tecla pressionada

      while (true)
      {
        Cabecalho(); // chama cabecalho
        Media(); // chama a média
        Console.CursorLeft = 10; // define coluna
        Console.CursorTop = 14; // define linha
        Console.Write("pressione <F> para sair:");
        tecla = Console.ReadKey(); // pausa no programa ---> getch();
        if (tecla.Key == ConsoleKey.F) break;
      }

      Console.Clear(); // limpa a tela
      Console.WriteLine("Obrigado por usar o programa...");
      Console.WriteLine("pressione uma tecla para encerrar...");
      tecla = Console.ReadKey();
    }

    public static void Media()
    {
      double a;
      double b;

      Posicionar(10, 9);
      Console.Write("Digite o primeiro número 1:");
      a = Convert.ToDouble(Console.ReadLine());

      Posicionar(10, 10);
      Console.Write("Digite o primeiro número 2:");
      b = Convert.ToDouble(Console.ReadLine());

      double m = (a + b) / 2; // calculo da média

      Posicionar(10, 12);

      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write("A média de {0:N2} e {1:N2} = {2:N2}", a, b, m);

      double mg = Math.Sqrt(a + b);
      Posicionar(10, 13);
      Console.Write("A média geométrica de {0:N2} e {1:N2} = {2:N2}", a, b, mg);
      Console.ForegroundColor = ConsoleColor.Green;
    }
    public static void Cabecalho()
    {
      Console.BackgroundColor = ConsoleColor.Black;
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Clear(); // limpa a tela
      Posicionar(10, 5);
      Console.WriteLine("#######################");
      Posicionar(10, 6);
      Console.WriteLine("   PROGRAMA DA MÉDIA   ");
      Posicionar(10, 7);
      Console.WriteLine("#######################");
    }
    public static void Posicionar(int C, int L)
    {
      Console.CursorLeft = C; // define coluna
      Console.CursorTop = L; // define linha
    }
  }
}
