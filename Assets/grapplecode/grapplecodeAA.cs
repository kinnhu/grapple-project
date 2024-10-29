using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class grapplecodeAA : MonoBehaviour
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
    private LayerMask Default;
    [SerializeField]
    private GameObject XROrigin;
    
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
  
        
            RaycastHit hit;
            bool didHit = Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, default);
            Debug.Log("hit something");
            if (didHit)
            {
                GameObject[] oldGrapples = GameObject.FindGameObjectsWithTag("grapple");
                for (int i = 0; i < oldGrapples.Length; i++)
                {
                    //Destroy(gameObject);
                    Destroy(oldGrapples[i]);

                }
                // The object we hit will be in the collider property of our hit object.
                // We can get the name of that object by accessing it's Game Object then the name property

                GameObject newgrapplepointAA = Instantiate(grapplepointAA, transform.position, transform.rotation);
                newgrapplepointAA.transform.position = hit.collider.gameObject.transform.position;
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
            XROrigin.GetComponent<Rigidbody>().AddForce(currentgp.transform.forward * .5f);
            LineRenderer line = currentgp.GetComponent<LineRenderer>();
            line.SetPosition(0, currentgp.transform.position);
            line.SetPosition(1, righthand.transform.position);
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