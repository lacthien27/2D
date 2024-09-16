using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
 using System;
using UnityEngine.Video;


public class ModelCompleteCtrl : BrickAbs
{

[SerializeField]  protected List<IngredientImpact> ingredientImpacts = new List<IngredientImpact>();

    public static event Action OnImpactStart;

        [SerializeField]  protected  bool isNotifying = false;




    protected override void Start()
    {
        base.Start();
        IngredientImpact.OnImpactCollision+=HandleTrigger;

    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
      
         ingredientImpacts.AddRange(GetComponentsInChildren<IngredientImpact>());

     
    }



       protected virtual void HandleTrigger()
    {
           foreach (IngredientImpact ingredientImpact in ingredientImpacts)
        {
                ingredientImpact.gameObject.layer =LayerMask.NameToLayer("IngredientImpact");
                ingredientImpact.Collider2D.isTrigger=false;
              
              
              //
              
                if(ingredientImpact.Collider2D.isTrigger==true) return;
                 if (isNotifying) return;
                   isNotifying = true;
                    Debug.LogWarning("1");
                    OnImpactStart?.Invoke();

                }

        }



        
    

    protected virtual void OnDestroy()
    {
                IngredientImpact.OnImpactCollision-=HandleTrigger;

    }
  
}
