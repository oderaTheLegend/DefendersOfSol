using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : MonoBehaviour
{
 
    private void Start()
    {
       
    }
    private void OnMouseDown()
    {
       
        int rand = Random.Range(1, 10);
        if (rand <= 5)
        {
            Debug.Log("increase");
            // return;
        }
        else if (rand >= 6)
        {
            Debug.Log("decrease");
            // return;
        }
     

    }
    
}
