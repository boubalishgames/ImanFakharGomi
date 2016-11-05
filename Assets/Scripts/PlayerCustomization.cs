using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerCustomization : MonoBehaviour
{
    public static PlayerCustomization playercustomization;

    public bool PCToggle;
    public GameObject PCPanel;
    private string PCPath = "_Inventory/_Background/_Player Customization Panel";

    private Button PCButton;
    private string PCButtonPath = "_Inventory/_Background/_Main Bar/_Player Customization";

	//PC Back Button
	private bool PCBackToggle;
	private Button PCBackButton;
	private string PCBackPath = "_Inventory/_Background/_Player Customization Panel/_Back";

    void Awake ()
    {
        playercustomization = this.GetComponent<PlayerCustomization>();

        PCPanel = GameObject.Find(PCPath);
        PCButton = GameObject.Find(PCButtonPath).GetComponent<Button>();
		PCButton.onClick.AddListener(() => PCControls());

		//PC Back Button;
		//PCBackButton = GameObject.Find(PCBackPath).GetComponent<Button>(); 
		//PCBackButton.onClick.AddListener(() => PCBack());
    }

    void Update() { }

    public void PCControls()
    {
        PCToggle = !PCToggle;

        if (PCToggle == true)
        {
            PCPanel.SetActive(true);

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
	           
        }
	    
        else if (PCToggle == false)
        {
          
        }
    }

	public void PCBack ()
	{
		PCBackToggle = !PCBackToggle;

		if (PCBackToggle == true)
		{
			PCPanel.SetActive(false);
			PCToggle = false;
			
			//Inventory
            Inventory.inventory.InventoryToggle = true;
            Inventory.inventory.InventoryPanel.SetActive(true);

			PCBackToggle = false; 
		}
	}
}
