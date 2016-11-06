using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Inventory : MonoBehaviour
{
    //Inventory
    public static Inventory inventory;

    //Inventory Background 
    public bool InventoryBackgroundToggle;
    [HideInInspector]
    public GameObject InventoryBackgroundPanel;
    private string InventoryBackgroundPath = "_Inventory/_Background";

    public bool InventoryToggle;
    [HideInInspector]
    public GameObject InventoryPanel;

    [HideInInspector]
    public Button InventoryButton;
    private string InventoryButtonPath = "_Inventory/_Background/_Main Bar/_Inventory";

    [HideInInspector]
    public bool DisableInventory;

    private string InventoryPanelPath = "_Inventory/_Background/_Inventory Panel";

    public GameObject InventorySubBar;
    private string InventorySBPath = "_Inventory/_Background/_Inventory SubBar";

    private MouseLook MouseX;
    private MouseLook MouseY;
    private string MouseYPath = "_Player/_Main Camera";

    public void Awake()
    {
        //Inventory
        inventory = this.GetComponent<Inventory>();

        InventoryButton = GameObject.Find(InventoryButtonPath).GetComponent<Button>();
        InventoryButton.onClick.AddListener(InventoryControl);
        InventorySubBar = GameObject.Find(InventorySBPath);

        //Mouse Look X
        MouseX = GetComponent<MouseLook>();
        //Mouse Look Y
        MouseY = GameObject.Find(MouseYPath).GetComponent<MouseLook>();

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Start()
    {
        //Inventory
        InventoryBackgroundPanel = GameObject.Find(InventoryBackgroundPath);
        InventoryPanel = GameObject.Find(InventoryPanelPath);
        InventoryBackgroundPanel.SetActive(false);
    }

    public void Update()
    {
        if (DisableInventory == false)
        {
            InventoryBackgroundControl();
        }
    }

    //Controls The Inventory Panel
    public void InventoryControl()
    {
        InventoryToggle = !InventoryToggle;

        if (InventoryToggle == true)
        {
            //Inventory
            InventoryToggle = true;
            InventoryPanel.SetActive(true);
            InventorySubBar.SetActive(true);

            //Weapons 
            WeaponsInventory.weaponsInventory.OnWeaponsToggle(false);

            //Foods 
            FoodsInventory.foodsInventory.OnFoodToggle(false);

            //Apparel
            ApparelInventory.apparelInventory.OnApparelToggle(false);

            //Player Customizations 
            PlayerCustomization.playercustomization.PCToggle = false;
            PlayerCustomization.playercustomization.PCPanel.SetActive(false);
        }

        //Don't allow the Inventory Panel to get disabled.

        else if (InventoryToggle == false)
        {
            InventorySubBar.SetActive(false);
        } 
    }

    public void InventoryBackgroundControl()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            InventoryBackgroundToggle = !InventoryBackgroundToggle;

            if (InventoryBackgroundToggle == true)
            {
                //Inventory Background
                InventoryBackgroundPanel.SetActive(true);
                PauseMenu.pauseMenu.DisablePauseMenu = true;

                PlayerMovement.playermovement.walkSpeed = 0;
                PlayerMovement.playermovement.runSpeed = 0;
                PlayerMovement.playermovement.jumpSpeed = 0;

                MouseX.enabled = false;
                MouseY.enabled = false;

                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }

            else if (InventoryBackgroundToggle == false)
            {
                InventoryBackgroundPanel.SetActive(false);
                PauseMenu.pauseMenu.DisablePauseMenu = false;

                PlayerMovement.playermovement.walkSpeed = 6.0f;
                PlayerMovement.playermovement.runSpeed = 11.0f;
                PlayerMovement.playermovement.jumpSpeed = 8.0f;


                MouseX.enabled = true;
                MouseY.enabled = true;

                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }

    public void OnInventoryToggle(bool Toggle)
    {
        InventoryToggle = Toggle;
        InventoryPanel.SetActive(Toggle);
        InventorySubBar.SetActive(Toggle);
    }
}