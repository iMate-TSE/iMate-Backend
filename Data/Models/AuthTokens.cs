namespace iMate.API.Data.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class AuthTokens
{
    [Key, Required]
    public string token { get; set; }
    
    [Required, ForeignKey(nameof(userID))]
    public int userID { get; set; }
}