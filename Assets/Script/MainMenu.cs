using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGameGuestMode()
    {
        SceneManager.LoadScene("Puissance4");
    }
    public void LogIn()
    {
        SceneManager.LoadScene("LogIn");
    }
    public void SigIn()
    {
        SceneManager.LoadScene("SignIn");
    }
}
