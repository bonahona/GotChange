using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new inputdevice", menuName = "Got Change/On Screen Input Device")]
public class OnScreenInputDevice : ScriptableObject, IInputDevice
{
    [Range(0.1f, 1000)]
    public float MaxDistance = 1.0f;

    private Vector2? CurrentPivot = null;

    public InputState GetInput()
    {
        var currentPosition = GetCurrentOnScreenLocation();

        if (currentPosition == null) {
            CurrentPivot = null;
            return new InputState { LeftStick = Vector2.zero };
        }

        if (CurrentPivot == null) {
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
        return Limit((pivot - position) / MaxDistance);
    }
    
    public Vector2 Limit(Vector2 v)
    {
        return new Vector2(Limit(v.x), Limit(v.y));
    }

    public float Limit(float v, float limit = 1.0f)
    {
        if(v > limit) {
            return limit;
        }else if(v < -limit) {
            return -limit;
        } else {
            return v;
        }
    }
}
