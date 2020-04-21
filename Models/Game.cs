using System.ComponentModel.DataAnnotations;

namespace Esportshere.Models
{

    using System.Collections.Generic;
    
    public class Game
    {
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ShortName { get; set; }

        public List<Event> Events { get; set; }
    }

}
