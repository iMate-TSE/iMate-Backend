namespace iMate.API.Data.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class AuthTokens
{
    [Key, Required]
    public string token { get; set; }
    
    [Required, ForeignKey(nameof(userID))]
    public int userID { get; set; }

    public AuthTokens() { }

    public AuthTokens(int _userID, string _token)
    {
        this.userID = _userID;
        this.token = _token;
    }

}