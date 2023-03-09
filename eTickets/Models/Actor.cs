using eTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Foto de Perfil")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Nombre Completo")]
        public string FullName { get; set; }

        [Display(Name = "Biografía")]
        public string Bio { get; set; }

        // Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
