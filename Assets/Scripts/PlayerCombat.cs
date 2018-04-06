using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour {

    [SerializeField] private Transform leftHand;
    [SerializeField] private Transform rightHand;

    private GameObject firePointLeft;
    private GameObject firePointRight;
    [SerializeField] private GameObject projectile;

    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")) {
            ShootLeft();
        }
        if(Input.GetButtonDown("Fire2")) {
            ShootRight();
        }
    }

    void ShootLeft() {
        Debug.Log("Shoot");
        Instantiate(projectile, leftHand.position, leftHand.rotation);
    }

    void ShootRight(){
        Debug.Log("Shoot");
        Instantiate(projectile, rightHand.position, rightHand.rotation);
    }
}
