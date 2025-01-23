using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class again : MonoBehaviour
{
    public Button againButton;

    void Start()
    {
        Button btn = againButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("startscherm!");
    }
}