
using System;

public class Programa
{
    public static void Main(string[] args)
    {
       
        Circulo miCirculo = new Circulo();
       
        miCirculo.Radio = 8.0;

        Console.WriteLine("--- 🔴 INFORMACIÓN DEL CÍRCULO ---");
        Console.WriteLine($"Radio: {miCirculo.Radio}");
        
        
        Console.WriteLine($"Área del Círculo: {miCirculo.CalcularArea():F2}"); 
        Console.WriteLine($"Circunferencia (Perímetro): {miCirculo.CalcularCircunferencia():F2}");

        Console.WriteLine("\n-------------------------------------\n");


      
        Rectangulo miRectangulo = new Rectangulo();
        
       
        miRectangulo.Ancho = 12.0;
        miRectangulo.Alto = 5.0;

        Console.WriteLine("--- 🟪 INFORMACIÓN DEL RECTÁNGULO ---");
        Console.WriteLine($"Ancho: {miRectangulo.Ancho}");
        Console.WriteLine($"Alto: {miRectangulo.Alto}");

       
        Console.WriteLine($"Área del Rectángulo: {miRectangulo.CalcularArea():F2}");
        Console.WriteLine($"Perímetro: {miRectangulo.CalcularPerimetro():F2}");
        
        
        Console.ReadKey();
    }
}