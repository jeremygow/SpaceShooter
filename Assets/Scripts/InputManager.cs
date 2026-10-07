using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{

    // Singleton instance for the manager
    public static InputManager instance;

    // Inputs
    public InputActionAsset controls;
    public InputAction moveAction;
    public InputAction fireAction;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        moveAction = controls.FindAction("Move");
        fireAction = controls.FindAction("Fire");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
