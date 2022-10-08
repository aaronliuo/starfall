using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CharacterSelection : MonoBehaviour
{
    public GameObject[] characters;
    public int selectedCharacter = 0;
    public TMP_Text label;


    //[System.Obsolete]
    public void NextCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter = (selectedCharacter + 1) % characters.Length;
        characters[selectedCharacter].SetActive(true);
        label.text = characters[selectedCharacter].name;

    }
    public void PreviousCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        Debug.Log(selectedCharacter);
        selectedCharacter--;
        if (selectedCharacter < 0)
        {
            selectedCharacter += characters.Length;
        }
        Debug.Log(selectedCharacter);
        characters[selectedCharacter].SetActive(true);
        label.text = characters[selectedCharacter].name;

    }

    public void StartGame()
    {
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

}
