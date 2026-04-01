using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBarSlider;

    public void setMaxHealth(int maxHealth){
        healthBarSlider.maxValue = maxHealth;
        healthBarSlider.value = maxHealth;
    }

    public void setHealth(int health){ 
        healthBarSlider.value = health;
    }
}
