using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotation : MonoBehaviour
{
    public GameObject Player;

    void Start()
    {
   

    }

    // Update is called once per frame
    void Update()
    {


        FlipGun();


    }

    void FlipGun()
    {

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f;
        

        if (mousePosition.x > Player.transform.position.x) { gameObject.transform.localScale = new Vector2(0.35f, 0.35f); }
        else if (mousePosition.x < Player.transform.position.x) { gameObject.transform.localScale = new Vector2(-0.35f, 0.35f); }

    }
}
