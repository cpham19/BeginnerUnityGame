using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    // Apparently FixedUpdate() works better with physics than Update()
    void FixedUpdate()
    {
        // Add Force of 2000 in Z-Axis
		rb.AddForce(0, 0, 2000 * Time.deltaTime);
	}
}
