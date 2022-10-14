namespace ApiNewsVBlazor.Models
{
    public class Modelo
    {
        public List<Categoria> Categorias { get; set; }

        public List<Categoria> Paises { get; set; }

        public Modelo()
        {
            Categorias = new List<Categoria> {
                new Categoria{Id = "general", Nombre = "General" },
                new Categoria{Id = "business", Nombre = "Negocios" },
                new Categoria{Id = "entertainment", Nombre = "Entretenimiento" },
                new Categoria{Id = "health", Nombre = "Salud" },
                new Categoria{Id = "science", Nombre = "Ciencia" },
                new Categoria{Id = "sports", Nombre = "Deportes" },
                new Categoria{Id = "technology", Nombre = "Tecnologia" }
            };

            Paises = new List<Categoria> {
                new Categoria{Id = "CU", Nombre = "Cuba" },
                new Categoria{Id = "US", Nombre = "Estados Unidos" },
                new Categoria{Id = "MX", Nombre = "Mexico" },
                new Categoria{Id = "GB", Nombre = "Reino Unido" },
                new Categoria{Id = "AR", Nombre = "Argentina" },
                new Categoria{Id = "BR", Nombre = "Brasil" },
                new Categoria{Id = "FR", Nombre = "Francia" },
                new Categoria{Id = "RU", Nombre = "Rusia" }
            };
        }        
    }
}
