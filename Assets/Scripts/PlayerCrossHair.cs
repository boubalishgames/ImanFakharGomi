using UnityEngine;
using System.Collections;

public class PlayerCrossHair : MonoBehaviour
{
    public static PlayerCrossHair playercrosshair;

    //Default = crosshair[0]
    public GameObject[] Crosshair = new GameObject[20];
    public string[] CrosshairPath = new string[20];

	void Start ()
    {
        playercrosshair = this.GetComponent<PlayerCrossHair>();

        //Default Crosshair
        CrosshairPath[0] = "_Cross Hair/Default";

        Crosshair[0] = GameObject.Find(CrosshairPath[0]);

    }

    void Update()
    {
        DefaultCrosshair();
    }

	void DefaultCrosshair  ()
    {
        if (Inventory.inventory.InventoryBackgroundToggle == true)
        {
            Crosshair[0].SetActive(false);
        }
        else if (Inventory.inventory.InventoryBackgroundToggle == false)
        {
            Crosshair[0].SetActive(true);
        }

    }
}
