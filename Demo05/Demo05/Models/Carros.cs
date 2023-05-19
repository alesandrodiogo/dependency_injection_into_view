namespace Demo05.Models
{
    public class Carros
    {
        public string Nome { get; set; }
        public string Marca { get; set; }

        public List<Carros> ListarCarros()
        {
            var resultado = new  List<Carros>();
            resultado.Add(new Carros {  Nome = "Kia", Marca = "Cerato" });
            resultado.Add(new Carros { Nome = "Hiunday", Marca = "Elantra" });
            resultado.Add(new Carros { Nome = "Suzuki", Marca = "Celero" });

            return resultado;
        }
    }
}
