using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TodoListApp.WebApi.Repository.Entities;

namespace TodoListApp.WebApi.Models;

public class TaskModel
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime DueDate { get; set; }

    public StatusEntity? Status { get; set; }

    public TodoListEntity? TodoList { get; set; }

    public IList<TagEntity>? Tags { get; set; }
}
