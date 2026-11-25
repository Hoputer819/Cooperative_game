using UnityEngine;

public class CampfireContainer : MonoBehaviour
{
    private float timer = 0f;
    private float timeInterval = 2f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > timeInterval)
        {
            if (transform.localScale.x > 0.21f)
            {
                transform.localScale -= new Vector3(0.2f, 0.2f, 0.2f);
            }
            timer = 0;
        }
    }
}
