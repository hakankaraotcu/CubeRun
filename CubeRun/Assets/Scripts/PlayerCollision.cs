using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;     // A reference to our PlayerMovement script
    public GameManager gameManager;

    // This function runs when we hit another object
    // We get information about the collision and call it "collision"
    void OnCollisionEnter(Collision collision)
    {
        // We check if the object we collided with has a tag called "Obstacle"
        if(collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;   // Disable the players movement
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
