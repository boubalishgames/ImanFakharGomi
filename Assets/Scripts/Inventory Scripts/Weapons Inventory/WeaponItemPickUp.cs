
using UnityEngine;
using System.Collections;

public class WeaponItemPickUp : MonoBehaviour
{
    [SerializeField]
    WeaponsDatabase[] Pistols = new WeaponsDatabase[20];
    [SerializeField]
    WeaponsDatabase[] AssaultRifles = new WeaponsDatabase[20];

    void Reset()
    {
        #region Pistols
        //USP.45
        Pistols[0].Name = "USP.45";
        Pistols[0].TagName = "USP.45";

        //P99
        Pistols[1].Name = "P99";
        Pistols[1].TagName = "P99";

        //MP421
        Pistols[2].Name = "MP421";
        Pistols[2].TagName = "MP421";

        //44 Magnum
        Pistols[3].Name = "44 Magnum";
        Pistols[3].TagName = "44 Magnum";

        //Five Seven
        Pistols[4].Name = "Five Seven";
        Pistols[4].TagName = "Five Seven";

        //Desert Eagle
        Pistols[5].Name = "Desert Eagle";
        Pistols[5].TagName = "Desert Eagle";

        Pistols[6].Name = "SNS Pistol";
        Pistols[6].Name = "SNS Pistol";

        #endregion

        AssaultRifles[0].Name = "AK47";
        AssaultRifles[0].TagName = "AK47";
    }


    void OnEnable()
    {
        #region Pistols
        //USP.45
        Pistols[0].Name = "USP.45";
        Pistols[0].TagName = "USP.45";
        Pistols[0].ID = "P0";

        //P99
        Pistols[1].Name = "P99";
        Pistols[1].TagName = "P99";

        //MP421
        Pistols[2].Name = "MP421";
        Pistols[2].TagName = "MP421";

        //44 Magnum
        Pistols[3].Name = "44 Magnum";
        Pistols[3].TagName = "44 Magnum";

        //Five Seven
        Pistols[4].Name = "Five Seven";
        Pistols[4].TagName = "Five Seven";

        //Desert Eagle
        Pistols[5].Name = "Desert Eagle";
        Pistols[5].TagName = "Desert Eagle";

        //SNS Pistol
        Pistols[6].Name = "SNS Pistol";
        Pistols[6].TagName = "SNS Pistol";

        #endregion

        #region Assault Rifles 
        AssaultRifles[0].Name = "AK47";
        AssaultRifles[0].TagName = "AK47";
        #endregion
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetButtonDown("Interaction"))
            {
                for (int i = 0; i < 20; i++)
                {
                    if (hit.collider.tag == Pistols[i].TagName && hit.distance < 4)
                    {
                        Destroy(hit.collider.gameObject);
                        Pistols[i].WeaponCounter++;

                        print("You have found " + Pistols[i].Name);
                    }

                    if (hit.collider.tag == AssaultRifles[i].TagName && hit.distance < 4)
                    {
                        Destroy(hit.collider.gameObject);
                        AssaultRifles[i].WeaponCounter++;
                    }
                }
            }
        }
    }
}
