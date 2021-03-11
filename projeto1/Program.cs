using System;
                
namespace projeto1
{                   
    class Program
    {                                                               
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma letra");
            var tecla = Console.ReadLine();
            var cachorro = new Cachorro();
            var resultado = cachorro.Piruetar(tecla);
            Console.WriteLine(resultado);

        }
    }        
    public class Cachorro 
    {
        public string Piruetar(string tecla)
        {
            if(tecla.ToLower() == "p")
            {
                return "Piruetando";
            }
            else
            {
                return "Comando Inválido";

              
            }     
        }



    }
}                                                                                                                                                                                                                                