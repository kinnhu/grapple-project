using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class gonoff : MonoBehaviour
{
    [SerializeField]
    private InputActionReference onnoff;

    private ActionBasedContinuousMoveProvider moveProvider;
    void Start()
    {
        moveProvider=GetComponent<ActionBasedContinuousMoveProvider>();
        onnoff.action.started += goff;
        onnoff.action.canceled += gon;

    }
    void gon(InputAction.CallbackContext __)
    {
        moveProvider.useGravity = false;
    }
    void goff(InputAction.CallbackContext __)
    {
        moveProvider.useGravity = true;
    }


}
