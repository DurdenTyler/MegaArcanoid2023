using UnityEngine;

public class InputController : InputProviderBase
{
    private float _horizontalInput;

    private void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
    }

    public override float GetCurrentInput()
    {
        return _horizontalInput;
    }

}
