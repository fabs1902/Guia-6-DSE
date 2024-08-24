using System.ComponentModel.DataAnnotations;

namespace BicliotecaDocker.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaID { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        // Relación uno a muchos con Libros
        public ICollection<Libro> ?Libros { get; set; }
    }
}
