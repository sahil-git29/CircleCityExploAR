using UnityEngine;

public class CollectibleHoverRotate : MonoBehaviour
{
    public float hoverHeight = 0.5f; // Adjust the maximum height of the hover
    public float hoverSpeed = 2f; // Adjust the speed of the hover
    public float rotateSpeed = 60f; // Adjust the speed of rotation (360 degrees per second)
    public Vector3 rotationAxis = Vector3.up; // Define the rotation axis

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Calculate the new Y position for hovering
        float newY = startPosition.y + Mathf.Sin(Time.time * hoverSpeed) * hoverHeight;

        // Apply the hover motion to the object's position
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);

        // Rotate the object around the specified axis continuously
        transform.Rotate(rotationAxis, rotateSpeed * Time.deltaTime);
    }
}
