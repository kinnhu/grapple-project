using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class scenechangerCC : MonoBehaviour
{
    [SerializeField]
    private InputActionReference throwchangeCC;
    [SerializeField]
    private InputActionReference grapplechangeCC;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hiiiii");
        throwchangeCC.action.performed += changethrowCC;
        grapplechangeCC.action.performed += changegrappleCC;

    }
    void changethrowCC(InputAction.CallbackContext __)
    {
        SceneManager.LoadScene("Scenes/SceneAC");

    }
    void changegrappleCC(InputAction.CallbackContext __)
    {
        SceneManager.LoadScene("Scenes/SceneCA");

    }
}