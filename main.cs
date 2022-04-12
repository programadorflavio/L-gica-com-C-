using System;

class Program {
  public static void Main (string[] args) {
    
   Console.WriteLine("Entre com seu nome completo:");
    string fullname = Console.ReadLine();
   Console.WriteLine("Quantos quartos tem na sua casa?");
    int bedroom = int.Parse(Console.ReadLine());
    Console.WriteLine("Entre com o preço do produto");
    double values = double.Parse(Console.ReadLine());
    Console.WriteLine("Entre com seu ultimo completo, idade e altura");
    string[] vet = Console.ReadLine().Split(" ");
    string name = vet[0];
    int age = int.Parse(vet[1]);
    double height = double.Parse(vet[2]);
    Console.WriteLine(fullname);
    Console.WriteLine(bedroom);
    Console.WriteLine(values);
    Console.WriteLine(name);
    Console.WriteLine(age);
    Console.WriteLine(height);
      
      
  }
}