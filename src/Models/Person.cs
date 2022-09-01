namespace src.Models;

public class Person
{
    public Person()
    {
        this.Nome = "Template";
        this.Idade = 0;
    }

    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Cpf { get; set; }
    public bool Ativo { get; set; }
}
