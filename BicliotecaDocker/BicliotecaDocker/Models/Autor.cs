using System.ComponentModel.DataAnnotations;

namespace BicliotecaDocker.Models
{
    public class Autor
    {
        [Key]
        public int AutorID { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Apellido { get; set; }

        public ICollection<Libro> ?Libros { get; set; }
    }
}
