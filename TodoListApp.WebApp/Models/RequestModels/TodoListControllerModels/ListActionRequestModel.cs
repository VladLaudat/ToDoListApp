using System.ComponentModel.DataAnnotations;

namespace TodoListApp.WebApp.Models.RequestModels.TodoListControllerModels;

public class ListActionRequestModel
{
    [Required]
    [Range(1, int.MaxValue)]
    public int Page { get; set; }
}
