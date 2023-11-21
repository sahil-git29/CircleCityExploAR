using UnityEngine;

public class CollectibleHover : MonoBehaviour
{
    public float hoverHeight = 0.5f; // Adjust the maximum height of the hover
    public float hoverSpeed = 2f; // Adjust the speed of the hover

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Calculate the new Y position for hovering
        float newY = startPosition.y + Mathf.Sin(Time.time * hoverSpeed) * hoverHeight;

        // Apply the new position to the object
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
