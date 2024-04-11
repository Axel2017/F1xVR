using UnityEngine;

public class WaypointNavigation : MonoBehaviour
{
    public Transform point1;
    public Transform point2;
    public float transitionDuration = 1.0f;

    private float transitionTimer = 0.0f;

    void Update()
    {
        // Increment the timer
        transitionTimer += Time.deltaTime;

        // Calculate interpolation factor
        float t = Mathf.Clamp01(transitionTimer / transitionDuration);

        // Interpolate between the positions of point1 and point2
        transform.position = Vector3.Lerp(point1.position, point2.position, t);

        // Check if transition is complete
        if (t >= 1.0f)
        {
            // Reset the timer for next transition
            transitionTimer = 0.0f;
        }
    }
}