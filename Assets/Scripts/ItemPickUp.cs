using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemPickUp : MonoBehaviour
{
    [SerializeField]
    public ItemsDatabase[] PlayerItems = new ItemsDatabase[20];

    public static ItemPickUp itempickup;

    public Text ItemText;
    public GameObject ItemPanel;

    void Awake()
    {
        ItemText = GameObject.Find("Item UI/Text").GetComponent<Text>();
        ItemPanel = GameObject.Find("Item UI");
        itempickup = this.GetComponent<ItemPickUp>();
    }

    void OnEnable()
    {
        PlayerItems[0].Name = "Health Pack";
        PlayerItems[0].TagName = "Health Pack";
    }

    IEnumerator ShowMessage(string message, float delay)
    {
        ItemText.text = message;
        ItemText.enabled = true;
        yield return new WaitForSeconds(delay);
        ItemText.enabled = false;
    }


    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 4))
        {
            for (int i = 0; i < 20; i++)
            {
                if (hit.collider.tag == PlayerItems[i].TagName)
                {
                    ItemText.text = "Press [F] to Pick Up Item";
                    ItemText.enabled = true;
                }
            }

            if (Input.GetButtonDown("Interactions"))
            {
                for (int i = 0; i < 20; i++)
                {
                    if (hit.collider.tag == PlayerItems[i].TagName)
                    {
                        Destroy(hit.collider.gameObject);
                        PlayerItems[i].ItemsCounter++;

                        StartCoroutine(ShowMessage("You have found " + PlayerItems[i].Name + " " + "[" + PlayerItems[i].ItemsCounter + "]", 1.5f));
                    }
                }
            }
        }

        else
        {
            ItemText.enabled = false;
        }
    }
}
