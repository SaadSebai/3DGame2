using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void Exit()
    {
        Debug.Log("Exiting");
        Application.Quit();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("Level1");
    }
}
