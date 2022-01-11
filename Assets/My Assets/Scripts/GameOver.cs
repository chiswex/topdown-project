using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public void RestartButton()
    {
        SceneManager.LoadScene("Level1");
    }
    public void ExitButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
