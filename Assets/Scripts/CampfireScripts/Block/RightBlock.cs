using UnityEngine;

public class RightBlock : Block
{
    public FanPlayer fanPlayer;

    void Update()
    {
        if (fanPlayer.right && isTrigger)
        {
            Destroy(collision.gameObject);
        }
    }
}
