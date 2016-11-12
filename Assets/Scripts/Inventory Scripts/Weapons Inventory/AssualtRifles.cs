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
        assualtrifles = this.GetComponent<AssualtRifles>();

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
            OnAssaultRifleToggle(true);

            //Weapons Inventory
            WeaponsInventory.weaponsInventory.OnWeaponsToggle(false);
        }

        else if (ARToggle == false)
        {

        }
    }

    public void OnAssaultRifleToggle(bool Toggle)
    {
        ARPanel.SetActive(Toggle);
        ARToggle = Toggle;
    }
}
