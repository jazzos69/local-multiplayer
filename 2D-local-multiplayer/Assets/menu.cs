using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public Button menuButton ;

    void Start()
    {
        Button btn = menuButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("startscreen");
    }
}