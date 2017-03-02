using UnityEngine;
using System.Collections;

public class UIManagerScript : MonoBehaviour
{

    public Animator startButton;

    public void StartGame()
    {
        Application.LoadLevel("Level1");
    }

    public void OpenSettings()
    {
        startButton.SetBool("isHidden", true);
    }
}
