using System;
					
public class Program
{
	public static void Main()
	{
		double saldo = 1000000.00;
		
		if(saldo < 0) 
		{
			Console.WriteLine("Você está no vermelho");
		} 
		else if (saldo > 999999) 
		{
			Console.WriteLine("Você está bem demais!");
		} 
		else 
		{
			Console.WriteLine("Você está no azul");
		}
	}
}