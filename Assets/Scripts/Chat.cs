using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Chat : MonoBehaviour
{
    [HideInInspector]
    public Text ChatText;
    [HideInInspector]
    public InputField MessageText;
    [HideInInspector]
    public int MessageCounter;
    [HideInInspector]
    public Button SendButton;

    void Awake()
    {
        //Chat Box
        ChatText = GameObject.Find("_Chat/_Background/_Chat Box").GetComponent<Text>();
        MessageText = GameObject.Find("_Chat/_Background/_Message Box").GetComponent<InputField>();
        SendButton = GameObject.Find("_Chat/_Background/_Send Button").GetComponent<Button>();
    }

    void Start()
    {
        MessageText.ActivateInputField();
        OnServerMessage("Welcome Player :)");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            OnSendMessage();
        }

        if (MessageCounter >= 20)
        {
            ChatText.text = "";
            MessageCounter = 0;
        }
    }

    void OnChatCommand(string CustomCommand, string Desc)
    {
        if (MessageText.text == "!" + CustomCommand || MessageText.text == "/" + CustomCommand)
        { 
            OnServerMessage(Desc);
        }
    }

    public void OnPlayerMessage()
    {
        ChatText.text += "<b>" + "[" + MessageCounter + "] " + "Player: </b> " + MessageText.text + "\n";
    }

    public void OnSendMessage()
    {
        if (MessageText.text != "")
        {
            OnPlayerMessage();
            OnChatCommand("Help", "Hello World");
            MessageText.text = "";
            MessageCounter++;
            MessageText.ActivateInputField();
        }
        else if (MessageText.text == "")
        {
            OnServerMessage(" You can not send EMPTY messages!");
            MessageCounter++;
        }
    }

    void OnServerMessage(string message)
    {
        ChatText.text += "<b>SERVER:</b> " + message + "\n";
    }
}
