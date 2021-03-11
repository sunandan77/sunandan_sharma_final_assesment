using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
{
    public GameObject cubeplayer;
    private int x = 0;
    private Renderer cubeRenderer;


    //Create a new cube primitive to set the color on
    //GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
    private void Start()
    {
        cubeRenderer = cubeplayer.GetComponent<Renderer>();
        StartCoroutine("colorchanger");
    }
    IEnumerator colorchanger()
    {

        x = Random.Range(0, 3);
        if (x == 0)
        {
            cubeRenderer.material.SetColor("_Color", Color.red);
        }
       
        if (x == 1)
        {
            cubeRenderer.material.SetColor("_Color", Color.green);

        }
       
       
        yield return new WaitForSeconds(3);
        StartCoroutine("colorchanger");
    }
}
