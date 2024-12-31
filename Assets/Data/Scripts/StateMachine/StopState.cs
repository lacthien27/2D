using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal; 
using System;

public class StopState :  StateAbs

{
    [SerializeField] public List<IngredientImpact> listIngredientImpact;

        [SerializeField]  protected  bool isNotifying = false;

       public static event Action OnImpactSignal;  //only 1 signal give to  Raycast


       protected override void Awake() 
       {
               this.listIngredientImpact = this.stateMachineCtrl.BrickCtrl.ModelCompleteCtrl.ingredientImpacts;

       }

    protected override void OnEnter()  //  it call 3 time  -> call 1 time
    {
        this.ChangeAttributeWhenStop();          
         OnImpactSignal?.Invoke();

    }


    protected  virtual void  ChangeAttributeWhenStop()
    {
        if(listIngredientImpact==null) return;
        foreach (IngredientImpact impact in this.listIngredientImpact)
        {  
          impact.Collider2D.isTrigger=false;  // raycast not fire object that isTrigger==true
          impact.Collider2D.gameObject.layer=LayerMask.NameToLayer("IngredientImpact");
         
        }
        
    }

    protected override void OnExit()
    {
        //place effect
        // signal due to stop rotation object

//        this.ChangeAttributeWhenFall();
    }



     protected  virtual void  ChangeAttributeWhenFall()
    {
       foreach (IngredientImpact impact in this.listIngredientImpact)
        {
                
          if(listIngredientImpact==null) return;
          impact.Collider2D.isTrigger=true;  // raycast not fire object that isTrigger==true
            impact.Collider2D.gameObject.layer=LayerMask.NameToLayer("Default");

        }
    }

}


