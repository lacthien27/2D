using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedRotation : IngredientAbs
{
    


    protected void Update() 
    {
        this.FixedObject();
    }

    protected virtual void FixedObject()
    {

     this.IngredientCtrl.IngredientImpact.transform.localRotation = Quaternion.Euler(0, 0, 90);

    }
}
