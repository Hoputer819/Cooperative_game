using UnityEngine;
using UnityEngine.InputSystem;

public class FanPlayer : MonoBehaviour
{
    public bool up;
    public bool down;
    public bool left;
    public bool right;

    void Start()
    {
        PlayerInput playerInput = GetComponent<PlayerInput>();
        playerInput.SwitchCurrentControlScheme("Keyboard&Mouse2", Keyboard.current, Mouse.current);
    }

    public void OnUp(InputValue other)
    {
        up = other.isPressed;
    }

    public void OnDown(InputValue other)
    {
        down = other.isPressed;
    }

    public void OnLeft(InputValue other)
    {
        left = other.isPressed;
    }

    public void OnRight(InputValue other)
    {
        right = other.isPressed;
    }
}
