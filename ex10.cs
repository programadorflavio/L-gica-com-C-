using System;

class Program {
  public static void Main (string[] args) {
   Console.WriteLine("Qual a primeira nota do aluno?");
    double n1 = double.Parse(Console.ReadLine());
   Console.WriteLine("Qual a segunda nota do aluno?");
    double n2 = double.Parse(Console.ReadLine());
    double calculo = (n1 * 3.5 + n2 * 7.5) / 11 ;
    Console.WriteLine("A média ponderada final do aluno é " + calculo);
    
    
  }
}
