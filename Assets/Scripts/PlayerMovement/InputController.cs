using UnityEngine;

public class InputController : IInputProvider
{
    private float _horizontalInput;

    public void OnUpdate()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
    }

    public float GetCurrentInput()
    {
        return _horizontalInput;
    }

}
