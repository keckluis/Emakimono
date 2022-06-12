//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Input/Controls.inputactions
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

public partial class @Controls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""PlayerControls"",
            ""id"": ""e5b18e61-d01e-41cc-8b6e-c495b064f506"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9cf6a36a-7a71-4b78-b369-3d119e657c12"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""StoneTrowing"",
                    ""type"": ""Value"",
                    ""id"": ""0ae94f44-98a5-4ce1-a1eb-9c6f84f45974"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ActivateThrowMode"",
                    ""type"": ""Button"",
                    ""id"": ""511975c4-cb35-434a-be95-0f9c49ef63c6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASDKeys"",
                    ""id"": ""2c5f9b81-70ea-4d23-a39f-2bc9e5997f38"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""592677dc-4ca0-4e5e-bfb3-237c69ab0064"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""3a975b92-aa60-4672-bbd9-e8c9d8906034"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""a71a2efe-4a20-4f3c-9f1d-58d8cc278be4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8946127e-6aea-4c42-9d55-f727e12675cf"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""077f520c-f2f9-4323-9401-5c5d49cca4bd"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""DPad"",
                    ""id"": ""e22da76b-04f9-450b-97f9-5c98929107d2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bd89fc5f-d242-4beb-a5cc-b06d46093334"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""94d5b1e5-20f9-4e5f-9406-33f87c62c7f7"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ad71ceee-80c5-4e1f-8c71-5be43b4d10de"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""StoneTrowing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""ba8707a1-0d80-449e-b3c6-97d0dbefd006"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StoneTrowing"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""8645dd84-905e-441c-96d3-7b0178df2a14"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""StoneTrowing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""4ddcb93f-bb88-49d3-9d9c-d1bae69cbcf7"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""StoneTrowing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""7acc0721-a680-42b6-9a1d-ba0191dc3a0e"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StoneTrowing"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""cc09a2b8-79b9-4d95-b318-6010153e784f"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Gamepad"",
                    ""action"": ""StoneTrowing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""fb8653a5-3943-40fa-a250-9901fe7d8b2d"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Gamepad"",
                    ""action"": ""StoneTrowing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9b61c6c7-258d-4e80-a0fd-cf228204f15a"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Gamepad"",
                    ""action"": ""ActivateThrowMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Level 7"",
            ""id"": ""66cf8bc6-7a09-4af7-8d8e-687936976d85"",
            ""actions"": [
                {
                    ""name"": ""Strike"",
                    ""type"": ""Button"",
                    ""id"": ""b47e6349-1fe2-4118-a75a-6d48bd0202bc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""4172b513-7c85-441e-a264-a7523f588054"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Block"",
                    ""type"": ""Button"",
                    ""id"": ""4d635347-1904-4fbc-b8e3-6391f7cc48e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f4c5bcdc-9b93-47bd-938b-87ffac3afaf8"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Strike"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d5e8ba03-5e5e-4437-81d4-4ab25e1a15c5"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Strike"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""5edbde26-cc31-4657-8c47-fd80d6dbf4dc"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d7a5bd2c-e6c3-4462-875c-ba6a029be4e5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1e07aaa3-fac5-4d3b-ba7a-87e97a977ffd"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""7f5e06ad-44fc-4403-b054-7953bf16fdbd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""368bcffe-6c53-46a8-91d2-44a0fa322650"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c204cb36-ef64-413f-9655-7772bd5076c3"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""58fb5c62-f6f2-45be-860e-0506996541b5"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9176bbf6-9974-429b-8929-6d61d68386eb"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Xbox Gamepad"",
            ""bindingGroup"": ""Xbox Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerControls
        m_PlayerControls = asset.FindActionMap("PlayerControls", throwIfNotFound: true);
        m_PlayerControls_Movement = m_PlayerControls.FindAction("Movement", throwIfNotFound: true);
        m_PlayerControls_StoneTrowing = m_PlayerControls.FindAction("StoneTrowing", throwIfNotFound: true);
        m_PlayerControls_ActivateThrowMode = m_PlayerControls.FindAction("ActivateThrowMode", throwIfNotFound: true);
        // Level 7
        m_Level7 = asset.FindActionMap("Level 7", throwIfNotFound: true);
        m_Level7_Strike = m_Level7.FindAction("Strike", throwIfNotFound: true);
        m_Level7_Walk = m_Level7.FindAction("Walk", throwIfNotFound: true);
        m_Level7_Block = m_Level7.FindAction("Block", throwIfNotFound: true);
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

    // PlayerControls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_Movement;
    private readonly InputAction m_PlayerControls_StoneTrowing;
    private readonly InputAction m_PlayerControls_ActivateThrowMode;
    public struct PlayerControlsActions
    {
        private @Controls m_Wrapper;
        public PlayerControlsActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerControls_Movement;
        public InputAction @StoneTrowing => m_Wrapper.m_PlayerControls_StoneTrowing;
        public InputAction @ActivateThrowMode => m_Wrapper.m_PlayerControls_ActivateThrowMode;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                @StoneTrowing.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnStoneTrowing;
                @StoneTrowing.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnStoneTrowing;
                @StoneTrowing.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnStoneTrowing;
                @ActivateThrowMode.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnActivateThrowMode;
                @ActivateThrowMode.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnActivateThrowMode;
                @ActivateThrowMode.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnActivateThrowMode;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @StoneTrowing.started += instance.OnStoneTrowing;
                @StoneTrowing.performed += instance.OnStoneTrowing;
                @StoneTrowing.canceled += instance.OnStoneTrowing;
                @ActivateThrowMode.started += instance.OnActivateThrowMode;
                @ActivateThrowMode.performed += instance.OnActivateThrowMode;
                @ActivateThrowMode.canceled += instance.OnActivateThrowMode;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);

    // Level 7
    private readonly InputActionMap m_Level7;
    private ILevel7Actions m_Level7ActionsCallbackInterface;
    private readonly InputAction m_Level7_Strike;
    private readonly InputAction m_Level7_Walk;
    private readonly InputAction m_Level7_Block;
    public struct Level7Actions
    {
        private @Controls m_Wrapper;
        public Level7Actions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Strike => m_Wrapper.m_Level7_Strike;
        public InputAction @Walk => m_Wrapper.m_Level7_Walk;
        public InputAction @Block => m_Wrapper.m_Level7_Block;
        public InputActionMap Get() { return m_Wrapper.m_Level7; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Level7Actions set) { return set.Get(); }
        public void SetCallbacks(ILevel7Actions instance)
        {
            if (m_Wrapper.m_Level7ActionsCallbackInterface != null)
            {
                @Strike.started -= m_Wrapper.m_Level7ActionsCallbackInterface.OnStrike;
                @Strike.performed -= m_Wrapper.m_Level7ActionsCallbackInterface.OnStrike;
                @Strike.canceled -= m_Wrapper.m_Level7ActionsCallbackInterface.OnStrike;
                @Walk.started -= m_Wrapper.m_Level7ActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_Level7ActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_Level7ActionsCallbackInterface.OnWalk;
                @Block.started -= m_Wrapper.m_Level7ActionsCallbackInterface.OnBlock;
                @Block.performed -= m_Wrapper.m_Level7ActionsCallbackInterface.OnBlock;
                @Block.canceled -= m_Wrapper.m_Level7ActionsCallbackInterface.OnBlock;
            }
            m_Wrapper.m_Level7ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Strike.started += instance.OnStrike;
                @Strike.performed += instance.OnStrike;
                @Strike.canceled += instance.OnStrike;
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
                @Block.started += instance.OnBlock;
                @Block.performed += instance.OnBlock;
                @Block.canceled += instance.OnBlock;
            }
        }
    }
    public Level7Actions @Level7 => new Level7Actions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_XboxGamepadSchemeIndex = -1;
    public InputControlScheme XboxGamepadScheme
    {
        get
        {
            if (m_XboxGamepadSchemeIndex == -1) m_XboxGamepadSchemeIndex = asset.FindControlSchemeIndex("Xbox Gamepad");
            return asset.controlSchemes[m_XboxGamepadSchemeIndex];
        }
    }
    public interface IPlayerControlsActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnStoneTrowing(InputAction.CallbackContext context);
        void OnActivateThrowMode(InputAction.CallbackContext context);
    }
    public interface ILevel7Actions
    {
        void OnStrike(InputAction.CallbackContext context);
        void OnWalk(InputAction.CallbackContext context);
        void OnBlock(InputAction.CallbackContext context);
    }
}
