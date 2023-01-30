namespace ATM.Models
{
    public class Tarjeta
    {
        public int id_tarjeta { get; set; }
        public string numero { get; set; }
        public int pin { get; set; }
        public Usuario usuario{ get; set; }
        public DateTime vencimiento { get; set; }
        public decimal balance { get; set; }
    }
}
