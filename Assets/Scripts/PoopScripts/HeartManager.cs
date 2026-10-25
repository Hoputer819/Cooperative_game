using UnityEngine;

public class HeartManager : MonoBehaviour
{
    public GameObject heartPrefab;
    private GameObject heart1;
    private GameObject heart2;
    private GameObject heart3;
    private SpriteRenderer heart1Color;
    private SpriteRenderer heart2Color;
    private SpriteRenderer heart3Color;

    void Start()
    {
        PlayerPrefs.SetInt("Life", 3);

        heart1 = Instantiate(heartPrefab, new Vector2(-5f, 2.7f), Quaternion.identity);
        heart2 = Instantiate(heartPrefab, new Vector2(-4.7f, 2.7f), Quaternion.identity);
        heart3 = Instantiate(heartPrefab, new Vector2(-4.4f, 2.7f), Quaternion.identity);

        heart1Color = heart1.GetComponent<SpriteRenderer>();
        heart2Color = heart2.GetComponent<SpriteRenderer>();
        heart3Color = heart3.GetComponent<SpriteRenderer>();

    }

    private void Update()
    {
        if(PlayerPrefs.GetInt("Life") == 2)
        {
            heart3Color.color = new Color(0.25f, 0.25f, 0.25f);
        }
        else if (PlayerPrefs.GetInt("Life") == 1)
        {
            heart2Color.color = new Color(0.25f, 0.25f, 0.25f);
        }
        else if (PlayerPrefs.GetInt("Life") == 0)
        {
            heart1Color.color = new Color(0.25f, 0.25f, 0.25f);
        }
    }
}
