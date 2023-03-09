using Microsoft.EntityFrameworkCore;
using Ecommerce.Shared;
using Microsoft.Identity.Client;
using System.Collections.Generic;

namespace Ecommerce.Server.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Category> Categorias { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base (options)
        {
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category(1, "Jabon Barra", "JabonBarra"),
                new Category(2, "Jabon Liquido", "JabonLiguido")
                );
            modelBuilder.Entity<Producto>().HasData(

                    new Producto(1, "Jabon en barra Irish Spring", "Irish Spring", "https://desiweb.com.do/DesiWebEcommerce/views/document/product/201/1460/JAB20.jpg", 30,1),
                    new Producto(2, "Jabon en barra Asepxia ", "Asepxia", "https://supermercadosnacional.com/media/catalog/product/cache/fde49a4ea9a339628caa0bc56aea00ff/2/1/2162627-1.jpg", 30,1),
                    new Producto(3, "Jabon en Liquido Irish Spring ", "Irish Spring", "https://almacen.do/wp-content/uploads/2020/06/Jabo%CC%81n-Li%CC%81quido-de-Ducha-Corporal-Irish-Spring-Original-20-oz-Front.jpg", 70, 2)
                );
        }

    }   
}
