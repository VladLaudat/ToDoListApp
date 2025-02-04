using System.Collections.ObjectModel;
using TodoListApp.WebApi.Models;

namespace TodoListApp.WebApi.Services.Interfaces;

public interface ITodoListDatabaseService
{
    public IList<TodoListModel> Read(int page = 1, int pageSize = 4);

    public void Add(TodoListModel model);

    public void Update(TodoListModel model);

    public void Delete(TodoListModel model);
}
