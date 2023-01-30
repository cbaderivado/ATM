namespace ATM.Models
{
    public abstract class Operacion
    {
        public int id_operacion { get; set; }
        public Tarjeta tarjeta { get; set; }
        public DateTime fecha { get; set; }
    }
}
