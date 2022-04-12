using System;

class Program {
  public static void Main (string[] args) {
       Console.WriteLine("Informe o comprimento: ");
      double height = double.Parse(Console.ReadLine());
    Console.WriteLine("informe a largura: ");
      double weidth = double.Parse(Console.ReadLine());
    double area = height * weidth;
    double price = area * 200;
    Console.WriteLine("A area do terreno é " + area.ToString("F3") + "m²");
    Console.WriteLine("O preço é R$" + price.ToString("F2"));


    
  }
}
