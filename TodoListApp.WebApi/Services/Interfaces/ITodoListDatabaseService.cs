using System.Collections.ObjectModel;
using TodoListApp.WebApi.Models;

namespace TodoListApp.WebApi.Services.Interfaces;

public interface ITodoListDatabaseService
{
    public ICollection<TodoListModel> GetAll();

    public void Add(TodoListModel model);

    public void Update(TodoListModel model);

    public void Delete(TodoListModel model);
}
