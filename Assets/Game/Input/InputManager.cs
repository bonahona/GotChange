using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : Manager<InputManager>
{
    [Header("Input devices")]
    public ScriptableObject EditorInputDeviceObject;
    public ScriptableObject MobileInputDeviceObject;
    public ScriptableObject FallbackInputDeviceObject;

    [Header("Input handler")]
    public GameObject InputHandlerObject;

    protected IInputHandler InputHandler;
    protected IInputDevice InputDevice;

    public void SetInputHandler(IInputHandler handler)
    {
        InputHandler = handler;
    }

    public IInputHandler CurrentHandler {
        get { return InputHandler; }
    }

	void Start ()
    {
        InputDevice = GetHandlerForCurrentDevice();
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

    private IInputDevice GetHandlerForCurrentDevice()
    {
        if (Application.isEditor) {
            return EditorInputDeviceObject.GetInterface<IInputDevice>();
        }else if (Application.isMobilePlatform) {
            return MobileInputDeviceObject.GetInterface<IInputDevice>();
        } else {
            return FallbackInputDeviceObject.GetInterface<IInputDevice>();
        }
    }
}
