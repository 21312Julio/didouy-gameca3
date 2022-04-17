//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/PlayerMovement.inputactions
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

public partial class @PlayerMovement : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerMovement()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerMovement"",
    ""maps"": [
        {
            ""name"": ""Main"",
            ""id"": ""9b7e64f8-7416-4ca3-af10-c90a42ba30bd"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0ef40dc7-bde9-427a-adcc-09a473d2ad5b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7729ae1d-f308-420a-b674-a50a477082b3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ChangeWorld"",
                    ""type"": ""PassThrough"",
                    ""id"": ""af022ddc-f426-4af5-8009-1dc267555a4f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Continue Dialogue"",
                    ""type"": ""PassThrough"",
                    ""id"": ""128281c2-344e-486c-aba9-64c4d3510883"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""UseItem"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f55720a6-c89e-44fd-a1a3-535cb0176f6f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ClosePanel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6ec253ea-6b82-4898-bed1-7869a67ab68c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""89dd8867-f3a1-420f-bf15-14307740e252"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5bc3c9d4-f916-474a-98b2-973f1c5f1ec7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""69458390-f2f8-471e-8691-8b063abdcc42"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""069e61a3-221b-4459-bac8-ff83e65fb0a5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""20faabdf-f73c-40fb-84fd-6d29c71f9f1c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e6c0f91c-9423-4377-a78b-c04f03ff18b5"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""25bd2518-bd93-4e5d-9ceb-35270b097f85"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeWorld"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f81e1db6-82cd-4cfd-aa9b-e6362d93f694"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Continue Dialogue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""78a63f50-efdf-40c1-ba4e-e51efa60f0d8"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UseItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0091b532-046e-4c72-a400-59da47d32fa8"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ClosePanel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Main
        m_Main = asset.FindActionMap("Main", throwIfNotFound: true);
        m_Main_Movement = m_Main.FindAction("Movement", throwIfNotFound: true);
        m_Main_Interact = m_Main.FindAction("Interact", throwIfNotFound: true);
        m_Main_ChangeWorld = m_Main.FindAction("ChangeWorld", throwIfNotFound: true);
        m_Main_ContinueDialogue = m_Main.FindAction("Continue Dialogue", throwIfNotFound: true);
        m_Main_UseItem = m_Main.FindAction("UseItem", throwIfNotFound: true);
        m_Main_ClosePanel = m_Main.FindAction("ClosePanel", throwIfNotFound: true);
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

    // Main
    private readonly InputActionMap m_Main;
    private IMainActions m_MainActionsCallbackInterface;
    private readonly InputAction m_Main_Movement;
    private readonly InputAction m_Main_Interact;
    private readonly InputAction m_Main_ChangeWorld;
    private readonly InputAction m_Main_ContinueDialogue;
    private readonly InputAction m_Main_UseItem;
    private readonly InputAction m_Main_ClosePanel;
    public struct MainActions
    {
        private @PlayerMovement m_Wrapper;
        public MainActions(@PlayerMovement wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Main_Movement;
        public InputAction @Interact => m_Wrapper.m_Main_Interact;
        public InputAction @ChangeWorld => m_Wrapper.m_Main_ChangeWorld;
        public InputAction @ContinueDialogue => m_Wrapper.m_Main_ContinueDialogue;
        public InputAction @UseItem => m_Wrapper.m_Main_UseItem;
        public InputAction @ClosePanel => m_Wrapper.m_Main_ClosePanel;
        public InputActionMap Get() { return m_Wrapper.m_Main; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainActions set) { return set.Get(); }
        public void SetCallbacks(IMainActions instance)
        {
            if (m_Wrapper.m_MainActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_MainActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnMovement;
                @Interact.started -= m_Wrapper.m_MainActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnInteract;
                @ChangeWorld.started -= m_Wrapper.m_MainActionsCallbackInterface.OnChangeWorld;
                @ChangeWorld.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnChangeWorld;
                @ChangeWorld.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnChangeWorld;
                @ContinueDialogue.started -= m_Wrapper.m_MainActionsCallbackInterface.OnContinueDialogue;
                @ContinueDialogue.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnContinueDialogue;
                @ContinueDialogue.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnContinueDialogue;
                @UseItem.started -= m_Wrapper.m_MainActionsCallbackInterface.OnUseItem;
                @UseItem.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnUseItem;
                @UseItem.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnUseItem;
                @ClosePanel.started -= m_Wrapper.m_MainActionsCallbackInterface.OnClosePanel;
                @ClosePanel.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnClosePanel;
                @ClosePanel.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnClosePanel;
            }
            m_Wrapper.m_MainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @ChangeWorld.started += instance.OnChangeWorld;
                @ChangeWorld.performed += instance.OnChangeWorld;
                @ChangeWorld.canceled += instance.OnChangeWorld;
                @ContinueDialogue.started += instance.OnContinueDialogue;
                @ContinueDialogue.performed += instance.OnContinueDialogue;
                @ContinueDialogue.canceled += instance.OnContinueDialogue;
                @UseItem.started += instance.OnUseItem;
                @UseItem.performed += instance.OnUseItem;
                @UseItem.canceled += instance.OnUseItem;
                @ClosePanel.started += instance.OnClosePanel;
                @ClosePanel.performed += instance.OnClosePanel;
                @ClosePanel.canceled += instance.OnClosePanel;
            }
        }
    }
    public MainActions @Main => new MainActions(this);
    public interface IMainActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnChangeWorld(InputAction.CallbackContext context);
        void OnContinueDialogue(InputAction.CallbackContext context);
        void OnUseItem(InputAction.CallbackContext context);
        void OnClosePanel(InputAction.CallbackContext context);
    }
}
