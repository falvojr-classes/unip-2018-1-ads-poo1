using System;
					
public class Program {
	public static void Main() {
        Endereco endereco = new Endereco();
        endereco.Cep = 14801788;

        PessoaFisica pf = new PessoaFisica();
		pf.Nome = "Venilton";
		
		Console.WriteLine(pf.Nome);
	}
}

public class PessoaFisica {
    public String Nome { get; set; }
    public String Cpf { get; set; }
    public String DataNascimento { get; set; }
    public String Email { get; set; }
    public String Telefone { get; set; }
    public Endereco Endereco { get; set; }

    public PessoaFisica(String cpf) {
        Cpf = cpf;
    }
	
	public PessoaFisica() { } 
}

public class PessoaJuridica {
    public String RazaoSocial { get; set; }
    public String Cnpj { get; set; }
    public String Email { get; set; }
    public String Telefone { get; set; }
    public Endereco Endereco { get; set; }
}

public class Endereco {
	public int Cep { get; set; }
    public String Logradouro { get; set; }
    public String Complemento { get; set; }
}