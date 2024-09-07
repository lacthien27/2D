using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientAbs : ThienMonoBehaviour
{
        [Header("IngredientAbs")]

    [SerializeField] protected IngredientCtrl ingredientCtrl;

    public IngredientCtrl  IngredientCtrl =>ingredientCtrl;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadIngredientCtrl();
    }

    protected virtual void LoadIngredientCtrl()
    {
        
        if(this.ingredientCtrl !=null) return;

        this.ingredientCtrl =transform.parent.GetComponent<IngredientCtrl>();
        Debug.Log(transform.name +" : LoadIngredientCtrl ",gameObject);
    }
}
