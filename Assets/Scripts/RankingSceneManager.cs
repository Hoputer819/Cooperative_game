using UnityEngine;
using UnityEngine.SceneManagement;

public class RankingSceneManager : MonoBehaviour
{
    public void OnClickBack()
    {
        SceneManager.LoadScene("StartScene");
    }
}
