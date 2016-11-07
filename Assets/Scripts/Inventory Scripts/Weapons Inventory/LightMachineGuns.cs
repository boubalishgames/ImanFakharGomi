using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LightMachineGuns : MonoBehaviour
{
    public static LightMachineGuns lightmachineguns;

    public bool LMGToggle;
    public GameObject LMGPanel;

    private string LMGPanelPath = "_Inventory/_Background/_Lightmachine Guns Panel";

    public Button LMGButtons;
    private string LMGButtonPath = "_Inventory/_Background/_Weapons SubBar/_Lightmachine Guns";

    void OnEnable()
    {
        lightmachineguns = this.GetComponent<LightMachineGuns>();
        LMGPanel = GameObject.Find(LMGPanelPath);
        LMGButtons = GameObject.Find(LMGButtonPath).GetComponent<Button>();
        LMGButtons.onClick.AddListener(LMGControls);
    }

    public void LMGControls()
    {
        LMGToggle = !LMGToggle;

        if (LMGToggle == true)
        {
            LMGPanel.SetActive(true);
            LMGToggle = true;

            WeaponsInventory.weaponsInventory.OnWeaponsToggle(false);
        }
        else if (LMGToggle == false)
        {
            LMGPanel.SetActive(false);
        }
    }

    public void OnLMGToggle(bool Toggle)
    {
        LMGPanel.SetActive(Toggle);
        LMGToggle = Toggle;
    }
}
