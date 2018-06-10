using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new inputdevice", menuName = "Got Change/Keyboard Input Device")]
public class KeyboardInputDevice: ScriptableObject, IInputDevice
{
    public KeyCode Forward = KeyCode.W;
    public KeyCode Backward = KeyCode.S;
    public KeyCode Left = KeyCode.A;
    public KeyCode Right = KeyCode.D;

    public InputState GetInput()
    {
        var leftStick = new Vector2();

        if (Input.GetKey(Forward)) {
            leftStick.y = -1;
        }

        if (Input.GetKey(Backward)) {
            leftStick.y = 1;
        }

        if (Input.GetKey(Left)) {
            leftStick.x = -1;
        }

        if (Input.GetKey(Right)) {
            leftStick.x = 1;
        }

        return new InputState { LeftStick = leftStick };

    }
}
