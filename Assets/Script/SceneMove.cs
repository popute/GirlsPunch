using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneMove : MonoBehaviour
{
    public string sceneName;
    public void OnButtonClick()
    {
        ChangeScene();
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
