using System.ComponentModel.DataAnnotations;

namespace iMate.API.Data.RequestModels;

public class ProfileRequest
{
    [Required] 
    public string fullname { get; set; }
    public string token { get; set; }
    public string username { get; set; }
    public int age { get; set;  }
    public string gender { get; set; }
    
    public string avatarPath { get; set; }
}