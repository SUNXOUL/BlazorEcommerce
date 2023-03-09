using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Ecommerce.Shared
{
    public class Producto
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string ImgUrl { get; set; }
        public Decimal Precio { get; set; }
        public Category Categoria { get; set; }
        public int CategoriaID { get; set; }

        public Producto()
        {
            Nombre = string.Empty;
            Descripcion = string.Empty;
            ImgUrl = string.Empty;
            Precio = 0;
            this.Categoria = new Category();
            this.CategoriaID = 0;
        }

        public Producto(int id, string nombre, string descripcion, string ImgUrl, decimal precio,int CategoriaID)
        {
            this.ID = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.ImgUrl = ImgUrl;
            this.Precio = precio;
            this.CategoriaID= CategoriaID;
        }

    }
}