using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RankingManager : MonoBehaviour
{
    public GameObject scorePrefab;
    public Transform content;
    private List<float> timeList = new List<float>();


    void Start()
    {
        int count = PlayerPrefs.GetInt("PoopCount", 0);

        for(int i = 0; i < count; i++)
        {
            timeList.Add(PlayerPrefs.GetFloat("PoopTime" + i));
        
        }
        timeList.Sort();
        timeList.Reverse();

        for(int i = 0; i < count; i++)
        {
            GameObject score = Instantiate(scorePrefab, content);
            TMP_Text scoreText = score.GetComponent<TMP_Text>();
            int seconds = (int)timeList[i] % 60;
            int minuites = (int)timeList[i] / 60;
            scoreText.text = string.Format("{0}. {1:00}:{2:00}", i+1, minuites, seconds);
        }
    }
}
