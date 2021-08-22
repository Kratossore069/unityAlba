using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fondo : MonoBehaviour
{
     Material dibujo;
     private float paralax=2f;
     Vector2 offset;
 
     void Start()
     {
        SpriteRenderer sp=GetComponent<SpriteRenderer>();
        dibujo=sp.material;
        offset=dibujo.mainTextureOffset;
     }
     
     void Update()
     {
        offset.x += Time.deltaTime/paralax;
        dibujo.mainTextureOffset=offset;
     }
}
