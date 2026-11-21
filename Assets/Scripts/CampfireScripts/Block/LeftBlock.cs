using UnityEngine;

public class LeftBlock : Block
{
    public FanPlayer fanPlayer;

    void Update()
    {
        if (fanPlayer.left && isTrigger)
        {
            Destroy(collision.gameObject);
        }
    }
}
