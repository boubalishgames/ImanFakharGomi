using UnityEngine;
using System.Collections;

public class ItemPickUp : MonoBehaviour
{
    [SerializeField] ItemsDatabase[] PlayerItems = new ItemsDatabase[20];

    void OnEnable()
    {
        PlayerItems[0].Name = "Health Pack";
        PlayerItems[0].TagName = "Health Pack";
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            for (int i = 0; i < 20; i++)
            {
                if (hit.collider.tag == PlayerItems[i].TagName && hit.distance < 4)
                {
                    print("Press F");
                }
            }

            if (Input.GetButtonDown("Interactions"))
            {
                for (int i = 0; i < 20; i++)
                {
                    if (hit.collider.tag == PlayerItems[i].TagName && hit.distance < 4)
                    {
                        Destroy(hit.collider.gameObject);
                        PlayerItems[i].ItemsCounter++;

                        print("You have found " + PlayerItems[i].Name);
                    }
                }
            }
        }
    }
}
