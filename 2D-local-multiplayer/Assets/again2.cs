using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public Button againButton;

    void Start()
    {
        Button btn = againButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("gamescreen");
    }
}