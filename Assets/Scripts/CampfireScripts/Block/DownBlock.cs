using UnityEngine;

public class DownBlock : Block
{
    public FanPlayer fanPlayer;

    void Update()
    {
        if (fanPlayer.down && isTrigger)
        {
            Destroy(collision.gameObject);
        }
    }
}
