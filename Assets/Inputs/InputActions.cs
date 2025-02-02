// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""InGame"",
            ""id"": ""c8b4917d-667e-467f-a099-f6ecdc6846fa"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""61f33f78-c5e8-4cd8-b23d-ce12f2108457"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""b6c94d19-09c2-4f0b-aa05-475a1164aea0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""2f4549e6-7d6f-4273-9fb7-6680f6a2c7cc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LookX"",
                    ""type"": ""Value"",
                    ""id"": ""18096f9f-ddbc-4ce9-a500-dacd5b99c063"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LookY"",
                    ""type"": ""Value"",
                    ""id"": ""b5424690-2161-4023-a660-86651b3584db"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Grab"",
                    ""type"": ""Button"",
                    ""id"": ""bf8c6f01-7f75-452f-8314-fd87cf4ea352"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UseItem"",
                    ""type"": ""Button"",
                    ""id"": ""cb935cde-cc67-47e4-8671-ad10f1d8e833"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""00727765-f700-4df3-8913-2dc82d3f1efa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Stand"",
                    ""type"": ""Button"",
                    ""id"": ""02a71b45-488b-4e33-aaf2-9bdc59a54a89"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c5fa974c-688d-4cec-98cc-45dc4b2c0b9f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f92d9151-2275-4ee4-8c06-7be5dbc477d4"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Vector"",
                    ""id"": ""9270d3d7-d091-42bc-865f-0b35db18ba61"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""96487f4f-5296-4601-9174-2d97c3bca45a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""475b9247-dab3-4e70-837f-493503eb6390"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""da40cf8e-3ed7-4e00-9158-8342638f3062"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4f3f02cb-4df8-4b57-ac56-f9fe4d68e580"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b16047a1-6e60-423a-8203-bcbcf4aebfc9"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""LookX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""162b5ca1-651e-40ad-a327-0c3baf418c7b"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": ""Invert"",
                    ""groups"": ""KBM"",
                    ""action"": ""LookY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b765be51-f0b2-484e-b217-1a02725982ea"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c430c7b0-8264-453f-b700-d5520d8aff04"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""UseItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""013ccc15-e21a-4e42-893a-9226fcb21152"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c04e284-42e1-4bb3-9dab-b30fc2c76ba7"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Stand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KBM"",
            ""bindingGroup"": ""KBM"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // InGame
        m_InGame = asset.FindActionMap("InGame", throwIfNotFound: true);
        m_InGame_Move = m_InGame.FindAction("Move", throwIfNotFound: true);
        m_InGame_Jump = m_InGame.FindAction("Jump", throwIfNotFound: true);
        m_InGame_Sprint = m_InGame.FindAction("Sprint", throwIfNotFound: true);
        m_InGame_LookX = m_InGame.FindAction("LookX", throwIfNotFound: true);
        m_InGame_LookY = m_InGame.FindAction("LookY", throwIfNotFound: true);
        m_InGame_Grab = m_InGame.FindAction("Grab", throwIfNotFound: true);
        m_InGame_UseItem = m_InGame.FindAction("UseItem", throwIfNotFound: true);
        m_InGame_Crouch = m_InGame.FindAction("Crouch", throwIfNotFound: true);
        m_InGame_Stand = m_InGame.FindAction("Stand", throwIfNotFound: true);
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

    // InGame
    private readonly InputActionMap m_InGame;
    private IInGameActions m_InGameActionsCallbackInterface;
    private readonly InputAction m_InGame_Move;
    private readonly InputAction m_InGame_Jump;
    private readonly InputAction m_InGame_Sprint;
    private readonly InputAction m_InGame_LookX;
    private readonly InputAction m_InGame_LookY;
    private readonly InputAction m_InGame_Grab;
    private readonly InputAction m_InGame_UseItem;
    private readonly InputAction m_InGame_Crouch;
    private readonly InputAction m_InGame_Stand;
    public struct InGameActions
    {
        private @InputActions m_Wrapper;
        public InGameActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_InGame_Move;
        public InputAction @Jump => m_Wrapper.m_InGame_Jump;
        public InputAction @Sprint => m_Wrapper.m_InGame_Sprint;
        public InputAction @LookX => m_Wrapper.m_InGame_LookX;
        public InputAction @LookY => m_Wrapper.m_InGame_LookY;
        public InputAction @Grab => m_Wrapper.m_InGame_Grab;
        public InputAction @UseItem => m_Wrapper.m_InGame_UseItem;
        public InputAction @Crouch => m_Wrapper.m_InGame_Crouch;
        public InputAction @Stand => m_Wrapper.m_InGame_Stand;
        public InputActionMap Get() { return m_Wrapper.m_InGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InGameActions set) { return set.Get(); }
        public void SetCallbacks(IInGameActions instance)
        {
            if (m_Wrapper.m_InGameActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnJump;
                @Sprint.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnSprint;
                @LookX.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnLookX;
                @LookX.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnLookX;
                @LookX.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnLookX;
                @LookY.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnLookY;
                @LookY.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnLookY;
                @LookY.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnLookY;
                @Grab.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnGrab;
                @Grab.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnGrab;
                @Grab.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnGrab;
                @UseItem.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnUseItem;
                @UseItem.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnUseItem;
                @UseItem.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnUseItem;
                @Crouch.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnCrouch;
                @Stand.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnStand;
                @Stand.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnStand;
                @Stand.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnStand;
            }
            m_Wrapper.m_InGameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @LookX.started += instance.OnLookX;
                @LookX.performed += instance.OnLookX;
                @LookX.canceled += instance.OnLookX;
                @LookY.started += instance.OnLookY;
                @LookY.performed += instance.OnLookY;
                @LookY.canceled += instance.OnLookY;
                @Grab.started += instance.OnGrab;
                @Grab.performed += instance.OnGrab;
                @Grab.canceled += instance.OnGrab;
                @UseItem.started += instance.OnUseItem;
                @UseItem.performed += instance.OnUseItem;
                @UseItem.canceled += instance.OnUseItem;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Stand.started += instance.OnStand;
                @Stand.performed += instance.OnStand;
                @Stand.canceled += instance.OnStand;
            }
        }
    }
    public InGameActions @InGame => new InGameActions(this);
    private int m_KBMSchemeIndex = -1;
    public InputControlScheme KBMScheme
    {
        get
        {
            if (m_KBMSchemeIndex == -1) m_KBMSchemeIndex = asset.FindControlSchemeIndex("KBM");
            return asset.controlSchemes[m_KBMSchemeIndex];
        }
    }
    public interface IInGameActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnLookX(InputAction.CallbackContext context);
        void OnLookY(InputAction.CallbackContext context);
        void OnGrab(InputAction.CallbackContext context);
        void OnUseItem(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnStand(InputAction.CallbackContext context);
    }
}
