using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombTimer : MonoBehaviour
{
    private float bombTimer = 2f;
    public static bool isBoom = false;

    // Update is called once per frame
    void Update()
    {
        isBoom = false;
        bombTimer -= Time.deltaTime;

        if (bombTimer <= 0)
        {
            isBoom = true;
            bombTimer = 2f;
        }
        //Debug.Log(isBoom);
    }
}
