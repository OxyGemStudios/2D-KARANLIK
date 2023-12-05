using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

using UnityEngine.SceneManagement;

 
public class PlayerInputScript : MonoBehaviour
{

    public int hasar = 20;
 
    Rigidbody2D rb;
    public int moveSpeed = 200;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, Input.GetAxis("Vertical")*moveSpeed*Time.deltaTime);
        


    }



  

}
