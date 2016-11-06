using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AssualtRifles : MonoBehaviour
{
    public static AssualtRifles assualtrifles;

    public bool ARToggle;
    public GameObject ARPanel;
    private string ARPanelPath = "_Inventory/_Background/_Assault Panel";

    private Button ARButton;
    private string ARButtonPath = "_Inventory/_Background/_Weapons SubBar/_Assault Rifles";

    void Awake()
    {
	    ARPanel = GameObject.Find(ARPanelPath);
	    ARButton = GameObject.Find(ARButtonPath).GetComponent<Button>();
	    ARButton.onClick.AddListener(() => ARControls());
    }

    void Update(){ }

    public void ARControls()
    {
        ARToggle = !ARToggle;

        if (ARToggle == true)
        {
            ARPanel.SetActive(true);
            ARToggle = true;

            //Weapons Inventory
            WeaponsInventory.weaponsInventory.WeaponsInventoryToggle = false;
            WeaponsInventory.weaponsInventory.WeaponsInventoryPanel.SetActive(false);

            //Pistols
            Pistols.pistols.OnPistolsToggle(false);
        }

        else if (ARToggle == false)
        {
            ARPanel.SetActive(false);
        }
    }

    public void OnAssaultRifleToggle(bool Toggle)
    {
        ARPanel.SetActive(Toggle);
        ARToggle = Toggle;
    }
}
