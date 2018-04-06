using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField] Rigidbody2D rb;
    [SerializeField] private float speed = 10;
    private float horizontal;
    private float vertical;


	void Start () {
		
	}

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate () {

  
        Walk(horizontal, vertical);

	}

    void Walk(float hor, float ver)
    {
        Vector2 direction = new Vector2(hor, ver);
        Vector2 force = (direction.normalized) * speed * Time.deltaTime;
        rb.velocity = force;
    }

}
