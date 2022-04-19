using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Bem vindo a calculadora de notas");
    Console.WriteLine ("Informe a suas notas: ");
 double nota1 = double.Parse(Console.ReadLine());
 double nota2 = double.Parse(Console.ReadLine());
    double soma = nota1 + nota2;
    Console.WriteLine ("Sua nota final é: " + soma);
      if (soma < 60.0){
        Console.Write("Reprovado");
        
      }
  }
}
