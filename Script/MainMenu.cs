using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public InputField playername; 


    public void playgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        DisplayingName.playernamestr = playername.text;
    }

}