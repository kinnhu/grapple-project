using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class linecode : MonoBehaviour
{
    float ison = 1f;
    [SerializeField]
    private InputActionReference linestard;
    [SerializeField]
    private InputActionReference lineend;
    [SerializeField]
    public LineRenderer line;
    [SerializeField]
    public GameObject gp;
    [SerializeField]
    public GameObject righthand;

    public float xAngle, yAngle, zAngle;


    // Start is called before the first frame update
    void Start()
    {
        linestard.action.started += stardone;
        lineend.action.canceled += endone;
    }
    void stardone(InputAction.CallbackContext __)
    {
        ison = 2f;
    }
    void endone(InputAction.CallbackContext __)
    {
        ison = 1f;
    }
    // Update is called once per frame
    void Update()
    {
        if (ison == 2f)
        {
            line.SetPosition(0, gp.transform.position);
            line.SetPosition(1, righthand.transform.position);
        }
        transform.LookAt(righthand.transform.position);
        transform.Rotate(180.0f, 0.0f, 0.0f, Space.Self);
    }
}
