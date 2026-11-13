using UnityEngine;

public class RhythmSquare : MonoBehaviour
{
    public GameObject blockPrefab;
    private float randomX;
    private float[] xPos = {-2.68f,-2.23f,-1.78f,-1.33f};
    private float timeInterval = 3f;
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeInterval)
        {
            randomX = xPos[Random.Range(0, xPos.Length)];
            Instantiate(blockPrefab, new Vector2(randomX, 2), Quaternion.identity);

            timer = 0f;
        }
    }
}
