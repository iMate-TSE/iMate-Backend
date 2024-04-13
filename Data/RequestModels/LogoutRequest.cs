using System.ComponentModel.DataAnnotations;

namespace iMate.API.Data.RequestModels;

public class LogoutRequest
{
    [Required]
    public string Token { get; set; }
}