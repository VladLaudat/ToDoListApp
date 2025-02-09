using TodoListApp.WebApi.Models;

namespace TodoListApp.WebApi.Services.Interfaces;

public interface ITaskDatabaseService
{
    public IList<TaskModel> Read(int page = 1, int pageSize = 4);

    public TaskModel ReadById(int id);

    public void Add(TaskModel model);

    public void Update(TaskModel model);

    public void Delete(int id);

    public int Count();
}
