using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public float speed;
    public float rotSpeed;

	// Update is called once per frame
	void Update () {

        float z = Input.GetAxisRaw("Vertical") * speed;
        float y = Input.GetAxisRaw("Horizontal") * rotSpeed;

        transform.Translate(0, 0, z);
        transform.Rotate(0, y, 0);
   
	}
}
