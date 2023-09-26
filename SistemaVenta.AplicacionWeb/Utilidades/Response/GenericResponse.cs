namespace SistemaVenta.AplicacionWeb.Utilidades.Response
{
    public class GenericResponse<TObject>
    {
        public bool Estado { get; set; }
        public String? Mensaje { get; set; }
        public TObject? Objeto { get; set; }

        public List<TObject>? ListaObjeto { get; set; }

    }
}
