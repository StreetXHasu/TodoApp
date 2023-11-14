using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TodoApp : MonoBehaviour
{
    public List<Task> tasks = new List<Task>();
    public TodoList todoList;

    // Start is called before the first frame update
    void Start()
    {
        AddTask("Task 1");
        AddTask("Task 2");
        AddTask("Task 3");
        AddTask("Task 4");
        AddTask("Task 5");

        todoList.UpdateTasks();
    }

    public void AddTask(string title)
    {
        Task task = new Task(tasks.Count, title);
        tasks.Add(task);
    }
    public void RemoveTask(int id)
    {
        tasks.RemoveAt(id);
    }
}
