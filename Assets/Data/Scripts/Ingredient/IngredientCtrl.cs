using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientCtrl : ThienMonoBehaviour
{
   [SerializeField] protected IngredientImpact ingredientImpact;
   public IngredientImpact IngredientImpact =>ingredientImpact;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadIngredientImpact();
    }

    protected virtual void LoadIngredientImpact()
    
    {
        if(this.ingredientImpact !=null) return;
        this.ingredientImpact =transform.GetComponentInChildren<IngredientImpact>();
        Debug.LogWarning(transform.name +" : LoadIngredientImpact ",gameObject);
    }
    
}
