using UnityEngine;
using System.Collections;

public class PlayerInformation : MonoBehaviour
{
    public static PlayerInformation playerinformation;

    public string PlayerName = "Player";
    public int PlayerID;
    public string UserName;

    public GameObject Inventory;


	void OnEnable ()
	{
       playerinformation = GetComponent<PlayerInformation>();

        if (PlayerID != null)
	    {
	        PlayerID = Random.Range(1, 999);
        }

        UserName = PlayerName + PlayerID;
	}
}
