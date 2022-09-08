namespace src.Models;

public class Contract
{
  public Contract()
  {
    this.DataCriacao = DateTime.Now;
    this.Valor = 0;
    this.TokenID = "000000";
    this.Pago = false;
  }

  public Contract(string TokenID, double Valor)
  {
    this.DataCriacao = DateTime.Now;
    this.TokenID = TokenID;
    this.Valor = Valor;
    this.Pago = false;
  }

  public DateTime DataCriacao { get; set; }
  public string TokenID { get; set; }
  public double Valor { get; set; }
  public bool Pago { get; set; }
}
