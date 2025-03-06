using UnityEngine;
using UnityEngine.SceneManagement; // Needed if teleporting to another scene

public class TriggerAction : MonoBehaviour
{
    public Transform teleportLocation; // Set this in the inspector if teleporting
    public GameObject textBox; // Assign a UI text box in the inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Ensure the player has the "Player" tag
        {
            if (textBox != null)
            {
                textBox.SetActive(true); // Activate the text box
            }

            if (teleportLocation != null)
            {
                other.transform.position = teleportLocation.position; // Move the player
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && textBox != null)
        {
            textBox.SetActive(false); // Hide the text box when leaving
        }
    }
}
