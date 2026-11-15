using UnityEngine;
using UnityEngine.Rendering;

public class DownBlock : Block
{
    public void OnDown()
    {
        if (isTrigger)
        {
            Destroy(block.gameObject);
        }
    }
}
