using UnityEngine;
using UnityEngine.Rendering;

public class UpBlock : Block
{
    public void OnUp()
    {
        if (isTrigger)
        {
            Destroy(block.gameObject);
        }
    }
}
