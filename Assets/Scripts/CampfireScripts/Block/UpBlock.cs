using UnityEngine;

public class UpBlock : Block
{
    public FanPlayer fanPlayer;

    void Update()
    {
        if(fanPlayer.up && isTrigger)
        {
            Destroy(collision.gameObject);
        }
    }
}
