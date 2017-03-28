// Various Instantiate examples for Unity
using UnityEngine;
using System.Collections;

public class InstantiateExamples : MonoBehaviour
{
    // Set the object to be cloned in the Inspector. Be sure to use a Prefab from Project NOT Scene!
    public GameObject prefab;

    // Set a target transform in the Inspector to clone prefab from
    public Transform spawnPoint;

    // Update is called once per frame
    void Update()
    {
        // Basic cloning
        if (Input.GetButtonDown("Jump"))
        {
            // Pass the prefab as an argument and clone it at the transform of this gameObject. 
            Instantiate(prefab, transform);

            // Second argument could be set to different transform, if there is another place the prefab should be cloned.
            //Instantiate(prefab, spawnPoint);
        }

        // Advanced cloning
        if (Input.GetButtonDown("Fire1"))
        {
            // Overloaded method which can be positioned and rotated. 
            GameObject p = Instantiate(prefab, transform.position, Quaternion.identity) as GameObject;

            // Make this clone a child of the gameObject that spawned it
            p.transform.parent = transform;

            // This approach allows you to further manipulate the cloned prefab in this script. Such as...
            // Destroying the clone after a set amount of time
            Destroy(p, 3f);

            // Accessing the cloned prefab's components. Note: The prefab needs a Rigidbody2D component for the next 2 lines to work.
            Rigidbody2D pRB2D = p.GetComponent<Rigidbody2D>();
            pRB2D.AddForce(Vector2.up * 100f);
        }

        // Clone prefab at specified transform
        if (Input.GetButtonDown("Fire2"))
        {
            GameObject p = Instantiate(prefab, spawnPoint.position, Quaternion.identity) as GameObject;
            p.transform.parent = transform;
        }
    }
}
