using eTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Foto de Perfil")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Nombre completo")]
        public string FullName { get; set; }

        [Display(Name = "Biografía")]
        public string Bio { get; set; }

        // Relationships
        public List<Movie> Movies { get; set; }
    }
}
