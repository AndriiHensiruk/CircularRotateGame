using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prey : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.inst.IncrementScore();
            GameController.inst.ShowScore();
            Destroy(gameObject);
        }
    }
}
