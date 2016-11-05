using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Crafting : MonoBehaviour
{
	//Hello
	public static Crafting crafting;
	
    public bool CraftingToggle;
    public GameObject CraftingPanel;
    private string CraftingPath = "_Inventory/_Background/_Crafting Panel";

    public Button CraftingButton;
	private string CraftingButtonPath = "_Inventory/_Background/_Main Bar/_Player Crafting";


	void Awake ()
	{
		crafting = this.GetComponent<Crafting>();
		
	    CraftingPanel = GameObject.Find(CraftingPath);
	    CraftingButton = GameObject.Find(CraftingButtonPath).GetComponent<Button>();
		CraftingButton.onClick.AddListener(() => CraftingControls());
	}
	
    public void CraftingControls ()
    {
        CraftingToggle = !CraftingToggle;

        if(CraftingToggle == true)
        {
            CraftingPanel.SetActive(true);
	        
	    	//Inventory 
	        Inventory.inventory.InventoryToggle = false;
	        Inventory.inventory.InventoryPanel.SetActive(false);
	        
	        //Weapons
	        WeaponsInventory.weaponsInventory.WeaponsInventoryToggle = false;
	        WeaponsInventory.weaponsInventory.WeaponsInventoryPanel.SetActive(false);
	        
	        //Foods 
	        FoodsInventory.foodsInventory.FoodsInventoryToggle = false;
	        FoodsInventory.foodsInventory.FoodsInventoryPanel.SetActive(false);
	        FoodsInventory.foodsInventory.FoodsSubBar.SetActive(false);
	        
	        //Apparel 
	        ApparelInventory.apparelInventory.ApparelInventoryToggle = false;
	        ApparelInventory.apparelInventory.ApparelInventoryPanel.SetActive(false);
	        ApparelInventory.apparelInventory.ApparelSubBar.SetActive(false);
	        
	        //Player Customization 
	        PlayerCustomization.playercustomization.PCToggle = false;
	        PlayerCustomization.playercustomization.PCPanel.SetActive(false);
        }

        else if (CraftingToggle == false)
        {
	
        }
    }
}
