using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneManager : MonoBehaviour
{
    public void OnClickRetry()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OnClickRanking()
    {
        SceneManager.LoadScene("RankingScene");
    }

    public void OnClickExit()
    {
        Debug.Log("Exit 버튼 눌림");
        Application.Quit();
    }
}
