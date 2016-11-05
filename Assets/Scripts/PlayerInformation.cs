using UnityEngine;
using System.Collections;

public class PlayerInformation : MonoBehaviour
{
    public string PlayerName = "Player";
    public int PlayerID;
    private string UserName;
    private GameObject Player;

	void OnEnable ()
	{
	    if(PlayerID != null)
	    {
	        PlayerID = Random.Range(1, 999);
        }

        UserName = PlayerName + PlayerID;
	}
}
