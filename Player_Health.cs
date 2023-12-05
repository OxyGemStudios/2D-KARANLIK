using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Health : MonoBehaviour
{


    public int health = 100;
    Animator animator;
    public int medkit = 1;
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
  
        Die();   
        TakeHeal();

        if (Input.GetKeyDown(KeyCode.E)) { TakeDamage(30); }

    }
  public  void TakeDamage(int damage) 
    {

            
            if (health >= damage) 
            
            { 
            
                health -= damage;
            
            } 
            else
            { 
                health -= health;
            }
        
        
        
        
        
        
        
    
    
    }

    void TakeHeal() 
    { if (Input.GetKeyDown(KeyCode.H)) 
        {
            if (medkit > 0 && health < 100)
            {

                if (health <= 60 && health > 0)
                {

                    health += 40;

                }

                else if (health > 60)
                {
                    health += (100 - health);
                }

                medkit -= 1;
            }
         } 
    
    
    
    
    
    
    }
    void Die() { if (health <= 0) {  } }
}
