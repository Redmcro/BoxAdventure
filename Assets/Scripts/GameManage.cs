using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour  
{
    bool gameHasEnded = false;
    public float restartDealy = 1f;
    public GameObject competelevelUI;

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            Debug.Log("Game Over!");
            gameHasEnded = true;
            Invoke("Restart",restartDealy);
        }        
    }

    public void CompleteLevel()
    {
        competelevelUI.SetActive(true);
    }

}
