using UnityEngine;

public class PoopSpawner : MonoBehaviour
{
    public GameObject poopPrefab;
    private float randomX;
    private float timeInterval = 2f;
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= timeInterval)
        {
            randomX = Random.Range(-5.1f, 5.1f);
            Instantiate(poopPrefab, new Vector2(randomX, 3.3f), Quaternion.identity);

            timer = 0f;

            timeInterval = 2f - Mathf.Clamp(Mathf.Log(1 + Time.timeSinceLevelLoad * 0.05f),0.9f,1.5f);
        }
    }
}
