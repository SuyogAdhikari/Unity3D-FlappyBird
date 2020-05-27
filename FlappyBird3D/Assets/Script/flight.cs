using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flight : MonoBehaviour
{
    public GameManager gameManager;
    public Rigidbody player;
    public float velocity;
    public Vector3 direction;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //velocity = 2; direction = (0,200,0);
            player.velocity = direction * velocity * Time.deltaTime;
        }

        if(player.position.y >= 40 || player.position.y <= -40) 
        {
            gameManager.GameOver();
        }  
    }

   public void OnCollisionEnter()
   {       
       gameManager.GameOver(); 
   }
}
