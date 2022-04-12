using System;

class Program {
  public static void Main (string[] args) {
    double cir, p, r;
  Console.WriteLine("Qual número do raio ?");
    r = double.Parse(Console.ReadLine());
   p = 3.14159;
   cir = p * Math.Pow(r, 2); 
    Console.WriteLine(cir);
  }
}
