using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player_Health : MonoBehaviour
{


    public int health = 100;
    public int medkit = 1;
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
  
        Die();   
        TakeHeal();

    

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
