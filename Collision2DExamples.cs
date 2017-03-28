// Various 2D collision examples
using UnityEngine;
using System.Collections;

public class Collision2DExamples : MonoBehaviour
{
    // Collisions/Triggers require a collider component on both gameObjects and a rigidbody on at least one.
    // Collision = physics. Trigger = overlap.

    void OnCollisionEnter2D(Collision2D other)
    {
        // Do something when another collider touches this gameObject's collider
        Debug.Log("Collided with something");

        // Conditional statements can be used to filter collisions/triggers. Checking for a known tag is one option. Be sure to define tag in the Inspector or you will get an error.
        if (other.gameObject.CompareTag("tag1"))
        {
            Debug.Log("tag1 collision");
        }
        else if (other.gameObject.CompareTag("tag2"))
        {
            Debug.Log("tag2 collision");
        }
    }

    // Is Trigger needs to be selected on one of the colliders
    void OnTriggerEnter2D(Collider2D other)
    {
        // Do something if another collider overlaps this gameObject's collider
        Debug.Log("Triggered by something");
    }

    // Collision and Trigger also have exit and stay events
    void OnCollisionExit2D(Collision2D other)
    {
        // Do something after a collider is no longer touching this gameObject's collider
        Debug.Log("Collision ended");
    }

    void OnTriggerStay2D(Collider2D other)
    {
        // Do something while a collider is still overlapping with this gameObject's collider
        Debug.Log("Still triggering");
    }

}
