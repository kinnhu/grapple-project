using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class scenechangerAC : MonoBehaviour
{
    [SerializeField]
    private InputActionReference throwchangeAC;
    [SerializeField]
    private InputActionReference grapplechangeAC;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hiiiii");
        throwchangeAC.action.performed += changethrowAC;
        grapplechangeAC.action.performed += changegrappleAC;

    }
    void changethrowAC(InputAction.CallbackContext __)
    {
        SceneManager.LoadScene("Scenes/SceneBC");

    }
    void changegrappleAC(InputAction.CallbackContext __)
    {
        SceneManager.LoadScene("Scenes/SceneAA");

    }
}