using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

    Rigidbody2D rb;
    private GameObject target;
    [SerializeField] private GameObject deathParticle;
    [SerializeField] private GameObject hitParticle;
    [SerializeField] private int offset = -90;
    [SerializeField] private float speedMax = 100;
    [SerializeField] private float speedMin = 10;
    [SerializeField] private int health = 100;
    private float speed;
    private GameObject hitBy;
    Vector2 movement;
    


    void Start () {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
        speed = Random.Range(speedMin, speedMax);

	}
	
	// Update is called once per frame
	void FixedUpdate () {
        LookAtTarget();
        movement = transform.up * speed * Time.deltaTime;
        rb.velocity = movement;
	}

    void LookAtTarget() {

        Vector3 difference = target.transform.position - transform.position;
        difference.Normalize();
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ + offset);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet") {

            BulletBehavior script = collision.gameObject.GetComponent<BulletBehavior>();
            health -= script.Damage;

            Quaternion rot = Quaternion.Euler(0, 0, Random.Range(0, 360));

            Instantiate(hitParticle, transform.position, rot);
          
            if (health <= 0) {
                Destroy(gameObject);
                Instantiate(deathParticle, transform.position, transform.rotation);
            }

        }
    }


}
