using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keymenu : MonoBehaviour
{
    private InputManager inputManager;

    private void Start()
    {
        inputManager = InputManager.instance;
    }

    void Update()
    {
        if (inputManager.GetKeyDown(KeybindingActions.Up))
        {
            transform.Translate(0, 1, 0);
        }
    }
}
