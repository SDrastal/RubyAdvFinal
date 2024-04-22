using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilSlick : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController >();

        if (controller != null)
        {
            RubyController.speed = 2.0f;
        }
    }
}
