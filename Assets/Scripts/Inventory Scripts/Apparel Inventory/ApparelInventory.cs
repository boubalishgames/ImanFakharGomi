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
            Inventory.inventory.OnInventoryToggle(false);

            //Weapons Inventory 
            WeaponsInventory.weaponsInventory.OnWeaponsToggle(false);

            //Food Inventory
            FoodsInventory.foodsInventory.OnFoodToggle(false);

            //Apparel Inventory
            OnApparelToggle(true);

            //Player Customizations 
            PlayerCustomization.playercustomization.OnPlayerCustomizationToggle(false);

            //Weapons
            Pistols.pistols.OnPistolsToggle(false);
            AssualtRifles.assualtrifles.OnAssaultRifleToggle(false);
            SubmachineGuns.submachineguns.OnSMGToggle(false);
        }

        else if (ApparelInventoryToggle == false)
        {
            ApparelSubBar.SetActive(false);
        }
    }

    public void OnApparelToggle(bool Toggle)
    {
        ApparelInventoryPanel.SetActive(Toggle);
        ApparelInventoryToggle = (Toggle);
        ApparelSubBar.SetActive(Toggle);
    }
}
