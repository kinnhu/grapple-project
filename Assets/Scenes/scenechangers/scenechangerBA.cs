using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class scenechangerBA : MonoBehaviour
{
    [SerializeField]
    private InputActionReference throwchangeBA;
    [SerializeField]
    private InputActionReference grapplechangeBA;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hiiiii");
        throwchangeBA.action.performed += changethrowBA;
        grapplechangeBA.action.performed += changegrappleBA;

    }
    void changethrowBA(InputAction.CallbackContext __)
    {
        SceneManager.LoadScene("Scenes/SceneCA");

    }
    void changegrappleBA(InputAction.CallbackContext __)
    {
        SceneManager.LoadScene("Scenes/SceneBB");

    }
}