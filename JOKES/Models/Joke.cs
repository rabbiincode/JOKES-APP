using System.ComponentModel.DataAnnotations;

namespace JOKES.Models;

public class Joke
{
    [Key]
    public int Id { get; set; }
    public string Question { get; set; }
    public string Answer { get; set; }

}