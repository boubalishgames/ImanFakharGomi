using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WeaponsInventory : MonoBehaviour
{
    public static WeaponsInventory weaponsInventory;

    public bool WeaponsInventoryToggle;
    public GameObject WeaponsInventoryPanel;

    private string WeaponsInventoryPanelPath = "_Inventory/_Background/_Weapons Panel";

    private Button weaponsInventoryButton;
    private string weaponsInventoryButtonPath = "_Inventory/_Background/_Main Bar/_Weapons Inventory";

    public GameObject WeaponsSubBar;
    private string WeaponsSBPath = "_Inventory/_Background/_Weapons SubBar";


    void Awake()
    {
        weaponsInventory = this.GetComponent<WeaponsInventory>();

        //Inventory Panel
        weaponsInventoryButton = GameObject.Find(weaponsInventoryButtonPath).GetComponent<Button>();
        weaponsInventoryButton.onClick.AddListener(WeaponsControls);
        WeaponsSubBar = GameObject.Find(WeaponsSBPath);

        //Weapons Inventory Panel
        WeaponsInventoryPanel = GameObject.Find(WeaponsInventoryPanelPath);
        WeaponsInventoryPanel.SetActive(false);

    }

    void Update()
    {
    }

    public void WeaponsControls()
    {
        WeaponsInventoryToggle = !WeaponsInventoryToggle;

        if (WeaponsInventoryToggle == true)
        {
            //Inventory
            Inventory.inventory.InventoryPanel.SetActive(false);
            Inventory.inventory.InventoryToggle = false;
            Inventory.inventory.InventorySubBar.SetActive(false);

            //Weapons Inventory 
            OnWeaponsToggle(true);

            //Food Inventory
            FoodsInventory.foodsInventory.OnFoodToggle(false);

            //Apparel Inventory
            ApparelInventory.apparelInventory.ApparelInventoryPanel.SetActive(false);
            ApparelInventory.apparelInventory.ApparelInventoryToggle = false;
	        ApparelInventory.apparelInventory.ApparelSubBar.SetActive(false);
	        
	    	//Player Customizations 
	        PlayerCustomization.playercustomization.PCToggle = false;
	        PlayerCustomization.playercustomization.PCPanel.SetActive(false);


            //Weapons
            Pistols.pistols.OnPistolsToggle(false);
        }

        else if (WeaponsInventoryToggle == false)
        {
            WeaponsSubBar.SetActive(false);
        }
    }

    public void OnWeaponsToggle(bool Toggle)
    {
        //Weapons Inventory 
        WeaponsInventoryPanel.SetActive(Toggle);
        WeaponsInventoryToggle = Toggle;
        WeaponsSubBar.SetActive(Toggle);
    } 
}
