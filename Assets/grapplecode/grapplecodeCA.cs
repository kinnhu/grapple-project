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
    Vector3 rh = new Vector3(0, 0, 0);

    void OnEnable()
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
        
        
        newgrapplepointCA.GetComponent<Rigidbody>().AddForce(transform.forward * 100f);


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

            XROrigin.GetComponent<Rigidbody>().AddForce((currentgp.transform.position - XROrigin.transform.position) * 3f);

            //XROrigin.transform.position= Vector3.MoveTowards(XROrigin.transform.position,currentgp.transform.position,.05f);
            LineRenderer line = currentgp.GetComponent<LineRenderer>();
            line.SetPosition(0, currentgp.transform.position);
            rh = righthand.transform.position;
            line.SetPosition(1, rh);
        }
        else if (isgrappleing == 1f)
        {
            GameObject currentgp = GameObject.FindGameObjectWithTag("grapple");
            LineRenderer line = currentgp.GetComponent<LineRenderer>();


            line.SetPosition(0, currentgp.transform.position);
            line.SetPosition(1, currentgp.transform.position);

        }
    }


}