using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LightMachineGuns : MonoBehaviour
{
    public static LightMachineGuns lightmachineguns;

    public bool LMGToggle;
    public GameObject LMGPanel;

    private string LMGPanelPath;

    public Button LMGButtons;
    private string LMGButtonPath;

    public void LMGControls()
    {
        LMGToggle = !LMGToggle;

        if (LMGToggle == true)
        {

        }
        else if (LMGToggle == false)
        {

        }
    }     
}
