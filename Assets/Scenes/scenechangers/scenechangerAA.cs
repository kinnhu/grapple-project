using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class scenechangerAA : MonoBehaviour
{
    [SerializeField]
    private InputActionReference throwchangeAA;
    [SerializeField]
    private InputActionReference grapplechangeAA;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hiiiii");
        throwchangeAA.action.performed += changethrowAA;
        grapplechangeAA.action.performed += changegrappleAA;

    }
    void changethrowAA(InputAction.CallbackContext __)
    {
        SceneManager.LoadScene("Scenes/SceneBA");

    }
    void changegrappleAA(InputAction.CallbackContext __)
    {
        SceneManager.LoadScene("Scenes/SceneAB");

    }
}