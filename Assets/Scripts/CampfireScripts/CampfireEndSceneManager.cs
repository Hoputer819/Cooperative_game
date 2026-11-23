using UnityEngine;
using UnityEngine.SceneManagement;

public class CampfireEndSceneManager : MonoBehaviour
{
    public void OnClickRetry()
    {
        SceneManager.LoadScene("CampfireGameScene");
    }

    public void OnClickRanking()
    {
        SceneManager.LoadScene("RankingScene");
    }

    public void OnClickHome()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void OnClickExit()
    {
        Debug.Log("Exit 버튼 눌림");
        Application.Quit();
    }
}