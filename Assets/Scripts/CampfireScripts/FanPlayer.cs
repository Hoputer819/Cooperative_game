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

    void Update()
    {

    }

    public void OnUp(InputValue other)
    {
        up = other.Get<float>() > 0.5f;
    }

    public void OnDown(InputValue other)
    {
        down = other.Get<float>() > 0.5f;
    }

    public void OnLeft(InputValue other)
    {
        left = other.Get<float>() > 0.5f;
    }

    public void OnRight(InputValue other)
    {
        right = other.Get<float>() > 0.5f;
    }
}
