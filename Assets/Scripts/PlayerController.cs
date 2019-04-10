using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
 
    SpriteRenderer sr;
    SpriteRenderer sr2;
    Animator anim;
    Animator anim2;
    public GameObject player2;
    public GameObject mainCam;
    CameraScript camScript;
    bool skeletonTrigger;

 
    public GameObject skeletonGO1;
    public GameObject skeletonGO2;
    public GameObject hauntedScarecrow;

    public float smoothingSpeed;
    public static bool inBattle;
    bool spawnSkeleton;
    // Use this for initialization
    void Start () {

     
        sr = GetComponent<SpriteRenderer>();
        sr2 = player2.GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        anim2 = player2.GetComponent<Animator>();
        inBattle = false;
        spawnSkeleton = false;

        camScript = mainCam.GetComponent<CameraScript>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.D)&&!inBattle)
        {
            anim.SetBool("isWalking", true);
            anim2.SetBool("isWalking", true);
            sr.flipX = false;
            sr2.flipX = false;
            transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A)&&transform.position.x>=-2&&!inBattle)
        {

            anim.SetBool("isWalking", true);
            anim2.SetBool("isWalking", true);
            sr.flipX = true;
            sr2.flipX = true;
            transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
        }
        if (!Input.GetKey(KeyCode.A)&& !Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isWalking", false);
            anim2.SetBool("isWalking", false);
        }
        //if (transform.position.x >= 6)
        //{

        //    Vector3 desiredPos = new Vector3(15.2f, -2.76f, -3.04f);
        //    Vector3 smoothedPos = Vector3.Lerp(skeletonGO1.transform.position, desiredPos, smoothingSpeed);
        //    skeletonGO1.transform.position = smoothedPos;

        //    Vector3 desiredPos2 = new Vector3(17f, -2.76f, -3.04f);
        //    Vector3 smoothedPos2 = Vector3.Lerp(skeletonGO2.transform.position, desiredPos2, smoothingSpeed);
        //    skeletonGO2.transform.position = smoothedPos2;


        //}
        //if (spawnSkeleton)
        //{

        //    Vector3 desiredPos = new Vector3(15.2f, -2.76f, -3.04f);
        //    Vector3 smoothedPos = Vector3.Lerp(skeletonGO1.transform.position, desiredPos, smoothingSpeed);
        //    skeletonGO1.transform.position = smoothedPos;

        //    Vector3 desiredPos2 = new Vector3(17f, -2.76f, -3.04f);
        //    Vector3 smoothedPos2 = Vector3.Lerp(skeletonGO2.transform.position, desiredPos2, smoothingSpeed);
        //    skeletonGO2.transform.position = smoothedPos2;

            
        //}

        if (transform.position.x >= 45)
        {

            Vector3 desiredPos3 = new Vector3(52.91f, -3.1f, -2.34f);
            Vector3 smoothedPos3 = Vector3.Lerp(hauntedScarecrow.transform.position, desiredPos3, smoothingSpeed);
            hauntedScarecrow.transform.position = smoothedPos3;
        }
        if (Input.GetKeyUp(KeyCode.B))
        {
            inBattle = false;
        }
        if (inBattle)
        {
            camScript.offset.x = 5;
            
        }
        else
        {
            camScript.offset.x = 1;
           
        }
      
    }

    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    Debug.Log("1122");
    //    if (other.gameObject.tag=="Battler")
    //    {
    //        spawnSkeleton = true;
    //        inBattle = true;
    //        Destroy(other.gameObject);
    //    }
    //}
}
