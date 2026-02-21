using System.ComponentModel.DataAnnotations;

namespace Mission06_Harris.Models;

public class MovieForm
{
    [Key]
    public int MovieId { get; set; }

    public int CategoryId { get; set; }
    [Required]
    public string Title { get; set; }

    [Required]
    [Range(1888, 3000, ErrorMessage = "Year must be 1888 or later.")]
    public int Year { get; set; }

    public string? Director { get; set; }

    public string? Rating { get; set; }

    [Required]
    public bool Edited { get; set; }

    [Required]
    public bool CopiedToPlex { get; set; }

    public string? LentTo { get; set; }

    public string? Notes { get; set; }
}