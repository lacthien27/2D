using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedRotation : IngredientAbs
{

    protected override void Start()
    {
        base.Start();
      //  this.FixedObject();
    }


    protected void FixedUpdate() 
    {
     //   this.FixedObject();
    }

    protected virtual void FixedObject()
    {
        Debug.LogWarning("f");
     this.IngredientCtrl.IngredientImpact.transform.localRotation = Quaternion.Euler(0, 0, 90);

    }
}
