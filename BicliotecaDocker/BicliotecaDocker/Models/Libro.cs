using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BicliotecaDocker.Models
{
    public class Libro
    {
        [Key]
        public int LibroID { get; set; }

        [Required]
        [StringLength(200)]
        public string Titulo { get; set; }

        [Required]
        public DateTime FechaPublicacion { get; set; }

        // Llave foránea que referencia a Autor
        [ForeignKey("Autor")]
        public int AutorID { get; set; }
        public Autor ?Autor { get; set; }

        // Llave foránea que referencia a Categoria
        [ForeignKey("Categoria")]
        public int CategoriaID { get; set; }
        public Categoria ?Categoria { get; set; }
    }
}
