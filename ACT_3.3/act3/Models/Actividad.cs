namespace act3.Models
{
    public abstract class Actividad
    {
        public int Periodo {  get; set; }
        public string Descripcion { get; set; }
        protected List<Parcela> lotesAsignados = new List<Parcela>();
        public abstract double CalcularProduccion();
        public abstract double CalcularRendimiento();
        public Actividad(int periodo, string descripcion, Parcela p)
        {
            this.Periodo = periodo;
            this.Descripcion = descripcion;
        }
    }
}
