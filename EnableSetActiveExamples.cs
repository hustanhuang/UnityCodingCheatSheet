// Various ways of enabling/disabling a gameObject's components and activating/deactivating a gameObject.
using UnityEngine;
using System.Collections;

public class EnableSetActiveExamples : MonoBehaviour
{
    public GameObject targetGameObject;
    private Collider2D coll2D;

    void Start()
    {
        // SetActive can switch a gameObject on or off in the Hierarchy. Once deactivated, its components will no longer run until reactivated.
        targetGameObject.SetActive(false);

        // Get a collider2D component attached to this gameObject. Note: Collider2D will work with any kind of 2D collider component.
        coll2D = GetComponent<Collider2D>();

        // Disable or enable a component using a bool
        coll2D.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Jump is space in Input Manager
        if (Input.GetButtonDown("Jump"))
        {
            // Check if a gameObject is active in the scene with activeInHierarchy. Reminder: The ! is shorthand for == false. If the gameObject is inactive, activate it
            if (!targetGameObject.activeInHierarchy)
            {
                targetGameObject.SetActive(true);
            }
        }

        // Fire1 is left ctrl in Input Manager
        if (Input.GetButtonDown("Fire1"))
        {
            // Check if a component is enabled. Reminder: The ! is shorthand for == false.
            if (!coll2D.enabled)
            {
                coll2D.enabled = true;
            }
        }
    }
}
