using UnityEngine;

public class Block : FanPlayerManager
{
    protected bool isTrigger = false;
    protected Collider2D block; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("RythmBlock"))
        {
            block = other;
            isTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("RythmBlock"))
        {
            isTrigger = false;
        }
    }
}
