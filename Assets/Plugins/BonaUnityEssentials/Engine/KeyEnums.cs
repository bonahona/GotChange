using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class KeyEnums
{
    public static KeyCode ToKeyCode(this KeyboardKeyCode code)
    {
        return (KeyCode)code;
    }

    public static KeyCode ToKeyCode(this GamePad01KeyCode code)
    {
        return (KeyCode)code;
    }
}

public enum KeyboardKeyCode : uint
{
    None = (uint)KeyCode.None,
    Alpha0 = (uint)KeyCode.Alpha0,
    Alpha1 = (uint)KeyCode.Alpha1,
    Alpha2 = (uint)KeyCode.Alpha2,
    Alpha3 = (uint)KeyCode.Alpha3,
    Alpha4 = (uint)KeyCode.Alpha4,
    Alpha5 = (uint)KeyCode.Alpha5,
    Alpha6 = (uint)KeyCode.Alpha6,
    Alpha7 = (uint)KeyCode.Alpha7,
    Alpha8 = (uint)KeyCode.Alpha8,
    Alpha9 = (uint)KeyCode.Alpha9,
    A = (uint)KeyCode.A,
    B = (uint)KeyCode.B,
    C = (uint)KeyCode.C,
    D = (uint)KeyCode.D,
    E = (uint)KeyCode.E,
    F = (uint)KeyCode.F,
    G = (uint)KeyCode.G,
    H = (uint)KeyCode.H,
    I = (uint)KeyCode.I,
    J = (uint)KeyCode.J,
    K = (uint)KeyCode.K,
    L = (uint)KeyCode.L,
    M = (uint)KeyCode.M,
    N = (uint)KeyCode.N,
    O = (uint)KeyCode.O,
    P = (uint)KeyCode.P,
    Q = (uint)KeyCode.Q,
    R = (uint)KeyCode.R,
    S = (uint)KeyCode.S,
    T = (uint)KeyCode.T,
    U = (uint)KeyCode.U,
    V = (uint)KeyCode.V,
    W = (uint)KeyCode.W,
    X = (uint)KeyCode.X,
    Y = (uint)KeyCode.Y,
    Z = (uint)KeyCode.Z,
    Escape = (uint)KeyCode.Escape,
    Enter = (uint)KeyCode.Return,
    Space = (uint)KeyCode.Space,
    Backspace = (uint)KeyCode.Backspace,
    Mouse0 = (uint)KeyCode.Mouse0,
    Mouse1 = (uint)KeyCode.Mouse1,
    Mouse2 = (uint)KeyCode.Mouse2,
    Mouse3 = (uint)KeyCode.Mouse3,
    Mouse4 = (uint)KeyCode.Mouse4,
    Mouse5 = (uint)KeyCode.Mouse5
}

public enum GamePad01KeyCode: uint
{
    Button00 = (uint)KeyCode.Joystick1Button0,
    Button01 = (uint)KeyCode.Joystick1Button1,
    Button02 = (uint)KeyCode.Joystick1Button2,
    Button03 = (uint)KeyCode.Joystick1Button3,
    Button04 = (uint)KeyCode.Joystick1Button4,
    Button05 = (uint)KeyCode.Joystick1Button5,
    Button06 = (uint)KeyCode.Joystick1Button6,
    Button07 = (uint)KeyCode.Joystick1Button7,
    Button08 = (uint)KeyCode.Joystick1Button8,
    Button09 = (uint)KeyCode.Joystick1Button9,
    Button10 = (uint)KeyCode.Joystick1Button10,
    Button11 = (uint)KeyCode.Joystick1Button11,
    Button12 = (uint)KeyCode.Joystick1Button12,
    Button13 = (uint)KeyCode.Joystick1Button13,
    Button14 = (uint)KeyCode.Joystick1Button14,
    Button15 = (uint)KeyCode.Joystick1Button15,
    Button16 = (uint)KeyCode.Joystick1Button16,
    Button17 = (uint)KeyCode.Joystick1Button17,
    Button18 = (uint)KeyCode.Joystick1Button18,
    Button19 = (uint)KeyCode.Joystick1Button19,
}

public enum GamePad02KeyCode : uint
{
    Button00 = (uint)KeyCode.Joystick2Button0,
    Button01 = (uint)KeyCode.Joystick2Button1,
    Button02 = (uint)KeyCode.Joystick2Button2,
    Button03 = (uint)KeyCode.Joystick2Button3,
    Button04 = (uint)KeyCode.Joystick2Button4,
    Button05 = (uint)KeyCode.Joystick2Button5,
    Button06 = (uint)KeyCode.Joystick2Button6,
    Button07 = (uint)KeyCode.Joystick2Button7,
    Button08 = (uint)KeyCode.Joystick2Button8,
    Button09 = (uint)KeyCode.Joystick2Button9,
    Button10 = (uint)KeyCode.Joystick2Button10,
    Button11 = (uint)KeyCode.Joystick2Button11,
    Button12 = (uint)KeyCode.Joystick2Button12,
    Button13 = (uint)KeyCode.Joystick2Button13,
    Button14 = (uint)KeyCode.Joystick2Button14,
    Button15 = (uint)KeyCode.Joystick2Button15,
    Button16 = (uint)KeyCode.Joystick2Button16,
    Button17 = (uint)KeyCode.Joystick2Button17,
    Button18 = (uint)KeyCode.Joystick2Button18,
    Button19 = (uint)KeyCode.Joystick2Button19,
}
