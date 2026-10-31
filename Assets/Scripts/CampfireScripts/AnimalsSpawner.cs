using UnityEngine;

public class AnimalsSpawner : MonoBehaviour
{
    public GameObject animalsPrefab;
    private float randomX;
    private float randomY;
    private float[] yPos = { 6f, -6f, 6f, 6f, -6f, -6f, 0.5f, 0.5f };//위,아,오위,왼위,오아,왼아,오,왼
    private float[] xPos = { 0f, 0f, 8f, -8f, 9.2f, -9.2f, 10f, -10f };
    private float timeInterval = 4f;
    private float timer = 0f;

    int count = 0;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeInterval)
        {
            count++;
            Debug.Log($"동물 소환됨{count}");
            int randomCount = Random.Range(0, yPos.Length);
            randomY = yPos[randomCount];
            randomX = xPos[randomCount];
            PlayerPrefs.SetInt("RandomCount",randomCount);
            Instantiate(animalsPrefab, new Vector2(randomX, randomY), Quaternion.identity);

            timer = 0f;
        }
    }
}
