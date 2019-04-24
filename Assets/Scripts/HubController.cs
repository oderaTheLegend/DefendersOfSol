using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HubController : MonoBehaviour
{
    public RawImage backGroundImage;
    public Button exitButton;

    public RawImage backGroundArchiveImage;
    public Button exitArchiveButton;

    public RawImage characterSelectionImage;
    public Button exitCharacterButton;

    public GameObject missionPanel1;
    public GameObject missionPanel2;
    public GameObject missionPanel3;

    public GameObject archivePanel1;
    public GameObject archivePanel2;
    public GameObject archivePanel3;

    public GameObject missionButton1;
    public GameObject missionButton2;
    public GameObject missionButton3;

    public GameObject archiveButton1;
    public GameObject archiveButton2;
    public GameObject archiveButton3;

    public GameObject characterSelect1;
    public GameObject characterSelect2;
    public GameObject characterSelect3;

    public GameObject missionClicker;
    public GameObject archiveClicker;

    public void MissionButton()
    {
        backGroundImage.gameObject.SetActive(false);
        exitButton.gameObject.SetActive(false);

        missionButton1.gameObject.SetActive(false);
        missionButton2.gameObject.SetActive(false);
        missionButton3.gameObject.SetActive(false);

        missionClicker.gameObject.SetActive(true);
        archiveClicker.gameObject.SetActive(true);
    }

    public void LoadingMissions()
    {
        backGroundImage.gameObject.SetActive(true);
        exitButton.gameObject.SetActive(true);


        missionButton1.gameObject.SetActive(true);
        missionButton2.gameObject.SetActive(true);
        missionButton3.gameObject.SetActive(true);

    }

    public void Missions(int index)
    {
        if (index == 1)
        {
            missionPanel1.SetActive(true);
            missionButton1.gameObject.SetActive(false);
            missionButton2.gameObject.SetActive(false);
            missionButton3.gameObject.SetActive(false);
            missionClicker.gameObject.SetActive(false);
            archiveClicker.gameObject.SetActive(false);
        }
        else if (index == 2)
        {
            missionPanel2.SetActive(true);
            missionButton1.gameObject.SetActive(false);
            missionButton2.gameObject.SetActive(false);
            missionButton3.gameObject.SetActive(false);
            missionClicker.gameObject.SetActive(false);
            archiveClicker.gameObject.SetActive(false);
        }
        else if (index == 3)
        {
            missionPanel3.SetActive(true);
            missionButton1.gameObject.SetActive(false);
            missionButton2.gameObject.SetActive(false);
            missionButton3.gameObject.SetActive(false);
            missionClicker.gameObject.SetActive(false);
            archiveClicker.gameObject.SetActive(false);
        }
    }



    public void ExitParent(int index)
    {

        if (index == 1)
        {
            missionPanel1.SetActive(false);
            missionButton1.gameObject.SetActive(true);
            missionButton2.gameObject.SetActive(true);
            missionButton3.gameObject.SetActive(true);
        }
        else if (index == 2)
        {
            missionPanel2.SetActive(false);
            missionButton1.gameObject.SetActive(true);
            missionButton2.gameObject.SetActive(true);
            missionButton3.gameObject.SetActive(true);
        }
        else if (index == 3)
        {
            missionPanel3.SetActive(false);
            missionButton1.gameObject.SetActive(true);
            missionButton2.gameObject.SetActive(true);
            missionButton3.gameObject.SetActive(true);
        }

    }

    public void LoadingArchives()
    {
        backGroundArchiveImage.gameObject.SetActive(true);
        exitArchiveButton.gameObject.SetActive(true);

        archiveButton1.gameObject.SetActive(true);
        archiveButton2.gameObject.SetActive(true);
        archiveButton3.gameObject.SetActive(true);
    }

    public void ArchivesButton()
    {
        backGroundArchiveImage.gameObject.SetActive(false);
        exitArchiveButton.gameObject.SetActive(false);

        archiveButton1.gameObject.SetActive(false);
        archiveButton2.gameObject.SetActive(false);
        archiveButton3.gameObject.SetActive(false);

        missionClicker.gameObject.SetActive(true);
        archiveClicker.gameObject.SetActive(true);
    }


    public void Archives(int index)
    {
        if (index == 1)
        {
            archivePanel1.SetActive(true);
            archiveButton1.gameObject.SetActive(false);
            archiveButton2.gameObject.SetActive(false);
            archiveButton3.gameObject.SetActive(false);
            missionClicker.gameObject.SetActive(false);
            archiveClicker.gameObject.SetActive(false);
        }
        else if (index == 2)
        {
            archivePanel2.SetActive(true);
            archiveButton1.gameObject.SetActive(false);
            archiveButton2.gameObject.SetActive(false);
            archiveButton3.gameObject.SetActive(false);
            missionClicker.gameObject.SetActive(false);
            archiveClicker.gameObject.SetActive(false);
        }
        else if (index == 3)
        {
            archivePanel3.SetActive(true);
            archiveButton1.gameObject.SetActive(false);
            archiveButton2.gameObject.SetActive(false);
            archiveButton3.gameObject.SetActive(false);
            missionClicker.gameObject.SetActive(false);
            archiveClicker.gameObject.SetActive(false);
        }
    }
    public void ExitParentArchive(int index)
    {

        if (index == 1)
        {
            archivePanel1.SetActive(false);
            archiveButton1.gameObject.SetActive(true);
            archiveButton2.gameObject.SetActive(true);
            archiveButton3.gameObject.SetActive(true);
        }
        else if (index == 2)
        {
            archivePanel2.SetActive(false);
            archiveButton1.gameObject.SetActive(true);
            archiveButton2.gameObject.SetActive(true);
            archiveButton3.gameObject.SetActive(true);
        }
        else if (index == 3)
        {
            archivePanel3.SetActive(false);
            archiveButton1.gameObject.SetActive(true);
            archiveButton2.gameObject.SetActive(true);
            archiveButton3.gameObject.SetActive(true);
        }

    }

    public void LoadingCharacter()
    {
        characterSelectionImage.gameObject.SetActive(true);
        exitCharacterButton.gameObject.SetActive(true);

        characterSelect1.gameObject.SetActive(true);
        characterSelect2.gameObject.SetActive(true);
        characterSelect3.gameObject.SetActive(true);

        missionClicker.gameObject.SetActive(false);
        archiveClicker.gameObject.SetActive(false);
    }

    public void ExitCharacter()
    {
        characterSelectionImage.gameObject.SetActive(false);
        exitCharacterButton.gameObject.SetActive(false);

        characterSelect1.gameObject.SetActive(false);
        characterSelect2.gameObject.SetActive(false);
        characterSelect3.gameObject.SetActive(false);

        missionClicker.gameObject.SetActive(true);
        archiveClicker.gameObject.SetActive(true);
    }
    public void CharacterSelection(int index)
    {
        if (index == 1)
        {
            Debug.Log("Anne Honoo Selected");
        }
        else if (index == 2)
        {
            Debug.Log("Juno Gabrielle Selected");
        }
        else if (index == 3)
        {
            Debug.Log("Random Guy Selected");
        }
    }
}
