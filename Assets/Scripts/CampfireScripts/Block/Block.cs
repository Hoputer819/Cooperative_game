using UnityEngine;

public class Block : MonoBehaviour
{
    protected bool isTrigger;
    protected Collider2D collision;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("RhythmBlock"))
        {
            this.collision = collision;
            isTrigger = true;
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
