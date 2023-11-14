using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemPrefab : MonoBehaviour
{
    public Task task;
    public TextMeshProUGUI id; 
    public TextMeshProUGUI title;
    public Toggle toggle;
    public Button btnDel;

    public void SetTask(Task task)
    {
        this.task = task;
        id.text = task.id.ToString();
        title.text = task.title;
        toggle.isOn = task.isDone;

        toggle.onValueChanged.AddListener(delegate
        {
            task.isDone = toggle.isOn;
        });
    }
}
