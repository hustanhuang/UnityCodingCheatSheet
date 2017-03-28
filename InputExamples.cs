// Various examples of Input usage in Unity
using UnityEngine;
using System.Collections;

public class InputExamples : MonoBehaviour
{
    // These strings need to be set in the Inspector to match Input Manager entries
    public string horiAxis, vertAxis, jump, button1, button2;

    public KeyCode key1;

    public Vector2 speed = new Vector2(10f, 5f);

    void Update()
    {
        // Run only once when button is pressed
        if (Input.GetButtonDown(jump))
        {
            Debug.Log("Jump");
        }
        // Keep running while button is held down
        if (Input.GetButton(button1))
        {
            Debug.Log("Fire1");
        }
        // Run only once when the button is released
        if (Input.GetButtonUp(button2))
        {
            Debug.Log("Fire2");
        }

        // Input.GetAxis will return a number between -1 and 1, with smoothing applied (adjust Sensitivity in Input Manager)
        Debug.Log("Horizontal: " + Input.GetAxis(horiAxis));

        // Input.GetAxisRaw will return a number between -1 and 1, without Sensitivity smoothing applied
        Debug.Log("Vertical: " + Input.GetAxisRaw(vertAxis));

        // This is often multiplied by a number to create movement
        Debug.Log("Horizontal Modified: " + Input.GetAxis(horiAxis) * speed.x);

        // Key pressed down
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("Key T pressed");
        }

        // Key held down
        if (Input.GetKey(KeyCode.Y))
        {
            Debug.Log("Key A pressed");
        }

        // KeyCode can also be set in the Inspector as a variable
        if (Input.GetKeyUp(key1))
        {
            Debug.Log("Key released");
        }
    }
}
