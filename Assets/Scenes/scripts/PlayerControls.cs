// GENERATED AUTOMATICALLY FROM 'Assets/scripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
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
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""5e4e11a0-74f7-49e6-9594-cb0c3ddabf4b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""b77b91da-c245-4384-95c0-b1c7e2b77663"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Xmouse"",
                    ""type"": ""PassThrough"",
                    ""id"": ""17015256-02fc-486c-bdd8-b07d7a2f9d84"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ymouse"",
                    ""type"": ""PassThrough"",
                    ""id"": ""bd485e7f-8407-4e23-94be-e47092a7b4f7"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""shoot1"",
                    ""type"": ""Button"",
                    ""id"": ""3b0edd8d-18ff-4733-a612-be6ed5f47e36"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
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
                    ""path"": ""<Mouse>/leftButton"",
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
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""shoot1"",
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
        m_Land_shoot1 = m_Land.FindAction("shoot1", throwIfNotFound: true);
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

    // Land
    private readonly InputActionMap m_Land;
    private ILandActions m_LandActionsCallbackInterface;
    private readonly InputAction m_Land_Hmovement;
    private readonly InputAction m_Land_Jump;
    private readonly InputAction m_Land_Shoot;
    private readonly InputAction m_Land_Xmouse;
    private readonly InputAction m_Land_Ymouse;
    private readonly InputAction m_Land_shoot1;
    public struct LandActions
    {
        private @PlayerControls m_Wrapper;
        public LandActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Hmovement => m_Wrapper.m_Land_Hmovement;
        public InputAction @Jump => m_Wrapper.m_Land_Jump;
        public InputAction @Shoot => m_Wrapper.m_Land_Shoot;
        public InputAction @Xmouse => m_Wrapper.m_Land_Xmouse;
        public InputAction @Ymouse => m_Wrapper.m_Land_Ymouse;
        public InputAction @shoot1 => m_Wrapper.m_Land_shoot1;
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
                @shoot1.started -= m_Wrapper.m_LandActionsCallbackInterface.OnShoot1;
                @shoot1.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnShoot1;
                @shoot1.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnShoot1;
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
                @shoot1.started += instance.OnShoot1;
                @shoot1.performed += instance.OnShoot1;
                @shoot1.canceled += instance.OnShoot1;
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
        void OnShoot1(InputAction.CallbackContext context);
    }
}
