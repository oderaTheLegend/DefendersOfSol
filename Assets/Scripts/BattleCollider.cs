using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleCollider : MonoBehaviour {
    public GameObject skeletonGO1;
    public GameObject skeletonGO2;
    bool spawnSkeleton;
   
    BoxCollider2D myCollider;
    //public Character skeleton;
    //public Character scarecrow;
    //public Character lavaGolem;

    public Character publicEnemy1;
    public Character publicEnemy2;
    public Character publicEnemy3;
    public int publicEnemyCount;
    public Transform publicEnemy1Pos;
    public Transform publicEnemy2Pos;
    public Transform publicEnemy3Pos;
    // Use this for initialization
    void Start () {
        myCollider = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frameggg
	void Update () {
        if (Input.GetKeyUp(KeyCode.G))
        {
           
        }
   
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            if (publicEnemyCount==1)
            {
                BattleManager.instance.StartBattle(1, publicEnemy1, null, null);
                GameObject prefabClone1 = Instantiate(publicEnemy1.myPrefab, publicEnemy1Pos.position,Quaternion.identity);
                prefabClone1.SetActive(true);
                BattleManager.instance.EnemyClone(prefabClone1, null, null);
                PlayerController.inBattle = true;
                myCollider.enabled = false;
            }
            else if (publicEnemyCount == 2)
            {
                
                BattleManager.instance.StartBattle(2, publicEnemy1, publicEnemy2, null);
                GameObject prefabClone1 = Instantiate(publicEnemy1.myPrefab, publicEnemy1Pos.position, Quaternion.identity) ;
                prefabClone1.SetActive(true);
                GameObject prefabClone2 = Instantiate(publicEnemy2.myPrefab, publicEnemy2Pos.position, Quaternion.identity) ;
                prefabClone2.SetActive(true);
                BattleManager.instance.EnemyClone(prefabClone1, prefabClone2, null);
                PlayerController.inBattle = true;

                myCollider.enabled = false;
            }
            else if (publicEnemyCount == 3)
            {
                BattleManager.instance.StartBattle(3, publicEnemy1, publicEnemy2, publicEnemy3);
                GameObject prefabClone1 = Instantiate(publicEnemy1.myPrefab, publicEnemy1Pos.position, Quaternion.identity);
                GameObject prefabClone2 = Instantiate(publicEnemy2.myPrefab, publicEnemy2Pos.position, Quaternion.identity);
                GameObject prefabClone3 = Instantiate(publicEnemy3.myPrefab, publicEnemy3Pos.position, Quaternion.identity);
                prefabClone1.SetActive(true);
                prefabClone2.SetActive(true);
                prefabClone3.SetActive(true);
                BattleManager.instance.EnemyClone(prefabClone1, prefabClone2, prefabClone3);
                PlayerController.inBattle = true;
                myCollider.enabled = false;
            }


            // Destroy(gameObject);
        }
    }
}
