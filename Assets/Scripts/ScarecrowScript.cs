using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScarecrowScript : MonoBehaviour {

    float smoothingSpeed = 0.05f;
    public Vector3 myInitialPos;
    // Use this for initialization
    void Start()
    {

    }
    private void Awake()
    {
        myInitialPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {



        Vector3 desiredPos = new Vector3(transform.position.x, myInitialPos.y - 10.0f, transform.position.y);
        Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothingSpeed);
        transform.position = smoothedPos;

        //Vector3 desiredPos2 = new Vector3(17f, -2.76f, -3.04f);
        //Vector3 smoothedPos2 = Vector3.Lerp(skeletonGO2.transform.position, desiredPos2, smoothingSpeed);
        //skeletonGO2.transform.position = smoothedPos2;



    }
}
