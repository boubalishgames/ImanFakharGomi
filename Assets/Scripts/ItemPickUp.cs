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

    public LayerMask layerMasks;

    void Awake()
    {
        ItemText = GameObject.Find("Item UI/_Text").GetComponent<Text>();
        ItemPanel = GameObject.Find("Item UI");
        itempickup = this.GetComponent<ItemPickUp>();
    }

    void OnEnable()
    {
        //Tier One Med Pack 
        PlayerItems[0].Name = "Med Pack Tier One";
        PlayerItems[0].TagName = "Med Pack Tier One";

        //Tier Two Med Pack
        PlayerItems[1].Name = "Med Pack Tier Two";
        PlayerItems[1].TagName = "Med Pack Tier Two";

        //Tier Three Med Pack
        PlayerItems[2].Name = "Med Pack Tier Three";
        PlayerItems[2].TagName = "Med Pack Tier Three";

        //Tier Four Med Pack
        PlayerItems[3].Name = "Med Pack Tier Four";
        PlayerItems[3].TagName = "Med Pack Tier Four";

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

        if (Physics.Raycast(ray, out hit, 4, layerMasks))
        {
            for (int i = 0; i < 20; i++)
            {
                if (hit.collider.tag == PlayerItems[i].TagName)
                {
                    ItemText.text = "Press [ F ] to Pick up " + PlayerItems[i].Name;
                    ItemText.enabled = true;
                    i = 0;
                    break;
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
                        i = 0;

                        StartCoroutine(ShowMessage("You have found " + PlayerItems[i].Name + " " + "[" + PlayerItems[i].ItemsCounter + "]", 1.5f));

                        break;
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
