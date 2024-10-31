using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class grapplecodeAB : MonoBehaviour
{
    [SerializeField]
    private InputActionReference grappledeploy;
    [SerializeField]
    private InputActionReference grappleactivate;
    [SerializeField]
    private GameObject grapplepointAA;
    [SerializeField]
    public GameObject righthand;
    [SerializeField]
    private LayerMask GPExept;
    [SerializeField]
    private GameObject XROrigin;
    [SerializeField]
    public GameObject endthingy;


    float isgrappleing = 0f;
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

        GameObject[] oldGrapples = GameObject.FindGameObjectsWithTag("grapple");
        for (int i = 0; i < oldGrapples.Length; i++)
        {
            //Destroy(gameObject);
            Destroy(oldGrapples[i]);

        }
        RaycastHit hit;
        bool didHit = Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, GPExept);
        Debug.Log("hit something");
        if (didHit)
        {

            // The object we hit will be in the collider property of our hit object.
            // We can get the name of that object by accessing it's Game Object then the name property

            GameObject newgrapplepointAA = Instantiate(grapplepointAA, transform.position, transform.rotation);
            newgrapplepointAA.transform.position = hit.collider.gameObject.transform.position;
            LineRenderer line = newgrapplepointAA.GetComponent<LineRenderer>();
            line.SetPosition(0, newgrapplepointAA.transform.position);
            line.SetPosition(1, newgrapplepointAA.transform.position);

        }

        // Don't forget to attach the player origin in the editor!


    }
    void dograpple(InputAction.CallbackContext __)
    {

        isgrappleing = 2f;
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

            

            XROrigin.transform.position= Vector3.MoveTowards(XROrigin.transform.position,currentgp.transform.position,.05f);
            
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