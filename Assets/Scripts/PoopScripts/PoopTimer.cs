using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public TMP_Text timerText;
    private float time = 0f;
    private int seconds;
    private int minuites;
    int count;

    void Start()
    {
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (Time.timeScale == 0f)
        {
            count = PlayerPrefs.GetInt("PoopCount", 0);
            PlayerPrefs.SetFloat("PoopTime"+count, time);
            PlayerPrefs.SetInt("PoopCount", count + 1);
            PlayerPrefs.Save();

            SceneManager.LoadScene("PoopEndScene");
        }

        time += Time.deltaTime;

        seconds = (int)time % 60;
        minuites = (int)time / 60;

        timerText.text = string.Format("{0:00}:{1:00}",minuites,seconds);
    }
}
