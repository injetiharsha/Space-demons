using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    private float scoreCount;
    private float score = 0f;
    public bool canUpdateScore = true; // Variable to control whether the score should be updated

    void Awake(){
        instance = this;
    }
    void Update()
    {
        if (canUpdateScore) // Only update the score if canUpdateScore is true
        {
            scoreText.text = "Score:" + Mathf.Round(score);
            scoreCount += Time.deltaTime;
            score = scoreCount;

            
        }
    }

    // Method to call when the player collides with an enemy
    public void PlayerCollidedWithEnemy()
    {
        canUpdateScore = false; // Set canUpdateScore to false to stop updating the score
        // You can add any other actions you want to perform when the player collides with an enemy here

    
    }
}
