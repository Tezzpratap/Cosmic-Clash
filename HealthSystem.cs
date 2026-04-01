using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] private int MAX_Health;
    [SerializeField] private int Current_Health;
    [SerializeField] private int Attack_damage;

    public HealthBar healthBar;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        Current_Health = MAX_Health;
        healthBar.setMaxHealth(Current_Health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DealDamage(){
        Current_Health -= Attack_damage;
        healthBar.setHealth(Current_Health);
        if (Current_Health < 0 ){
            gameObject.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        Debug.Log("Health: " + Current_Health);
    }
}
