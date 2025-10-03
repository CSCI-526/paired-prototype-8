using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class WinPlatform : MonoBehaviour
{
    [Tooltip("If you are using a separate scene, this UI is optional.")]
    public GameObject winUI;
    
    [Tooltip("The name of the scene to load upon winning (e.g., 'SecondScene').")]
    public string winSceneName = "SecondScene";

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            WinTheGame();
        }
    }

    private void WinTheGame()
    {
        if (winUI != null)
        {
            winUI.SetActive(true);
        }

        Debug.Log("Player reached the Win Platform! Loading: " + winSceneName);

        SceneManager.LoadScene(winSceneName);
    }
}
