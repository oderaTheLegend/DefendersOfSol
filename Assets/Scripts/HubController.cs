using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HubController : MonoBehaviour
{
     public RawImage backGroundImage;
     public Text backGroundText;
     public Button exitButton;
     public GameObject missionPanel1;
     public GameObject missionPanel2;
     public GameObject missionPanel3;
    // Start is called before the first frame update
    void Start()
    {
        backGroundImage.gameObject.SetActive(false);
        backGroundText.gameObject.SetActive(false);
        exitButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void MissionButton()
    {
        backGroundImage.gameObject.SetActive(false);
        backGroundText.gameObject.SetActive(false);
        exitButton.gameObject.SetActive(false);
    }

    public void LoadingMissions()
    {
        backGroundImage.gameObject.SetActive(true);
        backGroundText.gameObject.SetActive(true);
        exitButton.gameObject.SetActive(true);
    }
    public void Missions(int index) {
        if (index == 1)
        {
            missionPanel1.SetActive(true);
        }
        else if (index == 2)
        {
            missionPanel2.SetActive(true);
        }
        else if (index == 3)
        {
            missionPanel3.SetActive(true);
        }
    }
    public void ExitParent(int index) {

        if (index==1)
        {
            missionPanel1.SetActive(false);
        }
        else if (index == 2)
        {
            missionPanel2.SetActive(false);
        }
        else if (index == 3)
        {
            missionPanel3.SetActive(false);
        }

    }
}
