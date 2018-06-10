using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new OnScreenDevice", menuName = "Got Change/On screeen Device")]
public class OnScreenInputDevice : MonoBehaviour, IInputDevice
{
    [Range(0.1f, 10f)]
    public float MaxDistance = 1.0f;

    private Vector2? CurrentPivot = null;

    public InputState GetInput()
    {
        var currentPosition = GetCurrentOnScreenLocation();

        if(currentPosition == null) {
            CurrentPivot = null;
            return new InputState { LeftStick = Vector2.zero };
        }
        
        if(CurrentPivot == null) {
            CurrentPivot = currentPosition;
        }

        return new InputState { LeftStick = GetOffsetFromPivot(CurrentPivot.Value, currentPosition.Value, MaxDistance) };
    }

    public Vector2? GetCurrentOnScreenLocation()
    {
        return GetMousePosition();

        // TODO: Implement touch support
    }

    public Vector2? GetMousePosition()
    {
        if (!Input.GetMouseButton(0)) {
            return null;
        } else {
            return new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
    }

    public Vector2 GetOffsetFromPivot(Vector2 pivot, Vector2 position, float maxDistance)
    {
        return Vector2.zero;
    }
}
