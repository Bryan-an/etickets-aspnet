using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class NewMovieVM
    {
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

        //Relationships
        [Display(Name = "Actor(es)")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Cine")]
        public int CinemaId { get; set; }

        [Display(Name = "Productor")]
        public int ProducerId { get; set; }
    }
}