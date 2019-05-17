// GENERATED AUTOMATICALLY FROM 'Assets/New Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;
using UnityEngine.Experimental.Input.Utilities;

public class BaseInput : IInputActionCollection
{
    private InputActionAsset asset;
    public BaseInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""New Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""e9960b22-0d3b-4a1e-a62b-647f27d17425"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""id"": ""6c3fd441-c949-4107-b3dd-944e6e3c8670"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""bindings"": []
                },
                {
                    ""name"": ""WheelTorque"",
                    ""id"": ""9d69b41e-605f-4bb6-9ff3-bff13f9936e1"",
                    ""expectedControlLayout"": ""Axis"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Rotate"",
                    ""id"": ""0ba12a04-9546-4bfa-a937-19c623b87b04"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""bindings"": []
                },
                {
                    ""name"": ""Brake"",
                    ""id"": ""55e1d409-b4dc-4325-ab17-93aeda1014eb"",
                    ""expectedControlLayout"": ""Axis"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""bindings"": []
                },
                {
                    ""name"": ""Turn"",
                    ""id"": ""898d8ebf-b914-41ce-b9b3-428b1f144867"",
                    ""expectedControlLayout"": """",
                    ""continuous"": true,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ed0d32f7-f1c8-4901-accf-300b77b7703b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""82f0fee7-f38a-4a4f-8871-3fca3c0f6822"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WheelTorque"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8ef6075e-79c3-46d0-8bc9-bce209d92635"",
                    ""path"": ""<Keyboard>/#(S)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WheelTorque"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1e954524-6bb2-494d-afa5-86c4d4ec8fcb"",
                    ""path"": ""<Keyboard>/#(W)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WheelTorque"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""6fe2e83f-9ff5-43ee-92a1-83fbb4e735c9"",
                    ""path"": ""<Keyboard>/#(R)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""8b1a4c6d-48b7-4919-a5c8-a594c763dc0f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""1dd60311-01ad-449d-867a-8b64485ad577"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""3ed92441-f411-4535-9e1a-00886cfd61c8"",
                    ""path"": ""<Keyboard>/#(A)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""50a494d4-8cda-4e1c-b673-1f339f5d631d"",
                    ""path"": ""<Keyboard>/#(D)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.GetActionMap("Player");
        m_Player_Click = m_Player.GetAction("Click");
        m_Player_WheelTorque = m_Player.GetAction("WheelTorque");
        m_Player_Rotate = m_Player.GetAction("Rotate");
        m_Player_Brake = m_Player.GetAction("Brake");
        m_Player_Turn = m_Player.GetAction("Turn");
    }
    ~BaseInput()
    {
        UnityEngine.Object.Destroy(asset);
    }
    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }
    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }
    public ReadOnlyArray<InputControlScheme> controlSchemes
    {
        get => asset.controlSchemes;
    }
    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }
    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    public void Enable()
    {
        asset.Enable();
    }
    public void Disable()
    {
        asset.Disable();
    }
    // Player
    private InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private InputAction m_Player_Click;
    private InputAction m_Player_WheelTorque;
    private InputAction m_Player_Rotate;
    private InputAction m_Player_Brake;
    private InputAction m_Player_Turn;
    public struct PlayerActions
    {
        private BaseInput m_Wrapper;
        public PlayerActions(BaseInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Click { get { return m_Wrapper.m_Player_Click; } }
        public InputAction @WheelTorque { get { return m_Wrapper.m_Player_WheelTorque; } }
        public InputAction @Rotate { get { return m_Wrapper.m_Player_Rotate; } }
        public InputAction @Brake { get { return m_Wrapper.m_Player_Brake; } }
        public InputAction @Turn { get { return m_Wrapper.m_Player_Turn; } }
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                Click.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnClick;
                Click.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnClick;
                Click.cancelled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnClick;
                WheelTorque.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWheelTorque;
                WheelTorque.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWheelTorque;
                WheelTorque.cancelled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWheelTorque;
                Rotate.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                Rotate.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                Rotate.cancelled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                Brake.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBrake;
                Brake.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBrake;
                Brake.cancelled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBrake;
                Turn.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurn;
                Turn.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurn;
                Turn.cancelled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurn;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                Click.started += instance.OnClick;
                Click.performed += instance.OnClick;
                Click.cancelled += instance.OnClick;
                WheelTorque.started += instance.OnWheelTorque;
                WheelTorque.performed += instance.OnWheelTorque;
                WheelTorque.cancelled += instance.OnWheelTorque;
                Rotate.started += instance.OnRotate;
                Rotate.performed += instance.OnRotate;
                Rotate.cancelled += instance.OnRotate;
                Brake.started += instance.OnBrake;
                Brake.performed += instance.OnBrake;
                Brake.cancelled += instance.OnBrake;
                Turn.started += instance.OnTurn;
                Turn.performed += instance.OnTurn;
                Turn.cancelled += instance.OnTurn;
            }
        }
    }
    public PlayerActions @Player
    {
        get
        {
            return new PlayerActions(this);
        }
    }
    public interface IPlayerActions
    {
        void OnClick(InputAction.CallbackContext context);
        void OnWheelTorque(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnBrake(InputAction.CallbackContext context);
        void OnTurn(InputAction.CallbackContext context);
    }
}
