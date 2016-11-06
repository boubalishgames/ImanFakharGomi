using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FoodsInventory : MonoBehaviour
{
    public static FoodsInventory foodsInventory;

    public bool FoodsInventoryToggle;
    public GameObject FoodsInventoryPanel;
    private string FoodsInventoryPanelPath = "_Inventory/_Background/_Foods Panel";

    //Food Inventory
    private Button foodsInventoryButton;
    private string foodsInventoryButtonPath = "_Inventory/_Background/_Main Bar/_Foods Inventory";

    //Food Inventory SubBar
    public GameObject FoodsSubBar;
    private string FoodsSBPath = "_Inventory/_Background/_Foods SubBar";

    void Awake()
    {
        foodsInventory = this.GetComponent<FoodsInventory>();

        //Foods Inventory
        FoodsInventoryPanel = GameObject.Find(FoodsInventoryPanelPath);
        FoodsInventoryPanel.SetActive(false);
        FoodsSubBar = GameObject.Find(FoodsSBPath);

        //Food Inventory
        foodsInventoryButton = GameObject.Find(foodsInventoryButtonPath).GetComponent<Button>();
        foodsInventoryButton.onClick.AddListener(() => FoodsControlsButton());
    }

    void Update() { }

    public void FoodsControl()
    {
        FoodsInventoryToggle = !FoodsInventoryToggle;

        if (FoodsInventoryToggle == true)
        {
            FoodsInventoryPanel.SetActive(true);
        }

        else if (FoodsInventoryToggle == false)
        {
            FoodsInventoryPanel.SetActive(false);
        }
    }

    public void FoodsControlsButton()
    {
        FoodsInventoryToggle = !FoodsInventoryToggle;

        if (FoodsInventoryToggle == true)
        {
            //Inventory
            Inventory.inventory.InventoryPanel.SetActive(false);
            Inventory.inventory.InventoryToggle = false;
            Inventory.inventory.InventorySubBar.SetActive(false);

            //Weapons Inventory 
            WeaponsInventory.weaponsInventory.OnWeaponsToggle(false);

            //Food Inventory
            FoodsInventoryPanel.SetActive(true);
            FoodsInventoryToggle = true;
            FoodsSubBar.SetActive(true);

            //Apparel Inventory
            ApparelInventory.apparelInventory.ApparelInventoryPanel.SetActive(false);
            ApparelInventory.apparelInventory.ApparelInventoryToggle = false;
	        ApparelInventory.apparelInventory.ApparelSubBar.SetActive(false);
	        
	        //Player Customizations 
	        PlayerCustomization.playercustomization.PCToggle = false;
	        PlayerCustomization.playercustomization.PCPanel.SetActive(false);
        }

        else if (FoodsInventoryToggle == false)
        {
            FoodsSubBar.SetActive(false);
        }
    }

    public void OnFoodToggle(bool Toggle)
    {
        FoodsInventoryPanel.SetActive(Toggle);
        FoodsInventoryToggle = Toggle;
        FoodsSubBar.SetActive(Toggle);
    }
}
