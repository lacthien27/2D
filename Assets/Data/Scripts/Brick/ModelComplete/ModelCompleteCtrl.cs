using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
 using System;
using UnityEngine.Video;


public class ModelCompleteCtrl : BrickAbs
{

[SerializeField]  protected List<IngredientImpact> ingredientImpacts = new List<IngredientImpact>();

    public static event Action OnSpawnSignal;  // only 1 signal dù  a lot ingredients impact

    [SerializeField]  protected  bool isNotifying = false;




    protected override void Start()
    {
        base.Start();
        IngredientImpact.OnImpactCollision+=HandleTrigger;
                 ingredientImpacts.AddRange(GetComponentsInChildren<IngredientImpact>());

    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
      
     
    }

       protected virtual void HandleTrigger()
    {
        
        //combine 2 loop will cause some IngredientImpact  not switch state
           foreach (IngredientImpact ingredientImpact in ingredientImpacts)
        {
                if(ingredientImpact==null) return;
                ingredientImpact.gameObject.layer =LayerMask.NameToLayer("IngredientImpact");
                ingredientImpact.Collider2D.isTrigger=false;
        }

       foreach ( IngredientImpact ingredientImpact1 in ingredientImpacts)
        {
            
               if(ingredientImpact1.Collider2D.isTrigger==true) return; //yet optimize , 
                 if (isNotifying) return;
                   isNotifying = true;
                    OnSpawnSignal?.Invoke();
        }

    }


    protected virtual void OnDestroy()
    {
                IngredientImpact.OnImpactCollision-=HandleTrigger;

    }
  
}
