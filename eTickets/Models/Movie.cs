using eTickets.Data.Base;
using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Display(Name = "Descripción")]
        public string Description { get; set; }

        [Display(Name = "Precio")]
        public double Price { get; set; }

        [Display(Name = "Imagen")]
        public string ImageURL { get; set; }

        [Display(Name = "Fecha de inicio")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Fecha de culminación")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Categoría")]
        public MovieCategory MovieCategory { get; set; }

        // Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

        // Cinema
        public int CinemaId { get; set; }

        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        // Producer
        public int ProducerId { get; set; }

        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}
