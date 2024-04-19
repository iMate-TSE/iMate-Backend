namespace iMate.API.Data.RequestModels;
using System.ComponentModel.DataAnnotations;

public class MoodSaveRequest
{
    public string token { get; set; }

    public string mood { get; set; }
}