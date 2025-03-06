using UnityEngine;

public class ShowUIPanel : MonoBehaviour
{
    public GameObject uiPanel; // Assign the UI Panel in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Make sure your player has the "Player" tag
        {
            uiPanel.SetActive(true); // Show the UI Panel
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiPanel.SetActive(false); // Hide the UI Panel when the player leaves
        }
    }
}
