using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pistols : MonoBehaviour
{
    //Pistols Panel
    public bool PistolsToggle;
    public GameObject PistolsPanel;

    private string PistolsPanelPath = "_Inventory/_Background/_Pistols Panel";

    //Pistols Button
    private Button PistolsButton;
    private string PistolsButtonPath = "_Inventory/_Background/_Weapons SubBar/_Pistols";


	void Awake ()
	{
        //Pistols Panel
	    PistolsPanel = GameObject.Find(PistolsPanelPath);

	    //Pistols Button
		PistolsButton = GameObject.Find(PistolsButtonPath).GetComponent<Button>();
		PistolsButton.onClick.AddListener(() => PistolsControls());
	}

    void Update() { }

	public void PistolsControls ()
	{
        PistolsToggle = !PistolsToggle;

        if(PistolsToggle == true)
        {
            PistolsPanel.SetActive(true);

            //Weapons Inventory
            WeaponsInventory.weaponsInventory.WeaponsInventoryToggle = false;
            WeaponsInventory.weaponsInventory.WeaponsInventoryPanel.SetActive(false);

        }

        else if(PistolsToggle == false)
        {

        }
	}
}
