using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class grappletypehandler : MonoBehaviour
{
    [SerializeField]
    private InputActionReference throwchange;
    [SerializeField]
    private InputActionReference grapplechange;
    public GameObject RightHandController;
    float throwtype = 1f;
    float grappletype = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hiiiii");
        throwchange.action.performed += changethrow;
        grapplechange.action.performed += changegrapple;
        
    }
    
    // Update is called once per frame
    void changethrow(InputAction.CallbackContext __)
    {
        if (throwtype < 3f)
        {
            throwtype = throwtype+1f;
        }
        if (throwtype == 3f)
        {
            throwtype = 1f;
        }
        updategrapple();
    }
    void changegrapple(InputAction.CallbackContext __)
    {
        if (grappletype < 3f)
        {
            grappletype = grappletype+ 1f;
        }
        else if (grappletype == 3f)
        {
            grappletype = 1f;
        }
        updategrapple();
    }
    void updategrapple()
    {

        Debug.Log("throwtype");
        Debug.Log(throwtype);
        Debug.Log("grappletype");
        Debug.Log(grappletype);

        if (throwtype == 1f)
        {
            if (grappletype == 1f)
            {
                gameObject.GetComponent<grapplecodeAA>().enabled = true;
                gameObject.GetComponent<grapplecodeAB>().enabled = false;
                gameObject.GetComponent<grapplecodeAC>().enabled = false;
                gameObject.GetComponent<grapplecodeBA>().enabled = false;
                gameObject.GetComponent<grapplecodeBB>().enabled = false;
                gameObject.GetComponent<grapplecodeBC>().enabled = false;
                gameObject.GetComponent<grapplecodeCA>().enabled = false;
                gameObject.GetComponent<grapplecodeCB>().enabled = false;
                gameObject.GetComponent<grapplecodeCC>().enabled = false;



            }
            if (grappletype == 2f)
            {
                gameObject.GetComponent<grapplecodeAA>().enabled = false;
                gameObject.GetComponent<grapplecodeAB>().enabled = true;
                gameObject.GetComponent<grapplecodeAC>().enabled = false;
                gameObject.GetComponent<grapplecodeBA>().enabled = false;
                gameObject.GetComponent<grapplecodeBB>().enabled = false;
                gameObject.GetComponent<grapplecodeBC>().enabled = false;
                gameObject.GetComponent<grapplecodeCA>().enabled = false;
                gameObject.GetComponent<grapplecodeCB>().enabled = false;
                gameObject.GetComponent<grapplecodeCC>().enabled = false;
            }
            if (grappletype == 3f)
            {
                gameObject.GetComponent<grapplecodeAA>().enabled = false;
                gameObject.GetComponent<grapplecodeAB>().enabled = false;
                gameObject.GetComponent<grapplecodeAC>().enabled = true;
                gameObject.GetComponent<grapplecodeBA>().enabled = false;
                gameObject.GetComponent<grapplecodeBB>().enabled = false;
                gameObject.GetComponent<grapplecodeBC>().enabled = false;
                gameObject.GetComponent<grapplecodeCA>().enabled = false;
                gameObject.GetComponent<grapplecodeCB>().enabled = false;
                gameObject.GetComponent<grapplecodeCC>().enabled = false;
            }
        }
        if (throwtype == 2f)
        {
            if (grappletype == 1f)
            {
                gameObject.GetComponent<grapplecodeAA>().enabled = false;
                gameObject.GetComponent<grapplecodeAB>().enabled = false;
                gameObject.GetComponent<grapplecodeAC>().enabled = false;
                gameObject.GetComponent<grapplecodeBA>().enabled = true;
                gameObject.GetComponent<grapplecodeBB>().enabled = false;
                gameObject.GetComponent<grapplecodeBC>().enabled = false;
                gameObject.GetComponent<grapplecodeCA>().enabled = false;
                gameObject.GetComponent<grapplecodeCB>().enabled = false;
                gameObject.GetComponent<grapplecodeCC>().enabled = false;
            }
            if (grappletype == 2f)
            {
                gameObject.GetComponent<grapplecodeAA>().enabled = false;
                gameObject.GetComponent<grapplecodeAB>().enabled = false;
                gameObject.GetComponent<grapplecodeAC>().enabled = false;
                gameObject.GetComponent<grapplecodeBA>().enabled = false;
                gameObject.GetComponent<grapplecodeBB>().enabled = true;
                gameObject.GetComponent<grapplecodeBC>().enabled = false;
                gameObject.GetComponent<grapplecodeCA>().enabled = false;
                gameObject.GetComponent<grapplecodeCB>().enabled = false;
                gameObject.GetComponent<grapplecodeCC>().enabled = false;
            }
            if (grappletype == 3f)
            {
                gameObject.GetComponent<grapplecodeAA>().enabled = false;
                gameObject.GetComponent<grapplecodeAB>().enabled = false;
                gameObject.GetComponent<grapplecodeAC>().enabled = false;
                gameObject.GetComponent<grapplecodeBA>().enabled = false;
                gameObject.GetComponent<grapplecodeBB>().enabled = false;
                gameObject.GetComponent<grapplecodeBC>().enabled = true;
                gameObject.GetComponent<grapplecodeCA>().enabled = false;
                gameObject.GetComponent<grapplecodeCB>().enabled = false;
                gameObject.GetComponent<grapplecodeCC>().enabled = false;
            }
        }
        if (throwtype == 3f)
        {
            if (grappletype == 1f)
            {
                gameObject.GetComponent<grapplecodeAA>().enabled = false;
                gameObject.GetComponent<grapplecodeAB>().enabled = false;
                gameObject.GetComponent<grapplecodeAC>().enabled = false;
                gameObject.GetComponent<grapplecodeBA>().enabled = false;
                gameObject.GetComponent<grapplecodeBB>().enabled = false;
                gameObject.GetComponent<grapplecodeBC>().enabled = false;
                gameObject.GetComponent<grapplecodeCA>().enabled = true;
                gameObject.GetComponent<grapplecodeCB>().enabled = false;
                gameObject.GetComponent<grapplecodeCC>().enabled = false;
            }
            if (grappletype == 2f)
            {
                gameObject.GetComponent<grapplecodeAA>().enabled = false;
                gameObject.GetComponent<grapplecodeAB>().enabled = false;
                gameObject.GetComponent<grapplecodeAC>().enabled = false;
                gameObject.GetComponent<grapplecodeBA>().enabled = false;
                gameObject.GetComponent<grapplecodeBB>().enabled = false;
                gameObject.GetComponent<grapplecodeBC>().enabled = false;
                gameObject.GetComponent<grapplecodeCA>().enabled = false;
                gameObject.GetComponent<grapplecodeCB>().enabled = true;
                gameObject.GetComponent<grapplecodeCC>().enabled = false;
            }
            if (grappletype == 3f)
            {
                gameObject.GetComponent<grapplecodeAA>().enabled = false;
                gameObject.GetComponent<grapplecodeAB>().enabled = false;
                gameObject.GetComponent<grapplecodeAC>().enabled = false;
                gameObject.GetComponent<grapplecodeBA>().enabled = false;
                gameObject.GetComponent<grapplecodeBB>().enabled = false;
                gameObject.GetComponent<grapplecodeBC>().enabled = false;
                gameObject.GetComponent<grapplecodeCA>().enabled = false;
                gameObject.GetComponent<grapplecodeCB>().enabled = false;
                gameObject.GetComponent<grapplecodeCC>().enabled = true;
            }
        }
    }
}
