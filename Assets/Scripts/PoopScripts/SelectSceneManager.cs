using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectSceneManager : MonoBehaviour
{
    public void OnClickPoop()
    {
        SceneManager.LoadScene("PoopGameScene");
    }
}
