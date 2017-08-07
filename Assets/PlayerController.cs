using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // 바닥 충돌 용
    private SphereCollider Sphere_col;
    private Vector3 BackUpPos;

	// Use this for initialization
	void Start () {
		if(Sphere_col == null)
        {
            Sphere_col = GameObject.FindGameObjectWithTag("PlayerCollider").GetComponent<SphereCollider>();
            Debug.Log("Collider Find!");
        }
        else
        {
            Debug.Log("Collider Find Failed!");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
