using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class scenechangerCA : MonoBehaviour
{
    [SerializeField]
    private InputActionReference throwchangeCA;
    [SerializeField]
    private InputActionReference grapplechangeCA;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hiiiii");
        throwchangeCA.action.performed += changethrowCA;
        grapplechangeCA.action.performed += changegrappleCA;

    }
    void changethrowCA(InputAction.CallbackContext __)
    {
        SceneManager.LoadScene("Scenes/SceneAA");

    }
    void changegrappleCA(InputAction.CallbackContext __)
    {
        SceneManager.LoadScene("Scenes/SceneCB");

    }
}