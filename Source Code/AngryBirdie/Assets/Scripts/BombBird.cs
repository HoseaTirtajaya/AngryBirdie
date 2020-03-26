using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombBird : Bird
{
    public CircleCollider2D bombRad;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (BombTimer.isBoom)
        {
            if(collision.gameObject.tag == "Obstacle" || collision.gameObject.tag == "Enemy")
            {
                Destroy(collision.gameObject);
            }
        }
    }

}
