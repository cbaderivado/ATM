namespace ATM.Models
{
    public class Usuario
    {
        
        public int id_usuario { get; set; }
        public string razon_social { get; set; }
        public string dni { get; set; }
        public List<Tarjeta> lista_tarjetas { get; set; }
    }
}
