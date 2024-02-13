using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {

        //GetComponent<Rigidbody>().AddForce(Vector3.down * Physics.gravity.magnitude * Time.deltaTime);

        // Check for "i" and "k" key presses
        if (Input.GetKey(KeyCode.I))
        {
            // Move forward
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.K))
        {
            // Move backward
            transform.Translate(Vector3.forward * -speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.J)) {
            // Move right
            transform.Translate(Vector3.right * -speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.L))
        {
            // Move right
            transform.Translate(Vector3.left * -speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Botsing met:");
        Debug.Log(collision.gameObject.name);
        // You can access the collided object through "collision.gameObject"
        // Handle collision here, e.g., stop movement, play sound effects, etc.
    }
}
