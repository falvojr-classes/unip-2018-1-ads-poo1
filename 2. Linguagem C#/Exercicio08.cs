using System;
					
public class Program {
	public static void Main() {
		Agencia araraquara = new Agencia();
        araraquara.numero = 1;

        Conta conta = new Conta();
        conta.agencia = araraquara;
        conta.numero = 12345;
        conta.saldo = 100.50;
        conta.limite = 500;

        Cliente venilton = new Cliente();
        venilton.nome = "Venilton";
        venilton.cpf = "123.123.123-12";
        venilton.endereco = "Rua Salvador Bruno";
        venilton.conta = conta;

        venilton.Sacar(10.50);
		venilton.Depositar(60);
        venilton.ImprimirExtrato();
		
		CartaoCredito cartao = new CartaoCredito();
		cartao.cliente = venilton;
		cartao.numero = "1234 1234 1234 1234";
		cartao.Sacar(150);
		
        venilton.ImprimirExtrato();
	}
}

public class Agencia {
	public int numero;
}

public class Conta {
	public int numero;
	public double saldo;
	public double limite;
	public Agencia agencia;
	
	public void Sacar(double valor) {
		saldo -= valor;
	}
	
	public void Depositar(double valor) {
		saldo += valor;
	}
	
	public void ImprimirExtrato() {
		Console.WriteLine("Seu saldo é " + saldo);
	}
}

public class Cliente {
	public String nome;
	public String cpf;
	public String endereco;
	public Conta conta;

    public void Sacar(double valor) {
		conta.Sacar(valor);
	}
	
	public void Depositar(double valor) {
		conta.Depositar(valor);
	}
	
	public void ImprimirExtrato() {
		conta.ImprimirExtrato();
	}
}

public class CartaoCredito {
	public String numero;
	public Cliente cliente;
	
	public void Sacar(double valor) {
		cliente.conta.Sacar(valor);
	}
}