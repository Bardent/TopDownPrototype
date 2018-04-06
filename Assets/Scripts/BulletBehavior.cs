using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour {

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float velocity = 100;
    [SerializeField] private GameObject sound;
    public int Damage = 25;
    Transform thisTransform;
 

	void Start () {
        thisTransform = GetComponent<Transform>();
        Destroy(gameObject, 5);
        Instantiate(sound, transform.position, transform.rotation);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector2 movement = transform.up * velocity * Time.deltaTime;
        rb.velocity = movement;
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != ("Player"))
        {
            Destroy(gameObject);
        }
    }
}
