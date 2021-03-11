using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middlecube : MonoBehaviour
{
    public static bool abcd = true;
    private void OnCollisionEnter(Collision collisioninfo)
    {

        if (collisioninfo.collider.tag == "obstacle")
        {
            Destroy(GameObject.FindWithTag("obstacle"));

            abcd = false;
        }



    }
}
