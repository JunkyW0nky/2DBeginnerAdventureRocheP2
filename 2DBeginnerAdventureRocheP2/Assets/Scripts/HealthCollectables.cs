using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class HealthCollectables : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        SugarLandMovement controller = other.GetComponent<SugarLandMovement>();
        if (controller != null)
        {
            if(controller.ChangeHealth < controller.maxHealth)
        }
 
        {
            controller.ChangeHealth(1);
            Destroy(gameObject);
        }

    }
}
