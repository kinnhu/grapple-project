using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class scenechangerAB : MonoBehaviour
{
    [SerializeField]
    private InputActionReference throwchangeAB;
    [SerializeField]
    private InputActionReference grapplechangeAB;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hiiiii");
        throwchangeAB.action.performed += changethrowAB;
        grapplechangeAB.action.performed += changegrappleAB;

    }
    void changethrowAB(InputAction.CallbackContext __)
    {
        SceneManager.LoadScene("Scenes/SceneBB");

    }
    void changegrappleAB(InputAction.CallbackContext __)
    {
        SceneManager.LoadScene("Scenes/SceneAC");

    }
}