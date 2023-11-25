using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteTransform : MonoBehaviour
{
   [SerializeField]private float speed = 0.1f;
    
    void Update()
    {
        float x = transform.position.x + (speed * Time.deltaTime);
        float y = transform.position.y;

        transform.position = new Vector2(x, y);

    }
}
