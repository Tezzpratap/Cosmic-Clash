using UnityEngine;
using System.Collections;   

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private float ShootingDelay;
    public Transform LeftGunPosition;
    public Transform RightGunPosition;
    public GameObject Bullets;
    public bool canShoot = true;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) & canShoot){
            Instantiate(Bullets, LeftGunPosition.position, Quaternion.identity);
            Instantiate(Bullets, RightGunPosition.position, Quaternion.identity);
            StartCoroutine(ShootDelay());
            AudioManager.instance.PlaySFX(1);
		}
	}

    IEnumerator ShootDelay(){
        canShoot = false;
        yield return new WaitForSeconds(ShootingDelay);
        canShoot=true;
    }
}
