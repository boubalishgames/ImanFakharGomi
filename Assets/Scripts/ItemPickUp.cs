using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemPickUp : MonoBehaviour
{
    [SerializeField]
    ItemsDatabase[] PlayerItems = new ItemsDatabase[20];

    public Text ItemText;
    public GameObject ItemPanel;

    void Awake()
    {
        ItemText = GameObject.Find("Item UI/Text").GetComponent<Text>();

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

        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetButtonDown("Interactions"))
            {
                for (int i = 0; i < 20; i++)
                {
                    if (hit.collider.tag == PlayerItems[i].TagName && hit.distance < 4)
                    {
                        Destroy(hit.collider.gameObject);
                        PlayerItems[i].ItemsCounter++;

                        StartCoroutine(ShowMessage("You have found " + PlayerItems[i].Name + " " + "[" + PlayerItems[i].ItemsCounter + "]", 0.5f));
                    }
                }
            }
        }
    }
}
