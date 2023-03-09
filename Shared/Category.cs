using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Shared
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string Nombre { get; set; }
        public string Url { get; set; }
        public Category() { }
        public Category(int ID,string nombre,string Url)
        {
            this.CategoryID = ID;
            this.Nombre = nombre;
            this.Url = Url;
        }


    }
}
