using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    string [] vet = Console.ReadLine() .Split(" ");
     double x = double.Parse (vet[0]);
     double y = double.Parse (vet[1]);
     double z = double.Parse (vet[2]);
  if ( x < z && x < y){
      
      Console.WriteLine("O menor número é " + x);        
  }  
    else if( y < z ){
       Console.WriteLine("O menor número é " + y);      
    }
    else{
      Console.WriteLine("O menor número é " + z);
    }
    
  }
}
