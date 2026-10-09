using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
    public GameObject trashPrefab;
    private float randomY;
    private float[] yPos = { -1.708984f, -1.45f};
    private float timeInterval = 3f;
    private float timer = 0f;


    void Update()
    {
        timer += Time.deltaTime;   
        
        if(timer >= timeInterval)
        {
            randomY = yPos[Random.Range(0, yPos.Length)];
            Instantiate(trashPrefab, new Vector2(5.5f, randomY), Quaternion.identity);

            timer = 0f;
        }
    }
}
