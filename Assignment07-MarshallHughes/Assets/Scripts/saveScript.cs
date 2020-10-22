using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class saveScript : MonoBehaviour
{
    public Button delete;
    public Button save;
    public Text InputField;
    public Text showInput;
    // Start is called before the first frame update
    void Start()
    {
        save.onClick.AddListener(SaveClick);
        delete.onClick.AddListener(DeleteClick);
    }

    // Update is called once per frame
    void Update()
    {

        showInput.text = PlayerPrefs.GetString("inputText").ToString();

        
    }

    void SaveClick()
    {
        PlayerPrefs.SetString("inputText", InputField.text.ToString());
        Debug.Log(PlayerPrefs.GetString("inputText").ToString());
    }

    void DeleteClick()
    {
        PlayerPrefs.DeleteKey("inputText");
        Debug.Log("key deleted");
    }
}
