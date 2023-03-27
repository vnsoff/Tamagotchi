using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PetName : MonoBehaviour
{
    public string petName;
    public string saveName;
    public Text inputText;
    public Text loadedName;
    public InputField textField;
    void Update()
    {
        petName = PlayerPrefs.GetString("name", "none");
        loadedName.text = petName;
    }

    public void SetName()
    {
        saveName = inputText.text;
        if (string.IsNullOrEmpty(saveName))
        {
            saveName = "Burrito";
            inputText.text = "Burrito";
            petName = "Burrito";
            loadedName.text = "Burrito";
            textField.text = "Burrito";
        }
        PlayerPrefs.SetString("name", saveName);
    }
}
