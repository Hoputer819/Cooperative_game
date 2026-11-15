using UnityEngine;
using UnityEngine.Rendering;

public class RightBlock : Block
{
    public void OnUp()
    {
        if (isTrigger)
        {
            Destroy(block.gameObject);
        }
    }
}
