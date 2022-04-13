using System;
 
System.Console.WriteLine("Digite o valor do saque:");
 int valor = int.Parse(System.Console.ReadLine());
int [] Notas = new int [7]  {100,50,20,10,5,2,1};
int total = 0;



for (int i =0 ; i< Notas.Length; i++){
    total = valor / Notas[i];
    System.Console.WriteLine($"{total} nota(s) de {Notas[i]},00 real(is)");
    valor %= Notas[i];
}
