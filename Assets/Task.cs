using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Task
{

    public int id;
    public string title;
    public bool isDone;
    public float timerInMiliSeconds;

    public Task(int id, string title)
    {
        this.id = id;
        this.title = title;
        this.timerInMiliSeconds = 0;
        this.isDone = false;
    }

     public void toggleDone()
    {
        this.isDone = !this.isDone;
    }


}
