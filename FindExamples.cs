// Various ways of finding things in Unity

using UnityEngine;
using System.Collections;

public class FindExamples : MonoBehaviour
{
    // Example needs a Rigidbody2D component to work
    private Rigidbody2D rb2D, otherRb2D, childRb2D;
    private GameObject hierarchyObject, childObject, taggedObject;

    void Start()
    {
        // Find a component attached to this GameObject
        rb2D = GetComponent<Rigidbody2D>();

        // Find a GameObject in the Hierarchy. NOTE: This will check all GameObjects in the Hierarchy! Proceed with caution...
        hierarchyObject = GameObject.Find("Name Of Object");
        
        // Find a GameObject in the hierarchy based on tag. NOTE: Fast than finding by name since it only needs to check GameObjects with the matching tag.
        taggedObject = GameObject.FindWithTag("Player");
        
        // Can be combined to find a component on a GameObject in the Hierarchy
        otherRb2D = GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>();

        // Lowercase transform.Find can be used to search child GameObjects by name
        childObject = transform.Find("Name Of Object").gameObject;

        // Can also be combined
        childRb2D = transform.Find("Name Of Object").GetComponent<Rigidbody2D>();
    }
}
