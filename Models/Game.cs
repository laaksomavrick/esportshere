using System.ComponentModel.DataAnnotations;

namespace Esportshere.Models
{

public class Game
{
    public long Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string ShortName { get; set; }
}

}
