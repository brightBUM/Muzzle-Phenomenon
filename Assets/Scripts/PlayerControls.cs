//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Land"",
            ""id"": ""373e988a-cfbc-4de6-8a3d-444140dc1411"",
            ""actions"": [
                {
                    ""name"": ""Hmovement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""57a63f01-1fb3-4735-a85f-777265c6b135"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""5e4e11a0-74f7-49e6-9594-cb0c3ddabf4b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""b77b91da-c245-4384-95c0-b1c7e2b77663"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Xmouse"",
                    ""type"": ""PassThrough"",
                    ""id"": ""17015256-02fc-486c-bdd8-b07d7a2f9d84"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Ymouse"",
                    ""type"": ""PassThrough"",
                    ""id"": ""bd485e7f-8407-4e23-94be-e47092a7b4f7"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Kick"",
                    ""type"": ""Button"",
                    ""id"": ""3b0edd8d-18ff-4733-a612-be6ed5f47e36"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Punch"",
                    ""type"": ""Button"",
                    ""id"": ""770767a1-7ac4-4432-9da3-0c78bccf7013"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""9b61f988-9c36-4d9e-8925-5ac64bd67a16"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Charge"",
                    ""type"": ""Button"",
                    ""id"": ""bdb37c76-108c-4c6d-8cf6-8de3f0454a98"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""02bc1c32-5ffb-4ccb-937b-0708b89ae9d0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hmovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e35dac85-b574-4fb2-a91d-91a2625ba727"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hmovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fc8ddbde-c449-4603-8dab-5dbffb2bb996"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hmovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""72543466-3ccc-469d-b5ce-45506f7c8839"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hmovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ecb8f0a2-1900-4a8d-9af1-71c86d5083da"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hmovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""26305cad-e000-43b5-9e2d-a3eb903bdfd1"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b998bd84-b574-48ca-a403-1413018db045"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9efd5ea3-2ee1-4145-9c5d-2ae5410ae038"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Xmouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""77aa8b73-287f-45ab-a7ee-ba9f3b003472"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ymouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8c11d50-bdf1-488d-9ca0-32d3e5de06fd"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Kick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b4a1a225-5f72-4190-b104-fde60e162847"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Punch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""81fae565-3d3d-4c40-82d5-9ee466c77e7f"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""99b34686-0060-465b-bc43-3c7e431cc127"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Charge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Land
        m_Land = asset.FindActionMap("Land", throwIfNotFound: true);
        m_Land_Hmovement = m_Land.FindAction("Hmovement", throwIfNotFound: true);
        m_Land_Jump = m_Land.FindAction("Jump", throwIfNotFound: true);
        m_Land_Shoot = m_Land.FindAction("Shoot", throwIfNotFound: true);
        m_Land_Xmouse = m_Land.FindAction("Xmouse", throwIfNotFound: true);
        m_Land_Ymouse = m_Land.FindAction("Ymouse", throwIfNotFound: true);
        m_Land_Kick = m_Land.FindAction("Kick", throwIfNotFound: true);
        m_Land_Punch = m_Land.FindAction("Punch", throwIfNotFound: true);
        m_Land_Dash = m_Land.FindAction("Dash", throwIfNotFound: true);
        m_Land_Charge = m_Land.FindAction("Charge", throwIfNotFound: true);
    }

    public void Dispose()
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

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Land
    private readonly InputActionMap m_Land;
    private ILandActions m_LandActionsCallbackInterface;
    private readonly InputAction m_Land_Hmovement;
    private readonly InputAction m_Land_Jump;
    private readonly InputAction m_Land_Shoot;
    private readonly InputAction m_Land_Xmouse;
    private readonly InputAction m_Land_Ymouse;
    private readonly InputAction m_Land_Kick;
    private readonly InputAction m_Land_Punch;
    private readonly InputAction m_Land_Dash;
    private readonly InputAction m_Land_Charge;
    public struct LandActions
    {
        private @PlayerControls m_Wrapper;
        public LandActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Hmovement => m_Wrapper.m_Land_Hmovement;
        public InputAction @Jump => m_Wrapper.m_Land_Jump;
        public InputAction @Shoot => m_Wrapper.m_Land_Shoot;
        public InputAction @Xmouse => m_Wrapper.m_Land_Xmouse;
        public InputAction @Ymouse => m_Wrapper.m_Land_Ymouse;
        public InputAction @Kick => m_Wrapper.m_Land_Kick;
        public InputAction @Punch => m_Wrapper.m_Land_Punch;
        public InputAction @Dash => m_Wrapper.m_Land_Dash;
        public InputAction @Charge => m_Wrapper.m_Land_Charge;
        public InputActionMap Get() { return m_Wrapper.m_Land; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LandActions set) { return set.Get(); }
        public void SetCallbacks(ILandActions instance)
        {
            if (m_Wrapper.m_LandActionsCallbackInterface != null)
            {
                @Hmovement.started -= m_Wrapper.m_LandActionsCallbackInterface.OnHmovement;
                @Hmovement.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnHmovement;
                @Hmovement.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnHmovement;
                @Jump.started -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
                @Shoot.started -= m_Wrapper.m_LandActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnShoot;
                @Xmouse.started -= m_Wrapper.m_LandActionsCallbackInterface.OnXmouse;
                @Xmouse.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnXmouse;
                @Xmouse.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnXmouse;
                @Ymouse.started -= m_Wrapper.m_LandActionsCallbackInterface.OnYmouse;
                @Ymouse.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnYmouse;
                @Ymouse.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnYmouse;
                @Kick.started -= m_Wrapper.m_LandActionsCallbackInterface.OnKick;
                @Kick.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnKick;
                @Kick.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnKick;
                @Punch.started -= m_Wrapper.m_LandActionsCallbackInterface.OnPunch;
                @Punch.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnPunch;
                @Punch.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnPunch;
                @Dash.started -= m_Wrapper.m_LandActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnDash;
                @Charge.started -= m_Wrapper.m_LandActionsCallbackInterface.OnCharge;
                @Charge.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnCharge;
                @Charge.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnCharge;
            }
            m_Wrapper.m_LandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Hmovement.started += instance.OnHmovement;
                @Hmovement.performed += instance.OnHmovement;
                @Hmovement.canceled += instance.OnHmovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Xmouse.started += instance.OnXmouse;
                @Xmouse.performed += instance.OnXmouse;
                @Xmouse.canceled += instance.OnXmouse;
                @Ymouse.started += instance.OnYmouse;
                @Ymouse.performed += instance.OnYmouse;
                @Ymouse.canceled += instance.OnYmouse;
                @Kick.started += instance.OnKick;
                @Kick.performed += instance.OnKick;
                @Kick.canceled += instance.OnKick;
                @Punch.started += instance.OnPunch;
                @Punch.performed += instance.OnPunch;
                @Punch.canceled += instance.OnPunch;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @Charge.started += instance.OnCharge;
                @Charge.performed += instance.OnCharge;
                @Charge.canceled += instance.OnCharge;
            }
        }
    }
    public LandActions @Land => new LandActions(this);
    public interface ILandActions
    {
        void OnHmovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnXmouse(InputAction.CallbackContext context);
        void OnYmouse(InputAction.CallbackContext context);
        void OnKick(InputAction.CallbackContext context);
        void OnPunch(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnCharge(InputAction.CallbackContext context);
    }
}
