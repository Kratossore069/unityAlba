using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fondo : MonoBehaviour
{
     void Start()
     {
     }
     
     void Update()
     {
         Vector2 offset=new Vector2(Time.time * 1f, 0); 
         GetComponent<Renderer>().material.mainTextureOffset=offset; 
     }
}
