using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TodoList : MonoBehaviour
{
    public List<ItemPrefab> tasks = new List<ItemPrefab>();

    public GameObject taskPrefab;
    public GameObject taskContainer;
    public void SetTasks(List<Task> taskList)
    {
        foreach (Task task in taskList)
        {
            Debug.Log("Task: " + task.title);
            GameObject newTaskObject = Instantiate(taskPrefab, taskContainer.transform); // Создаем экземпляр префаба
            ItemPrefab newTask = newTaskObject.GetComponent<ItemPrefab>(); // Получаем компонент ItemPrefab из созданного объекта

            if (newTask != null)
            {
                newTask.SetTask(task); // Устанавливаем информацию о задаче в новый объект ItemPrefab
                tasks.Add(newTask); // Добавляем новую задачу в список задач
            }
        }
    }

    public void UpdateTasks()
    {
        TodoApp todoApp = transform.parent.GetComponent<TodoApp>();
        if (todoApp != null)
        {
            // Теперь у тебя есть доступ к TodoApp и его методам/переменным
            SetTasks(todoApp.tasks);
        }
    }

    public void Start()
    {

    }
}
