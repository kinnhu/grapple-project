using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class scenechangerBC : MonoBehaviour
{
    [SerializeField]
    private InputActionReference throwchangeBC;
    [SerializeField]
    private InputActionReference grapplechangeBC;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hiiiii");
        throwchangeBC.action.performed += changethrowBC;
        grapplechangeBC.action.performed += changegrappleBC;

    }
    void changethrowBC(InputAction.CallbackContext __)
    {
        SceneManager.LoadScene("Scenes/SceneCC");

    }
    void changegrappleBC(InputAction.CallbackContext __)
    {
        SceneManager.LoadScene("Scenes/SceneBA");

    }
}