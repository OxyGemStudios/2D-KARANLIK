using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Health : MonoBehaviour
{

    public Image HealthBar;
    public float healthAmounth = 100;
    public int medkit = 1;
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
  
        Die();
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeHeal(40);
        }
       

    }

    void TakeHeal(float healingAmounth)
    {
        if (medkit > 0)
        {



            healthAmounth += healingAmounth;
            healthAmounth = Mathf.Clamp(healthAmounth, 0, 100);
            HealthBar.fillAmount = healthAmounth / 100;





            medkit -= 1;
        }
        
    }
    void TakeDamage(float damage) { healthAmounth -= damage; HealthBar.fillAmount = healthAmounth / 100; }
     
    void Die() { if (healthAmounth <= 0) {  } }
}
