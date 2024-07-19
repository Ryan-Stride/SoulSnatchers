using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartyLeaderSelection : MonoBehaviour
{
    public GameObject partyLeader1;
    public GameObject partyLeader2;
    public GameObject partyLeader3;
    public GameObject partyLeader4;
    public GameObject partyLeader5;
    public GameObject partyLeader6;

    public GameObject partyLeader1Selected;
    public GameObject partyLeader2Selected;
    public GameObject partyLeader3Selected;
    public GameObject partyLeader4Selected;
    public GameObject partyLeader5Selected;
    public GameObject partyLeader6Selected;

    void Start()
    {
        Debug.Log("PartyLeaderSelection script initialized");

        // Add listeners for each party leader
        partyLeader1.GetComponent<Button>().onClick.AddListener(() => SelectPartyLeader(1));
        partyLeader2.GetComponent<Button>().onClick.AddListener(() => SelectPartyLeader(2));
        partyLeader3.GetComponent<Button>().onClick.AddListener(() => SelectPartyLeader(3));
        partyLeader4.GetComponent<Button>().onClick.AddListener(() => SelectPartyLeader(4));
        partyLeader5.GetComponent<Button>().onClick.AddListener(() => SelectPartyLeader(5));
        partyLeader6.GetComponent<Button>().onClick.AddListener(() => SelectPartyLeader(6));
    }

    public void SelectPartyLeader(int leaderNumber)
    {
        Debug.Log("SelectPartyLeader method called with leader number: " + leaderNumber);
        // Deselect all leaders
        DeselectAllLeaders();

        // Select the chosen leader
        switch (leaderNumber)
        {
            case 1:
                partyLeader1Selected.SetActive(true);
                Debug.Log("Party Leader 1 selected");
                break;
            case 2:
                partyLeader2Selected.SetActive(true);
                Debug.Log("Party Leader 2 selected");
                break;
            case 3:
                partyLeader3Selected.SetActive(true);
                Debug.Log("Party Leader 3 selected");
                break;
            case 4:
                partyLeader4Selected.SetActive(true);
                Debug.Log("Party Leader 4 selected");
                break;
            case 5:
                partyLeader5Selected.SetActive(true);
                Debug.Log("Party Leader 5 selected");
                break;
            case 6:
                partyLeader6Selected.SetActive(true);
                Debug.Log("Party Leader 6 selected");
                break;
        }
    }

    void DeselectAllLeaders()
    {
        partyLeader1Selected.SetActive(false);
        partyLeader2Selected.SetActive(false);
        partyLeader3Selected.SetActive(false);
        partyLeader4Selected.SetActive(false);
        partyLeader5Selected.SetActive(false);
        partyLeader6Selected.SetActive(false);
    }
}