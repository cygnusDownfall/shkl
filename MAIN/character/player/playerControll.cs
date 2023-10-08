using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControll: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControll()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""playerControll"",
    ""maps"": [
        {
            ""name"": ""move"",
            ""id"": ""a6951095-43a7-47a8-b3cf-fac36e3e297b"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""c74ff792-0104-4a07-815e-1440d59fc3c4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""moveAhead"",
                    ""type"": ""PassThrough"",
                    ""id"": ""72861b18-da55-4ff0-949d-214e05a74313"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""moveTab"",
                    ""type"": ""Value"",
                    ""id"": ""15cd0450-ea16-44ed-bbb0-f79be930aacc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""wasd"",
                    ""id"": ""600eaa42-7963-4194-b764-eaad1df01367"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""25a5f372-397e-48a4-8b89-7a4f10e8a8c5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard&mouse"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ed14f259-6efd-4498-a37b-0a110322c0cf"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard&mouse"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a1434637-96a1-400a-9297-cf605fc056c0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard&mouse"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a66c247d-d98b-46dc-a6ca-ff51bd7a52b6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard&mouse"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""arrow"",
                    ""id"": ""92008389-4267-4f69-927a-791b3dee88ac"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6a990447-3f65-4978-a0e1-863946aa1c54"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard&mouse"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e14b358d-fb57-42a9-8c09-dcf9e932f6b8"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard&mouse"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b05a48c8-236a-4cf5-9176-0912b89f4bdd"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard&mouse"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""701ef62b-c0ee-4f30-a7f7-ff2adf1f919c"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard&mouse"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""791eb482-788d-4479-bf12-d6e4a8ed290a"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard&mouse"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9767cc00-85e7-42ee-a86d-3a373c93f3b5"",
                    ""path"": ""<AndroidJoystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""android"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""531a72c0-a828-4c43-ba7c-f20ff92309c9"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""android"",
                    ""action"": ""moveAhead"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c4eed520-9903-40a5-b2c2-7196341671b2"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""android"",
                    ""action"": ""moveTab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""keyboard&mouse"",
            ""bindingGroup"": ""keyboard&mouse"",
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
        },
        {
            ""name"": ""android"",
            ""bindingGroup"": ""android"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // move
        m_move = asset.FindActionMap("move", throwIfNotFound: true);
        m_move_move = m_move.FindAction("move", throwIfNotFound: true);
        m_move_moveAhead = m_move.FindAction("moveAhead", throwIfNotFound: true);
        m_move_moveTab = m_move.FindAction("moveTab", throwIfNotFound: true);
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

    // move
    private readonly InputActionMap m_move;
    private List<IMoveActions> m_MoveActionsCallbackInterfaces = new List<IMoveActions>();
    private readonly InputAction m_move_move;
    private readonly InputAction m_move_moveAhead;
    private readonly InputAction m_move_moveTab;
    public struct MoveActions
    {
        private @PlayerControll m_Wrapper;
        public MoveActions(@PlayerControll wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_move_move;
        public InputAction @moveAhead => m_Wrapper.m_move_moveAhead;
        public InputAction @moveTab => m_Wrapper.m_move_moveTab;
        public InputActionMap Get() { return m_Wrapper.m_move; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoveActions set) { return set.Get(); }
        public void AddCallbacks(IMoveActions instance)
        {
            if (instance == null || m_Wrapper.m_MoveActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MoveActionsCallbackInterfaces.Add(instance);
            @move.started += instance.OnMove;
            @move.performed += instance.OnMove;
            @move.canceled += instance.OnMove;
            @moveAhead.started += instance.OnMoveAhead;
            @moveAhead.performed += instance.OnMoveAhead;
            @moveAhead.canceled += instance.OnMoveAhead;
            @moveTab.started += instance.OnMoveTab;
            @moveTab.performed += instance.OnMoveTab;
            @moveTab.canceled += instance.OnMoveTab;
        }

        private void UnregisterCallbacks(IMoveActions instance)
        {
            @move.started -= instance.OnMove;
            @move.performed -= instance.OnMove;
            @move.canceled -= instance.OnMove;
            @moveAhead.started -= instance.OnMoveAhead;
            @moveAhead.performed -= instance.OnMoveAhead;
            @moveAhead.canceled -= instance.OnMoveAhead;
            @moveTab.started -= instance.OnMoveTab;
            @moveTab.performed -= instance.OnMoveTab;
            @moveTab.canceled -= instance.OnMoveTab;
        }

        public void RemoveCallbacks(IMoveActions instance)
        {
            if (m_Wrapper.m_MoveActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMoveActions instance)
        {
            foreach (var item in m_Wrapper.m_MoveActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MoveActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MoveActions @move => new MoveActions(this);
    private int m_keyboardmouseSchemeIndex = -1;
    public InputControlScheme keyboardmouseScheme
    {
        get
        {
            if (m_keyboardmouseSchemeIndex == -1) m_keyboardmouseSchemeIndex = asset.FindControlSchemeIndex("keyboard&mouse");
            return asset.controlSchemes[m_keyboardmouseSchemeIndex];
        }
    }
    private int m_androidSchemeIndex = -1;
    public InputControlScheme androidScheme
    {
        get
        {
            if (m_androidSchemeIndex == -1) m_androidSchemeIndex = asset.FindControlSchemeIndex("android");
            return asset.controlSchemes[m_androidSchemeIndex];
        }
    }
    public interface IMoveActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnMoveAhead(InputAction.CallbackContext context);
        void OnMoveTab(InputAction.CallbackContext context);
    }
}
