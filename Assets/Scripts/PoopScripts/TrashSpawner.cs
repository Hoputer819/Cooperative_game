using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
    public GameObject trashPrefab;
    private float randomX;
    private float randomY;
    private float[] yPos = { -1.65f, -1f};
    private float[] xPos = { 5.5f, -5.5f };
    private float timeInterval = 3f;
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;   
        
        if(timer >= timeInterval)
        {
            randomY = yPos[Random.Range(0, yPos.Length)];
            randomX = xPos[Random.Range(0, xPos.Length)];
            Instantiate(trashPrefab, new Vector2(randomX, randomY), Quaternion.identity);

            timer = 0f;
        }
    }
}
