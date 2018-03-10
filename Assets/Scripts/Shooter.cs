using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    public GameObject projectile, gun;
    private GameObject projectileParent;
    private Animator animator;
    private Spawner myLaneSpawner;
	
	void Start() {
        animator = GetComponent<Animator>();

    // Creates a parent if necessary
        projectileParent = GameObject.Find("Projectiles");
        if (!projectileParent) {
            projectileParent = new GameObject("Projectiles");
        }
	}
	
	void Update() {
		if (isAttackerAheadInLane()) {
            animator.SetBool("isAttacking", true);
        } else {
            animator.SetBool("isAttacking", false);
        }

        SetMyLaneSpawner();
        print(myLaneSpawner);
	}

    void SetMyLaneSpawner() {
        Spawner[] spawnerArray = GameObject.FindObjectsOfType<Spawner>();

        foreach (Spawner spawner in spawnerArray) {
            if (spawner.transform.position.y == transform.position.y) {
                myLaneSpawner = spawner;
                return;
            }
        }
        Debug.LogError(name +  " cannot find spawner in lane");
    }

    bool isAttackerAheadInLane() {
        
    }

    private void Fire() {
        GameObject newProjectile = Instantiate(projectile) as GameObject;
        newProjectile.transform.parent = projectileParent.transform;
        newProjectile.transform.position = gun.transform.position;
    }

}
