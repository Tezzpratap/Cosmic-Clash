using UnityEngine;

public class SpikesObstacles : MonoBehaviour
{
    public float moveDistance = 1f;
    public float speed = 2f;

    private Vector3 startPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float offset = Mathf.PingPong(Time.time * speed, moveDistance);
        transform.position = startPosition + Vector3.up * offset;
    }
}
