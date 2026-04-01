using UnityEngine;

public class SctipRotation : MonoBehaviour
{
	[SerializeField] public float rotationSpeed;
	public Vector3 rotationPoint = Vector3.zero;

	void Update()
	{
		transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
	}
}