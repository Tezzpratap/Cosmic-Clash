using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private int speed;
    [SerializeField] private int sideSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * sideSpeed * horizontalInput * Time.deltaTime);
        
    }
}
