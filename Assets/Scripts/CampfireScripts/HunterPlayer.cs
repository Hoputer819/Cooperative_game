using UnityEngine;
using UnityEngine.InputSystem;

public class HunterPlayer : MonoBehaviour
{
    private bool animalInRange;
    public Direction[] directions;
    private int currentDirection;

    public void OnMove1()
    {
        transform.position = new Vector2(0f, 3.2f);
        currentDirection = 0;
    }

    public void OnMove2()
    {
        transform.position = new Vector2(3.9f, 2f);
        currentDirection = 1;
    }

    public void OnMove3()
    {
        transform.position = new Vector2(5.25f, 0.3f);
        currentDirection = 2;
    }

    public void OnMove4()
    {
        transform.position = new Vector2(4.05f, -1.2f);
        currentDirection = 3;
    }

    public void OnMove5()
    {
        transform.position = new Vector2(0f, -2.1f);
        currentDirection = 4;
    }

    public void OnMove6()
    {
        transform.position = new Vector2(-4.05f, -1.2f);
        currentDirection = 5;
    }

    public void OnMove7()
    {
        transform.position = new Vector2(-5.25f, 0.3f);
        currentDirection = 6;
    }

    public void OnMove8()
    {
        transform.position = new Vector2(-3.9f, 2f);
        currentDirection = 7;
    }

    public void OnAttack()
    {
        if (directions[currentDirection].animalOrder.Count > 0)
        {
            Destroy(directions[currentDirection].animalOrder.Dequeue());
        }
    }
}
