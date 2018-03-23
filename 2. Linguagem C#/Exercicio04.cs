using System;
					
public class Program
{
	public static void Main()
	{
		int a, b, c;
		
		a = 1;
		b = 12;
		c = -13;
		
		double delta = b*b - 4*a*c;
		if(delta < 0) 
		{
			Console.WriteLine("Delta negativo, não é possível calcular sua raiz quadrada.");
		} 
		else 
		{
			double a1 = (-b + Math.Sqrt(delta)) / (2 * a);
			double a2 = (-b - Math.Sqrt(delta)) / (2 * a);
			Console.WriteLine("A1: " + a1);
			Console.WriteLine("A2: " + a2);
		}
	}
}