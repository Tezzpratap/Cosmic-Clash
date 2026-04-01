using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    public GameObject ExplosionEffect;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player"){
            HealthSystem playerHealth = other.gameObject.GetComponent<HealthSystem>();
            playerHealth.DealDamage();
            Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
			AudioManager.instance.PlaySFX(2);
		}
	}
}
