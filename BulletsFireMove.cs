using UnityEngine;

public class BulletsFireMove : MonoBehaviour
{
    [SerializeField] private int BulletSpeed;
	[SerializeField] private float BulletLife;

	private Rigidbody rigidbody;
    public GameObject BulletCollisionEffect;

	private void Awake()
	{
		Destroy(gameObject, BulletLife);
	}

	public void Start()
	{
		rigidbody = GetComponent<Rigidbody>();
		rigidbody.linearVelocity = transform.forward * BulletSpeed;
	}

	private void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.CompareTag("Ramp")){
			Instantiate(BulletCollisionEffect, collision.transform.position, Quaternion.identity);
			Destroy(gameObject);
		}
		else {
			Instantiate(BulletCollisionEffect, collision.transform.position, Quaternion.identity);
			Destroy(collision.gameObject);
			Destroy(gameObject);
			AudioManager.instance.PlaySFX(3);
		}
	}


	private void OnTriggerEnter(Collider other)
	{
	if (other.gameObject.tag == "Obstacles"){
		Instantiate(BulletCollisionEffect, other.transform.position, Quaternion.identity);
		Destroy(other.gameObject);
		Destroy(gameObject);
		AudioManager.instance.PlaySFX(3);
	}
	}
}
