using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    // Start is called before the first frame update
    bool gameHasEnded = false;
    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void completeLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("gameOver");
            Invoke("Restart", restartDelay);
        }

        

    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}