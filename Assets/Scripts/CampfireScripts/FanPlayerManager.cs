using UnityEngine;
using UnityEngine.InputSystem;

public class FanPlayerManager : MonoBehaviour
{
    protected bool up;
    protected bool down;
    protected bool left;
    protected bool right;


    public void OnUp(InputValue value)
    {
        if (value.isPressed)
        {
            up = true;
        }
        else
        {
            up = false;
        }
    }

    public void Ondown(InputValue value)
    {
        if (value.isPressed)
        {
            down = true;
        }
        else
        {
            down = false;
        }
    }

    public void OnLeft(InputValue value)
    {
        if (value.isPressed)
        {
            left = true;
        }
        else
        {
            left = false;
        }
    }

    public void OnRight(InputValue value)
    {
        if (value.isPressed)
        {
            right = true;
        }
        else
        {
            right = false;
        }
    }
}
