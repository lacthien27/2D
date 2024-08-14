using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BrickRayCast : BrickAbs
{    
    [SerializeField ]protected   RaycastHit2D hit;

    [SerializeField] public int  isBrickSto=0;

  protected void Update()  
  {
    this.DrawRay();  
  }

  protected virtual void DrawRay()
  {

    hit= Physics2D.Raycast(transform.parent.position, transform.forward, 2.025f);
    if(hit.collider !=null)
    {
          if(hit.transform.parent.gameObject.name=="ModelUnder")
          {
            //Debug.Log("s");
          }
    }
      
    

  }
}
