using System.ComponentModel.DataAnnotations;
namespace iMate.API.Data.RequestModels;

public class SettingsRequest
{
    [Required]
    public string Username { get; set; }
    public bool SoundEffects { get; set; } 
    public bool ReducedMotion { get; set; } 
    public bool Motivation { get; set; }
    public bool Practice { get; set; } 
    public bool Scheduling { get; set; } 
    public string? Reminder { get; set; }
}
