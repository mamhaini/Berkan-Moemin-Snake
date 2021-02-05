using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Private Variables
    public float speed;
    private Rigidbody2D player;
    private float moveHorizontal;
    private float moveVertical;
    public PlayerScore playerScore;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
        player.AddForce(movement * speed);

    }
    // On trigger add score
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Apple")
        {
            Debug.Log("Collision detected");
            playerScore.scorePoint += 10;

        }
    }
}
