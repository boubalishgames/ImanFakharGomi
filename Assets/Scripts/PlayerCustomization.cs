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

    void Awake ()
    {
        playercustomization = this.GetComponent<PlayerCustomization>();

        PCPanel = GameObject.Find(PCPath);
        PCButton = GameObject.Find(PCButtonPath).GetComponent<Button>();
		PCButton.onClick.AddListener(() => PCControls());

    }

    void Update() { }

    public void PCControls()
    {
        PCToggle = !PCToggle;

        if (PCToggle == true)
        {
            OnPlayerCustomizationToggle(true);
            PCToggle = true;

            //Inventory
            Inventory.inventory.OnInventoryToggle(false);

            //Weapons 
            WeaponsInventory.weaponsInventory.OnWeaponsToggle(false);

            //Foods 
            FoodsInventory.foodsInventory.OnFoodToggle(false);

            //Apparel 
            ApparelInventory.apparelInventory.OnApparelToggle(false);

            //Crafting 
            Crafting.crafting.OnCraftingToggle(false);

        }
	    
        else if (PCToggle == false)
        {
          
        }
    }

    public void OnPlayerCustomizationToggle(bool Toggle)
    {
        PCPanel.SetActive(Toggle);
        PCToggle = Toggle;
    }
}
