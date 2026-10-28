using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneManager : MonoBehaviour
{
    public void OnClickStart()
    {
        SceneManager.LoadScene("SelectScene");
    }

    public void OnClickExit()
    {
        Debug.Log("Exit 버튼 눌림");
        Application.Quit();
    }
}
