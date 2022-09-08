namespace src.Models;

public class Contract
{
  public Contract()
  {
    this.DataCriacao = DateTime.Now;
    this.Valor = 0;
    this.TokenID = "000000";
  }
  public DateTime DataCriacao { get; set; }
  public string TokenID { get; set; }
  public double Valor { get; set; }
}
