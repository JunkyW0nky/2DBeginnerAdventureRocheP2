using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectables : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other)
    {
        SugarLandMovement controller = other.GetComponent<SugarLandMovement>(); 
        if (controller != null)
        {
            controller.ChangeHealth(1);
            Destroy(gameObject);
        }

}
