using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseMenu : MonoBehaviour
{
    public bool PauseMenuToggle;
    public GameObject PauseMenuPanel;

    public bool DisablePauseMenu;
    private string PauseMenuPanelPath = "_Pause Menu/_Pause Menu Panel";

    public static PauseMenu pauseMenu;

    //Resume Game
    private Button ResumeGameButton;
    private string ResumeGamePath = "_Pause Menu/_Pause Menu Panel/_Resume Game";

    //Exit Game 
    private GameObject ExitGameButton;
    private Button YesButton;
    private Button NoButton;

    private bool ExitGameToggle;
    private string ExitPanelPath = "_Pause Menu Panel/_Exit Panel";
    private string YesButtonPath;

    //Mouse Look 
    private MouseLook MouseX;
    private MouseLook MouseY;
    private string MouseYPath = "_Player/_Main Camera";

	void Awake ()
	{
	    PauseMenuPanel = GameObject.Find(PauseMenuPanelPath);

        pauseMenu = this.GetComponent<PauseMenu>();

        //Mouse Look X
        MouseX = GetComponent<MouseLook>();

        //Mouse Look Y
        MouseY = GameObject.Find(MouseYPath).GetComponent<MouseLook>();

        //Resume Game
        ResumeGameButton = GameObject.Find(ResumeGamePath).GetComponent<Button>();
        ResumeGameButton.onClick.AddListener(() => ResumeGame());

        PauseMenuPanel.SetActive(false);
	}

	void Update ()
	{
	    if(DisablePauseMenu == false)
	    {
	        PauseMenuControls();
	    }
	}
	
    public void PauseMenuControls ()
    {
        if(Input.GetButtonDown("Pause"))
        {
            PauseMenuToggle = !PauseMenuToggle;

            if(PauseMenuToggle == true)
            {
                PauseMenuPanel.SetActive(true);
                Inventory.inventory.DisableInventory = true;

                PlayerMovement.playermovement.walkSpeed = 0;
                PlayerMovement.playermovement.runSpeed = 0;
                PlayerMovement.playermovement.jumpSpeed = 0;

                MouseX.enabled = false;
                MouseY.enabled = false;

                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }

            else if(PauseMenuToggle == false)
            {
                PauseMenuPanel.SetActive(false);
                Inventory.inventory.DisableInventory = false;

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

    public void ResumeGame()
    {
        PauseMenuToggle = !PauseMenuToggle;

        if (PauseMenuToggle == true)
        {
            PauseMenuPanel.SetActive(true);
            Inventory.inventory.DisableInventory = true;

            PlayerMovement.playermovement.walkSpeed = 0;
            PlayerMovement.playermovement.runSpeed = 0;
            PlayerMovement.playermovement.jumpSpeed = 0;

            MouseX.enabled = false;
            MouseY.enabled = false;

            Cursor.visible = true;
        }

        else if (PauseMenuToggle == false)
        {
            PauseMenuPanel.SetActive(false);
            Inventory.inventory.DisableInventory = false;

            PlayerMovement.playermovement.walkSpeed = 6.0f;
            PlayerMovement.playermovement.runSpeed = 11.0f;
            PlayerMovement.playermovement.jumpSpeed = 8.0f;

            MouseX.enabled = true;
            MouseY.enabled = true;

            Cursor.visible = false;
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
