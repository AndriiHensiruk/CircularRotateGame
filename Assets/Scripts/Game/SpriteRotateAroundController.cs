using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRotateAroundController : MonoBehaviour
{
    [SerializeField]private Transform target;
    [SerializeField]private float speed = 10;
    [SerializeField]private float radius = 10;
    [SerializeField]private float angle = 0;

    private bool up, down = false;

    private void Start ()
    {
        up = true;
    }

    private void Update()
    {
       

        float x = target.position.x + Mathf.Cos(angle) * radius;
        float y = target.position.y+ Mathf.Sin(angle) * radius;
       

        transform.position = new Vector3(x, y);

        if(SwipeController.swipeDown)
            {
                if(up)
                {
                speed = speed * (-1);
                up = false;
                }
            down = true ; 

            }
                
            
        
        if(SwipeController.swipeUp)
            {
                if(down)
                {
                speed = speed * (-1);
                down = false;
                }
             up = true;
            }
                

            angle += speed * Time.deltaTime;
    }
    
        
}