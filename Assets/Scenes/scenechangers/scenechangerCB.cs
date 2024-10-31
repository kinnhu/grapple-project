using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class scenechangerCB : MonoBehaviour
{
    [SerializeField]
    private InputActionReference throwchangeCB;
    [SerializeField]
    private InputActionReference grapplechangeCB;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hiiiii");
        throwchangeCB.action.performed += changethrowCB;
        grapplechangeCB.action.performed += changegrappleCB;

    }
    void changethrowCB(InputAction.CallbackContext __)
    {
        SceneManager.LoadScene("Scenes/SceneAB");

    }
    void changegrappleCB(InputAction.CallbackContext __)
    {
        SceneManager.LoadScene("Scenes/SceneCC");

    }
}