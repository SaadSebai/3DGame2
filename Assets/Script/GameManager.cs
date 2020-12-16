using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameOver = false;
    [SerializeField] private float restartDelay = 2f;
    [SerializeField] private GameObject completeLeveUI;

    public void CompleteLevet()
    {
        Debug.Log("Level Completed!!!!");
        completeLeveUI.SetActive(true);
    }

    public void EndGame()
    {
        if(gameOver == false)
        {
            gameOver = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
