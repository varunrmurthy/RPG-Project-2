using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    [Tooltip("how fast the player can move")]
    private int Speed;

    [SerializeField]
    [Tooltip("scene transitions")]
    private GameManager GameManager;

    Rigidbody2D playerRigidbody;

    float xAxis;
    float yAxis;

	// Use this for initialization
	void Start () {
        playerRigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		xAxis = Input.GetAxisRaw("Horizontal");
        yAxis = Input.GetAxisRaw("Vertical");

        move();

	}

    

    void move() {
        Vector2 movementVector = new Vector2(xAxis, yAxis);
        playerRigidbody.velocity = movementVector * Speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("HellHound"))
        {
            GameManager.startBattle();
        }


        if (collision.gameObject.CompareTag("Destination"))
        {
            GameManager.winGame();
        }

        Destroy(collision.gameObject);
    }
}
