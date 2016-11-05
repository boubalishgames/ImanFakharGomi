using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ApparelInventory : MonoBehaviour
{
    public static ApparelInventory apparelInventory;

    public bool ApparelInventoryToggle;
    public GameObject ApparelInventoryPanel;
    private string ApparelInventoryPanelPath = "_Inventory/_Background/_Apparel Panel";

    //Apparel SubBar
    public GameObject ApparelSubBar;
    private string ApparelSBPath = "_Inventory/_Background/_Apparels SubBar";

    //Apparel Button
    private Button ApparelButton;
    private string ApparelButtonPath = "_Inventory/_Background/_Main Bar/_Apparel Inventory";

	void Awake ()
    {
        apparelInventory = this.GetComponent<ApparelInventory>();
        ApparelSubBar = GameObject.Find(ApparelSBPath);

        ApparelInventoryPanel = GameObject.Find(ApparelInventoryPanelPath);
        ApparelButton = GameObject.Find(ApparelButtonPath).GetComponent<Button>();
        ApparelButton.onClick.AddListener(() => ApparelControls());

        ApparelInventoryPanel.SetActive(false);

    }

    void Start ()
    {

    }
    public void ApparelControls()
    {
        ApparelInventoryToggle = !ApparelInventoryToggle;

        if(ApparelInventoryToggle == true)
        {
            //Inventory
            Inventory.inventory.InventoryPanel.SetActive(false);
            Inventory.inventory.InventoryToggle = false;
            Inventory.inventory.InventorySubBar.SetActive(false);

            //Weapons Inventory 
            WeaponsInventory.weaponsInventory.WeaponsInventoryPanel.SetActive(false);
            WeaponsInventory.weaponsInventory.WeaponsInventoryToggle = false;
            WeaponsInventory.weaponsInventory.WeaponsSubBar.SetActive(false);

            //Food Inventory
            FoodsInventory.foodsInventory.FoodsInventoryPanel.SetActive(false);
            FoodsInventory.foodsInventory.FoodsInventoryToggle = false;
            FoodsInventory.foodsInventory.FoodsSubBar.SetActive(false);

            //Apparel Inventory
            ApparelInventoryPanel.SetActive(true);
            ApparelInventoryToggle = true;
	        ApparelSubBar.SetActive(true);
	        
	        //Player Customizations 
	        PlayerCustomization.playercustomization.PCToggle = false;
	        PlayerCustomization.playercustomization.PCPanel.SetActive(false);
	        
        }

        else if (ApparelInventoryToggle == false)
        {
            ApparelSubBar.SetActive(false);
        }
    }

    public void ApparelControlsButton()
    {
        ApparelInventoryToggle = !ApparelInventoryToggle;

        if (ApparelInventoryToggle == true)
        {
            ApparelInventoryPanel.SetActive(true);
        }

        else if (ApparelInventoryToggle == false)
        {
            ApparelInventoryPanel.SetActive(false);
        }
    }
}
