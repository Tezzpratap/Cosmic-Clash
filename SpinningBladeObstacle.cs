using UnityEngine;

public class SpinningBladeObstacle : MonoBehaviour
{
	[SerializeField] private int BladeMoveSpeed;
	[SerializeField] private int BladeSpinSpeed;
	public Transform StartPoint, EndPoint;
	private Vector3 currentPosition;
	public bool LeftToRightMove;

	void Start()
	{
		// Reset the currentPosition *before* Start()
		currentPosition = StartPoint.position;
	}

	// Update is called once per frame
	void Update()
	{
		if (transform.position == StartPoint.position)
		{
			currentPosition = EndPoint.position;
		}
		else if (transform.position == EndPoint.position)
		{
			currentPosition = StartPoint.position;
		}

		transform.position = Vector3.MoveTowards(transform.position, currentPosition, BladeMoveSpeed * Time.deltaTime);
		if (LeftToRightMove ) {
			transform.Rotate(BladeSpinSpeed * Time.deltaTime, 0f, 0f);
		}else {
			transform.Rotate(0f, 0f, BladeSpinSpeed * Time.deltaTime);
		}
	}
}
