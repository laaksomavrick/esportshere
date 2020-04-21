using System.ComponentModel.DataAnnotations;
using System;

namespace Esportshere.Models
{
    public class Event
    {
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        [Required]
        public int GameId { get; set; }

        [Required]
        public Game Game { get; set; }
    }
}