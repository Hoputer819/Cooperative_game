using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    public TMP_Text timerText;
    public float time = 0f;
    private int seconds;
    private int minuites;
    private bool saved = false;

    void Update()
    {
        if (Time.timeScale == 0f)
        {
            if (!saved)
            {
                PlayerPrefs.SetFloat("FinalTime", time);
                saved = true;
            }
            return;
        }

        time += Time.deltaTime;

        seconds = (int)time % 60;
        minuites = (int)time / 60;

        timerText.text = string.Format("{0:00}:{1:00}",minuites,seconds);
    }
}
