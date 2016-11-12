using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Crafting : MonoBehaviour
{
    public static Crafting crafting;

    public bool CraftingToggle;
    public GameObject CraftingPanel;
    private string CraftingPath = "_Inventory/_Background/_Crafting Panel";

    public Button CraftingButton;
    private string CraftingButtonPath = "_Inventory/_Background/_Main Bar/_Player Crafting";

    public GameObject CraftingSubBar;
    private string CraftingSBPath;


    void Awake()
    {
        crafting = this.GetComponent<Crafting>();

        CraftingPanel = GameObject.Find(CraftingPath);
        CraftingButton = GameObject.Find(CraftingButtonPath).GetComponent<Button>();
        CraftingButton.onClick.AddListener(() => CraftingControls());
    }

    public void CraftingControls()
    {
        CraftingToggle = !CraftingToggle;

        if (CraftingToggle == true)
        {
            CraftingPanel.SetActive(true);
            CraftingToggle = true;

            //Inventory 
            Inventory.inventory.OnInventoryToggle(false);

            //Weapons
            WeaponsInventory.weaponsInventory.OnWeaponsToggle(false);

            //Foods 
            FoodsInventory.foodsInventory.OnFoodToggle(false);

            //Apparel 
            ApparelInventory.apparelInventory.OnApparelToggle(false);

            //Player Customization 
            PlayerCustomization.playercustomization.OnPlayerCustomizationToggle(false);

            //Weapons
            Pistols.pistols.OnPistolsToggle(false); //Pistols
            AssualtRifles.assualtrifles.OnAssaultRifleToggle(false);    //Assault Rifles
            SubmachineGuns.submachineguns.OnSMGToggle(false);   //Submachine Guns
            LightMachineGuns.lightmachineguns.OnLMGToggle(false);   //Lightmachine Guns
        }

        else if (CraftingToggle == false)
        {

        }
    }

    void Update() { }

    public void OnCraftingToggle(bool Toggle)
    {
        CraftingPanel.SetActive(Toggle);
        CraftingToggle = Toggle;
    }
}
