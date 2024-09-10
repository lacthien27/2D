using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



 public class FixedRotation : IngredientAbs

{
   [SerializeField]   public int angle =0; 

    protected override void Start()
    {
        base.Start(); 
          IngredientImpact.OnImpactCollision+=FixedObject;
          InputManager.OnButtonClickedLeft+=FixedDirectObject;
    }
   
    protected virtual void FixedDirectObject()
    {
      this.angle+=90;
     this.ingredientCtrl.IngredientImpact.transform.localRotation = Quaternion.Euler(0, 0, this.angle);

    }
        protected virtual void  FixedObject()
    {
            InputManager.OnButtonClickedLeft-=FixedDirectObject;
              IngredientImpact.OnImpactCollision-=FixedObject;
    }
}
