namespace SWASIOAPI.Models;

public class Patient
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public int Age { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
