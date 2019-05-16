using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

public class SimpleInputHandler : MonoBehaviour, BaseInput.IPlayerActions
{
    [HideInInspector]
    public static bool isPlayMode = false;

    public BaseInput inputSet;

    //delegates
    public delegate void SimpleInputAction();
    public delegate void AxisInputAction(int value);

    //events
    public static event SimpleInputAction OnClick;
    public static event SimpleInputAction OnRotate;
    public static event AxisInputAction OnWheelTorque;
    public static event AxisInputAction OnBrake;

    void Awake()
    {
        inputSet = new BaseInput();
        inputSet.Player.SetCallbacks(this);
    }

    void Start()
    {
        inputSet.Player.Enable();
    }

    void OnDestroy()
    {
        inputSet.Player.Disable();
    }

    public void StartPlayMode()
    {
        isPlayMode = true;
    }

    void BaseInput.IPlayerActions.OnClick(InputAction.CallbackContext context)
    {
        if (OnClick != null)
        {
            OnClick();
        }
    }

    void BaseInput.IPlayerActions.OnWheelTorque(InputAction.CallbackContext context)
    {
        if (isPlayMode)
        {
            int _value = System.Convert.ToInt16(context.ReadValueAsObject());

            if (OnWheelTorque != null)
            {
                OnWheelTorque(_value);
            }
        }
    }

    void BaseInput.IPlayerActions.OnRotate(InputAction.CallbackContext context)
    {
        if (OnRotate != null)
        {
            OnRotate();
        }
    }

    void BaseInput.IPlayerActions.OnBrake(InputAction.CallbackContext context)
    {
        int _value = System.Convert.ToInt16(context.ReadValueAsObject());

        if (OnBrake != null)
        {
            OnBrake(_value);
        }
    }
}
