using System.ComponentModel.DataAnnotations;

namespace TodoListApp.WebApp.Models.RequestModels.TaskControllerModels;

public class ListActionRequestModel
{
    [Required]
    [Range(1, int.MaxValue)]
    public int Page { get; set; }
}
