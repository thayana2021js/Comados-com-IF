using System;

namespace ComandosIf
{
 
   class Program
    {
       static void Main(string[] args) 
       {
        int idade;

           Console.WriteLine("DIGITE A SUA IDADE: ");
           idade = int.Parse(Console.ReadLine());

           if(idade >=21)
           {
            Console.WriteLine("VOCÊ É MAIOR DE  IDADE ");
            
            }
            else{
            Console.WriteLine("VOCÊ É MENOR DE IDADE ");
            }
        }    
    }
    
}


