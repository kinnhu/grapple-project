using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class scenechangerBB : MonoBehaviour
{
    [SerializeField]
    private InputActionReference throwchangeBB;
    [SerializeField]
    private InputActionReference grapplechangeBB;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hiiiii");
        throwchangeBB.action.performed += changethrowBB;
        grapplechangeBB.action.performed += changegrappleBB;

    }
    void changethrowBB(InputAction.CallbackContext __)
    {
        SceneManager.LoadScene("Scenes/SceneCB");

    }
    void changegrappleBB(InputAction.CallbackContext __)
    {
        SceneManager.LoadScene("Scenes/SceneBC");

    }
}