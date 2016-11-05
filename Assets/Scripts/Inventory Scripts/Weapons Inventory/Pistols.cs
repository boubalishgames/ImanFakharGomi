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
    private string PistolsButtonPath = "_Inventory/_Background/_Weapons Panel/_Pistols";

    //Pistols Back Button
    public bool PistolBackToggle;
    private Button PistolsBackButton;
    private string PistolsBackButtonPath = "_Inventory/_Background/_Pistols Panel/_Back";

    //Pistols Back To Inventory Button
    private bool PistolsBackInventoryToggle;
    private Button PistolsBackInventoryButton;
    private string PistolsBackInventoryPath = "_Inventory/_Background/_Pistols Panel/_Back To Inventory";

	void Awake ()
	{
        //Pistols Panel
	    PistolsPanel = GameObject.Find(PistolsPanelPath);
	    //Pistols Button
		//PistolsButton = GameObject.Find(PistolsButtonPath).GetComponent<Button>();
		//PistolsButton.onClick.AddListener(() => PistolsControls());

        //Pistols Back Button
	    //PistolsBackButton = GameObject.Find(PistolsBackButtonPath).GetComponent<Button>();
	   // PistolsBackButton.onClick.AddListener(() => PistolsBack());

	    //Pistols Back To Inventory
	  //  PistolsBackInventoryButton = GameObject.Find(PistolsBackInventoryPath).GetComponent<Button>();
	  //  PistolsBackInventoryButton.onClick.AddListener(() => PistolsBTIN());
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
            PistolsPanel.SetActive(false);
        }
	}

	public void PistolsBack ()
	{
	    PistolBackToggle = !PistolBackToggle;

        if(PistolBackToggle == true)
        {
            //Pistols
            PistolsPanel.SetActive(false);
            PistolsToggle = false;

            //Weapons Inventory
            WeaponsInventory.weaponsInventory.WeaponsInventoryToggle = true;
            WeaponsInventory.weaponsInventory.WeaponsInventoryPanel.SetActive(true);

            PistolBackToggle = false;
        }
	}

	//Back To Inventory Button
	public void PistolsBTIN ()
	{
	    PistolsBackInventoryToggle = !PistolsBackInventoryToggle;

        if(PistolsBackInventoryToggle == true)
        {
            //Pistols
            PistolsPanel.SetActive(false);
            PistolsToggle = false;

            //Inventory
            Inventory.inventory.InventoryToggle = true;
            Inventory.inventory.InventoryPanel.SetActive(true);

            PistolsBackInventoryToggle = false;
        }
	}
}
