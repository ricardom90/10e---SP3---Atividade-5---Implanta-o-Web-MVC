namespace LHpet.Model;
public class Fornecedor
{
    public int Id {get; set;}
    public string Nome {get; set;}
    public string CNPJ {get; set;}
    public string Email {get; set;}

    public Fornecedor (int id, string Nome, string CNPJ, string Email)
    {
        this.Id = id;
        this.Nome = Nome;
        this.CNPJ = CNPJ;
        this.Email = Email;
    }
}