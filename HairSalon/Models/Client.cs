namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string NameFirst { get; set; }
    public string NameLast { get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}