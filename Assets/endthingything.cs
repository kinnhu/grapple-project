using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endthingything : MonoBehaviour
{
    [SerializeField]
    public GameObject endthing;
    [SerializeField]
    public GameObject righthand;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        endthing.transform.position = righthand.transform.position;
    }
}
