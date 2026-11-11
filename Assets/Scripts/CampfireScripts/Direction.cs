using UnityEngine;
using System.Collections.Generic;

public class Direction : MonoBehaviour
{
    public Queue<GameObject> animalOrder = new Queue<GameObject>();

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Animals") && !animalOrder.Contains(other.gameObject))
        {
            animalOrder.Enqueue(other.gameObject);
        }
    }
}
