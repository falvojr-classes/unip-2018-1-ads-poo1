using System;
					
public class Program {
	public static void Main() {
		Agencia minhaAgencia = new Agencia();
        minhaAgencia.Numero = 123;

		Console.WriteLine(minhaAgencia.Numero);
		
        Conta conta = new Conta();
        conta.Agencia = minhaAgencia;
        conta.Numero = 12345;
        conta.Saldo = 100.50;
        conta.Limite = 500;
		
		conta.Sacar(4.5);
		
		Console.WriteLine(conta.Saldo);
	}
}

public class Agencia {
	public int Numero { get; set; }
}

public class Conta {
	public int Numero { get; set; }
	public double Saldo { get; set; }
	public double Limite { get; set; } 
	public Agencia Agencia { get; set; }
	
	public void Sacar(double valor) {
		Saldo -= valor;
		DescontarTaxa(1.00);
	}
	
	public void Depositar(double valor) {
		Saldo += valor;
		DescontarTaxa(0.20);
	}
	
	public void ImprimirExtrato() {
		Console.WriteLine("Seu saldo é " + Saldo);
	}
	
	private void DescontarTaxa(double taxa) {
		Saldo -= taxa;
	}
}