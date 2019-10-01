using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public Rigidbody rb;

    public float forwardForce = 8000f;
    public float sidewayForce = 120f;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void Update()
    {
    }

    // Update is called once per frame
    // Apparently FixedUpdate() works better with physics than Update()
    void FixedUpdate()
    {
        // Add Force of 2000 in Z-Axis
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Check if object is underneath the path or falls off the path
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
	}
}
