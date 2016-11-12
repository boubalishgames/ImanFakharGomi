using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Pistols))]
[RequireComponent(typeof(AssualtRifles))]
[RequireComponent(typeof(SubmachineGuns))]
[RequireComponent(typeof(LightMachineGuns))]

[RequireComponent(typeof(WeaponItemPickUp))]

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
            Inventory.inventory.OnInventoryToggle(false);

            //Weapons Inventory 
            OnWeaponsToggle(true);

            //Food Inventory
            FoodsInventory.foodsInventory.OnFoodToggle(false);

            //Apparel Inventory
            ApparelInventory.apparelInventory.OnApparelToggle(false);

            //Player Customizations 
            PlayerCustomization.playercustomization.OnPlayerCustomizationToggle(false);

            //Weapons
            Pistols.pistols.OnPistolsToggle(false); //Pistols
            AssualtRifles.assualtrifles.OnAssaultRifleToggle(false);    //Assault Rifles
            SubmachineGuns.submachineguns.OnSMGToggle(false);   //Submachine Guns
            LightMachineGuns.lightmachineguns.OnLMGToggle(false);   //Lightmachine Guns
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
