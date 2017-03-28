// Various UI examples for Unity 5+
using UnityEngine;
using System.Collections;
// Needed fro UI in Unity 5+
using UnityEngine.UI;

public class UIExamples : MonoBehaviour
{
    // Set the target UI Text in the Inspector
    public Text uiText;

    // Set the target UI image in Inspector. UI Image must be "filled" type
    public Image uiImage;

    private int uiNumber = 7;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            // Basic usage
            uiText.text = "HELLO";

            // Fill amount is in a range from 0-1. Empty
            uiImage.fillAmount = 0;
        }
        else if (Input.GetButtonDown("Fire1"))
        {
            // Numbers must be converted to strings
            uiText.text = uiNumber.ToString();
            
            // Larger ranges of number can be converted by dividing with the max value. Halfway
            uiImage.fillAmount = 3.5f/uiNumber;
        }
        else if (Input.GetButtonDown("Fire2"))
        {
            // Numbers can be formatted to display a certain number of places
            uiText.text = uiNumber.ToString("000");

            // Full
            uiImage.fillAmount = 1;
        }
    }
}
