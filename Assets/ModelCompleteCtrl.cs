using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
 using System;


public class ModelCompleteCtrl : ThienMonoBehaviour
{

[SerializeField]  protected List<IngredientImpact> ingredientImpacts = new List<IngredientImpact>();

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
                ingredientImpact.gameObject.layer =LayerMask.NameToLayer("Default");
                Debug.LogWarning(ingredientImpact.gameObject.layer);
        }
    }

    protected virtual void OnDestroy()
    {
                IngredientImpact.OnImpactCollision-=HandleTrigger;

    }
}
