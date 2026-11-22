using UnityEngine;

public class Block : MonoBehaviour
{
    protected bool isTrigger;
    protected bool triggered;
    protected Collider2D collision;
    protected float timer = 0;
    protected float coolTime = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("RhythmBlock"))
        {
            this.collision = collision;
            isTrigger = true;
            triggered = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("RhythmBlock"))
        {
            isTrigger = false;
        }
    }
}
