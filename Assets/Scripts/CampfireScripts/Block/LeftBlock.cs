using UnityEngine;

public class LeftBlock : Block
{
    public FanPlayer fanPlayer;
    public GameObject obj;

    void Update()
    {
        timer += Time.deltaTime;

        if (fanPlayer.left && isTrigger)
        {
            coolTime = 100;
            if (obj.transform.localScale.x < 1f)
            {
                obj.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
            }
            Destroy(collision.gameObject);
        }

        else if (fanPlayer.left && !isTrigger && timer > coolTime)
        {
            if (obj.transform.localScale.x > 0.21f)
            {
                obj.transform.localScale -= new Vector3(0.2f, 0.2f, 0.2f);
            }
            timer = 0f;
        }

        else if (triggered && !isTrigger)
        {
            if (obj.transform.localScale.x > 0.21f)
            {
                obj.transform.localScale -= new Vector3(0.2f, 0.2f, 0.2f);
            }
            triggered = false;
        }
    }
}
