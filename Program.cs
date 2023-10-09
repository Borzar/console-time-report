using System;

class Program
{
  private static void Main(string[] args)
  {
    Console.WriteLine("");
    Console.WriteLine("Titulo de estudio: ");
    string titulo = Console.ReadLine();
    Console.WriteLine("");
    Console.WriteLine("Indica el tiempo de estudio\n15 minutos\n20 minutos\n30 minutos\n60 minutos\nElige: ");
    int minutos = Convert.ToInt32(Console.ReadLine());

    DateTime fecha = DateTime.Now;

    File.AppendAllText(@"C:/Users/bzaratel/Desktop/logs.txt", $"Titulo: {titulo}\nMinutos: {minutos}\nFecha: {fecha}\n---------\n");

    switch (minutos)
    {
      case 15:
        Iniciar(900000, titulo, minutos, fecha);
        break;
      case 20:
        Iniciar(1200000, titulo, minutos, fecha);
        break;
      case 30:
        Iniciar(1800000, titulo, minutos, fecha);
        break;
      case 60:
        Iniciar(3600000, titulo, minutos, fecha);
        break;
      default:
        Console.WriteLine("Tiempo no permitido");
        break;
    }

    Console.WriteLine("Tiempo terminado ...");

  }

  static void Iniciar(int tiempoEnMilisegundos, string titulo, int minutos, DateTime fecha)
  {
    Console.Clear();
    Console.WriteLine($"{titulo}\nFecha de Inicio: {fecha}\nFecha de termino: {fecha.AddMinutes(minutos)}\nEn Curso...\n");
    Thread.Sleep(tiempoEnMilisegundos);
  }

}

