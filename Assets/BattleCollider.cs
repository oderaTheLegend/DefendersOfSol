using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleCollider : MonoBehaviour {
    public GameObject skeletonGO1;
    public GameObject skeletonGO2;
    bool spawnSkeleton;
    public float smoothingSpeed;
    BoxCollider2D myCollider;
    public Character skeleton;
    public Character scarecrow;
    public Character lavaGolem;
    // Use this for initialization
    void Start () {
        myCollider = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frameggg
	void Update () {
        if (Input.GetKeyUp(KeyCode.G))
        {
           
        }
        if (spawnSkeleton)
        {

            Vector3 desiredPos = new Vector3(15.2f, -2.76f, -3.04f);
            Vector3 smoothedPos = Vector3.Lerp(skeletonGO1.transform.position, desiredPos, smoothingSpeed);
            skeletonGO1.transform.position = smoothedPos;

            Vector3 desiredPos2 = new Vector3(17f, -2.76f, -3.04f);
            Vector3 smoothedPos2 = Vector3.Lerp(skeletonGO2.transform.position, desiredPos2, smoothingSpeed);
            skeletonGO2.transform.position = smoothedPos2;


        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            BattleManager.StartBattle(2, skeleton, scarecrow, null);
            spawnSkeleton = true;
            PlayerController.inBattle = true;
            myCollider.enabled = false;
            
           // Destroy(gameObject);
        }
    }
}
