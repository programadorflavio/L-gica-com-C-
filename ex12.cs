using System;

class Program {
public static void Main (string[] args) {
  Console.WriteLine ("Olá eu sou o #ROBOT#, vamos calcular a formula de Bhaskara ?");
string [] vet = Console.ReadLine() .Split(" ");
  double a = double.Parse(vet[0]);
  double b = double.Parse(vet[1]);
  double c = double.Parse(vet[2]);
  double delta = Math.Pow(b , 2) - 4 * a * c;
if (a == 0 || delta < 0.0 ){
  Console.WriteLine("Impossivel calcular");
}
  else{
  double r1 = (-b - Math.Sqrt(delta)) / (2 * a);
  double r2 = (-b + Math.Sqrt(delta)) / (2 * a);

    Console.WriteLine(r1);
    Console.WriteLine(r2);
  }

  
}
}
