using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class grapplecodeCA : MonoBehaviour
{
    [SerializeField]
    private InputActionReference grappledeploy;
    [SerializeField]
    private InputActionReference grappleactivate;
    [SerializeField]
    private GameObject grapplepointCA;
    [SerializeField]
    public GameObject righthand;
    [SerializeField]
    private LayerMask Default;
    [SerializeField]
    private GameObject XROrigin;

    Vector3 stopspot = new Vector3(0f, 0f, 0f);
    float isgrappleing = 1f;

    void Start()
    {
        Debug.Log("test");

        grappledeploy.action.performed += DoRaycast;
        grappleactivate.action.started += dograpple;
        grappleactivate.action.canceled += endgrapple;
    }

    void DoRaycast(InputAction.CallbackContext __)
    {
        Debug.Log("hit something");

        GameObject[] oldGrapples = GameObject.FindGameObjectsWithTag("grapple");
        for (int i = 0; i < oldGrapples.Length; i++)
        {
            //Destroy(gameObject);
            Destroy(oldGrapples[i]);

        }
        // The object we hit will be in the collider property of our hit object.
        // We can get the name of that object by accessing it's Game Object then the name property

        GameObject newgrapplepointCA = Instantiate(grapplepointCA, transform.position, transform.rotation);
        newgrapplepointCA.transform.position = righthand.transform.position;
        newgrapplepointCA.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
        //newgrapplepoint.GetComponent<Rigidbody>().AddForce(transform.forward * velo);


        // Don't forget to attach the player origin in the editor!


    }
    void dograpple(InputAction.CallbackContext __)
    {
        isgrappleing = 2f;
        GameObject currentgp = GameObject.FindGameObjectWithTag("grapple");
        stopspot = currentgp.transform.position;
        Destroy(currentgp);
        GameObject newgrapplepointCA = Instantiate(grapplepointCA, transform.position, transform.rotation);
        //newgrapplepointCA.GetComponent<RigidBody>().useGravity = false;
        newgrapplepointCA.transform.position = stopspot;
    }
    void endgrapple(InputAction.CallbackContext __)
    {
        isgrappleing = 1f;
    }
    void Update()
    {
        if (isgrappleing == 2f)
        {
            GameObject currentgp = GameObject.FindGameObjectWithTag("grapple");
            XROrigin.GetComponent<Rigidbody>().AddForce(currentgp.transform.forward * .5f);
            LineRenderer line = currentgp.GetComponent<LineRenderer>();
            line.SetPosition(0, currentgp.transform.position);
            line.SetPosition(1, righthand.transform.position);
            currentgp.transform.position = stopspot;
        }
        else
        {
            GameObject currentgp = GameObject.FindGameObjectWithTag("grapple");
            LineRenderer line = currentgp.GetComponent<LineRenderer>();
            line.SetPosition(0, currentgp.transform.position);
            line.SetPosition(1, currentgp.transform.position);
        }
    }


}