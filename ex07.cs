using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Qual seu número do crachá");
   int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Quantas horas trabalhadas: ");
   int b = int.Parse(Console.ReadLine()); 
    Console.WriteLine("Qual valor da hora trabalhado: ");
   double c = double.Parse(Console.ReadLine());
   double cal = b * c; 
    Console.WriteLine("Número do representante " + a);
    Console.WriteLine("Valor de deverá ser pago R$" + cal.ToString("F2"));
    
  }
}
