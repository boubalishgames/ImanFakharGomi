using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SubmachineGuns : MonoBehaviour
{
    public bool SMGToggle;
    public GameObject SMGPanel;
    private string SMGPath = "_Inventory/_Background/_Submachine Panel";

    private Button SMGButton;
    private string SMGButtonPath = "_Inventory/_Background/_Weapons Panel/_Submachine Guns";

    //SMG Back Button 
    private bool SMGBackToggle;
    private Button SMGBackButton;
    private string SMGBackPath = "_Inventory/_Background/_Submachine Panel/_Back";

	//SMG Back To Inventory
	private bool SMGBackToInventoryToggle;
	private Button SMGBackToInventoryButton;
	private string SMGBackToInventoryPath = "_Inventory/_Background/_Submachine Panel/_Back To Inventory";


    //Weapons Inventory
    private WeaponsInventory weaponsInventory;
	private Inventory inventory;

    void Awake()
    {
		inventory = GetComponent<Inventory> ();
        weaponsInventory = GetComponent<WeaponsInventory>();

        SMGPanel = GameObject.Find(SMGPath);
	    //SMGButton = GameObject.Find(SMGButtonPath).GetComponent<Button>();
	    // SMGButton.onClick.AddListener(() => SMGControls());

        //SMG Back Button
        //SMGBackButton = GameObject.Find(SMGBackPath).GetComponent<Button>();
        //SMGBackButton.onClick.AddListener(() => SMGBackControls());

		//SMG Back To Inventory
		//SMGBackToInventoryButton = GameObject.Find(SMGBackToInventoryPath).GetComponent<Button>();
		//SMGBackToInventoryButton.onClick.AddListener(() => SMGBackToInventory());
    }

    void Update() { }

    public void SMGControls()
    {
        SMGToggle = !SMGToggle;

        if (SMGToggle == true)
        {
            SMGPanel.SetActive(true);

            //Weapons Inventory
            weaponsInventory.WeaponsInventoryToggle = false;
            weaponsInventory.WeaponsInventoryPanel.SetActive(false);
        }
        else if (SMGToggle == false)
        {
            SMGPanel.SetActive(false);
        }
    }

    public void SMGBackControls()
    {
        SMGBackToggle = !SMGBackToggle;

        if (SMGBackToggle == true)
        {
            //SMG
            SMGPanel.SetActive(false);
            SMGToggle = false;

            //Weapons Inventory
            weaponsInventory.WeaponsInventoryToggle = true;
            weaponsInventory.WeaponsInventoryPanel.SetActive(true);

            SMGBackToggle = false;
        }
    }

	public void SMGBackToInventory ()
	{
		SMGBackToInventoryToggle = !SMGBackToInventoryToggle;

		if (SMGBackToInventoryToggle == true)
		{
			//SMG
			SMGPanel.SetActive(false);
			SMGToggle = false;

			//Inventory
			inventory.InventoryToggle = true;
			inventory.InventoryPanel.SetActive (true);

			SMGBackToInventoryToggle = false;
		}
	}
}
