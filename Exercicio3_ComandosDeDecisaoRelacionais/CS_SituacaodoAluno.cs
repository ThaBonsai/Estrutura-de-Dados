using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Simulacao
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite a nota do aluno \n");
		    string nota = Console.ReadLine(); // Reads the entire line entered by the user
        double notareal = double.Parse(nota);
        
        if (notareal <= 5)
        {
        Console.WriteLine("Reprovado \n");
        
        }
        else if(notareal >5 && notareal <= 6) 
        {
        Console.WriteLine("Recuperação \n");
        
        }
        else 
        {
        Console.WriteLine("Aprovado \n");
        }
		}
	}
}