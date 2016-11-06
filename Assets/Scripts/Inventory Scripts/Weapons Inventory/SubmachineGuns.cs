using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SubmachineGuns : MonoBehaviour
{
    public static SubmachineGuns submachineguns;

    public bool SMGToggle;
    public GameObject SMGPanel;
    private string SMGPath = "_Inventory/_Background/_Submachine Panel";

    private Button SMGButton;
    private string SMGButtonPath = "_Inventory/_Background/_Weapons SubBar/_Submachine Guns";

    void Awake()
    {
        submachineguns = this.GetComponent<SubmachineGuns>();

        SMGPanel = GameObject.Find(SMGPath);
	    SMGButton = GameObject.Find(SMGButtonPath).GetComponent<Button>();
	    SMGButton.onClick.AddListener(() => SMGControls());
    }

    void Update() { }

    public void SMGControls()
    {
        SMGToggle = !SMGToggle;

        if (SMGToggle == true)
        {
            OnSMGToggle(true);

            //Weapons Inventory
            WeaponsInventory.weaponsInventory.OnWeaponsToggle(false);
        }
        else if (SMGToggle == false)
        {
            SMGPanel.SetActive(false);
        }
    }

    public void OnSMGToggle(bool Toggle)
    {
        SMGPanel.SetActive(Toggle);
        SMGToggle = Toggle;
    }
}
