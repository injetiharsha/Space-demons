using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public GameObject gameOverpanel; // Fixed typo in GameObject

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") == null) // Fixed capitalization in GameObject
        {
            gameOverpanel.SetActive(true);
            ScoreManager.instance.canUpdateScore = false;
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
