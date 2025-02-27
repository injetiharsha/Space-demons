using UnityEngine;

public class obstacle : MonoBehaviour
{
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
       player = GameObject.FindGameObjectWithTag("Player"); // FindGameObjectWithTag is the correct method name
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(gameObject); // Destroy the obstacle
        }
        else if (collision.tag == "Player")
        {
            Destroy(player); // Destroy the player
        }
    }
}
