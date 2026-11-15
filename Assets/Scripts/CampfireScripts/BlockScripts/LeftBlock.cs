using UnityEngine;
using UnityEngine.Rendering;

public class LeftBlock : Block
{
    public void OnLeft()
    {
        if (isTrigger)
        {
            Destroy(block.gameObject);
        }
    }
}
