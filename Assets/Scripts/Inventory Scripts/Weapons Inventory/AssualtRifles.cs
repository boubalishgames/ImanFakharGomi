using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AssualtRifles : MonoBehaviour
{
    public bool ARToggle;
    public GameObject ARPanel;
    private string ARPanelPath = "_Inventory/_Background/_Assault Panel";

    private Button ARButton;
    private string ARButtonPath = "_Inventory/_Background/_Weapons Panel/_Assault Rifles";

    //AR Back Button
    private bool ARBackToggle;
    private Button ARBackButton;
    private string ARBackPath = "_Inventory/_Background/_Assault Panel/_Back";

    //AR Back To Inventory
    private bool ARBackToInventoryToggle;
    private Button ARBackToInventoryButton;
    private string ARBackToInventoryPath = "_Inventory/_Background/_Assault Panel/_Back To Inventory";

	private Inventory inventory;
    private WeaponsInventory weaponsInventory;

    void Awake()
    {
		inventory = GetComponent<Inventory> ();
        weaponsInventory = GetComponent<WeaponsInventory>();

	    //ARPanel = GameObject.Find(ARPanelPath);
	    //ARButton = GameObject.Find(ARButtonPath).GetComponent<Button>();
	    //ARButton.onClick.AddListener(() => ARControls());

        //AR Back Button
       // ARBackButton = GameObject.Find(ARBackPath).GetComponent<Button>();
       // ARBackButton.onClick.AddListener(() => ARBack());

        //AR Back To Inventory
        //ARBackToInventoryButton = GameObject.Find(ARBackToInventoryPath).GetComponent<Button>();
       // ARBackToInventoryButton.onClick.AddListener(() => ARBack());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ARControls()
    {
        ARToggle = !ARToggle;

        if (ARToggle == true)
        {
            ARPanel.SetActive(true);

            //Weapons Inventory
            weaponsInventory.WeaponsInventoryToggle = false;
            weaponsInventory.WeaponsInventoryPanel.SetActive(false);
        }

        else if (ARToggle == false)
        {
            ARPanel.SetActive(false);
        }
    }

    public void ARBack()
    {
        ARBackToggle = !ARBackToggle;

        if (ARBackToggle == true)
        {
            ARPanel.SetActive(false);
            ARToggle = false;

            //Weapons Inventory
            weaponsInventory.WeaponsInventoryToggle = true;
            weaponsInventory.WeaponsInventoryPanel.SetActive(true);

            ARBackToggle = false;
        }
    }

    public void ARBackToInventory()
    {
        ARBackToInventoryToggle = !ARBackToInventoryToggle;

        if (ARBackToInventoryToggle == true)
        {
            ARPanel.SetActive(false);
            ARToggle = false;

			inventory.InventoryToggle = true;
			inventory.InventoryPanel.SetActive (true);


            ARBackToInventoryToggle = false;
        }
    }

}
