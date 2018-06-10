using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : Manager<InputManager>
{
    public ScriptableObject InputDeviceObject;
    public GameObject InputHandlerObject;

    protected IInputHandler InputHandler;
    protected IInputDevice InputDevice;

	void Start ()
    {
        InputDevice = InputDeviceObject.GetInterface<IInputDevice>();
        if(InputDevice == null) {
            Debug.LogError("Input Device does not implement IInputDevice");
        }

        InputHandler = InputHandlerObject.GetInterface<IInputHandler>();
        Debug.Log(InputHandler);
    }

	void Update ()
    {
		if(InputDevice == null || InputHandler == null) {
            return;
        }

        InputHandler.TakeInput(InputDevice.GetInput());
	}
}
