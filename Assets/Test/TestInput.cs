using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInput : MonoBehaviour, IInputHandler
{
    public void TakeInput(InputState state)
    {
        transform.Translate(state.LeftStick * Time.deltaTime);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
