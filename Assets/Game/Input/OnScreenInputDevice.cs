using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "new inputdevice", menuName = "Got Change/On Screen Input Device")]
public class OnScreenInputDevice : ScriptableObject, IInputDevice
{
    [Range(0.1f, 1000)]
    [Tooltip("Pixel count (after DPI scaling is taken into consideration) that is regarded as max input in either the x or the y direciton.")]
    public float MaxDistance = 1.0f;

    public const float BASE_DPI = 96f;
    
    [Range(0.1f, 100f)]
    [Tooltip("Based around a DPI of 96. Why 96? Because that's the DPI of Bona's main Unity screen on his workstation.")]
    public float DpiScalingFactor = 1.0f;

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
        
        var mousePosition = GetMousePosition();
        if (mousePosition.HasValue) {
            return mousePosition;
        }

        var touchPosition = GetTouchPosition();
        if(touchPosition != null) {
            return touchPosition;
        }

        return null;
    }

    public Vector2? GetMousePosition()
    {
        if (!Input.GetMouseButton(0)) {
            return null;
        } else {
            return new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
    }

    public Vector2? GetTouchPosition()
    {
        if(Input.touchCount == 0) {
            return null;
        }

        var touch = Input.touches.First();
        return touch.position;
    }

    public Vector2 GetOffsetFromPivot(Vector2 pivot, Vector2 position, float maxDistance)
    {
        var result = (position - pivot);
        return LimitVectorToUnit(DpiScaleCorrection(result));
    }
    
    public Vector3 DpiScaleCorrection(Vector3 value)
    {
        var dpi = Screen.dpi;
        var dpiScaling = dpi * DpiScalingFactor;

        var result = value / dpiScaling;
        return result;
    }

    public Vector2 LimitVectorToUnit(Vector2 value)
    {
        return new Vector2(Limit(value.x), Limit(value.y));
    }

    public float Limit(float alue, float limit = 1.0f)
    {
        if(alue > limit) {
            return limit;
        }else if(alue < -limit) {
            return -limit;
        } else {
            return alue;
        }
    }
}
