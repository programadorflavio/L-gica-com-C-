using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Qual é o código do produto: ");
     int c = int.Parse(Console.ReadLine());
    Console.WriteLine ("Quantas unidades do produto: ");
     int u = int.Parse(Console.ReadLine());
    Console.WriteLine ("Qual o preço do produto: ");
     double p = double.Parse(Console.ReadLine());
  Console.WriteLine ("Qual é o código do produto");
    int c2 = int.Parse(Console.ReadLine());
  Console.WriteLine ("Quantas unidades do produto: ");  
    int u2 = int.Parse(Console.ReadLine());
  Console.WriteLine ("Qual o preço do produto: "); 
    double p2 = double.Parse (Console.ReadLine());
    double cal = (u * p) + (u2 * p2);
   Console.WriteLine("O valor total das compras R$" + cal);
    
    
  }
}
