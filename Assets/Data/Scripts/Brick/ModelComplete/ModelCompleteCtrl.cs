using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 using System;
using UnityEngine.Video;
using System.Runtime.InteropServices;
using UnityEngine.UIElements.Experimental;


public class ModelCompleteCtrl : BrickAbs
{

[SerializeField]  public List<IngredientImpact> ingredientImpacts = new List<IngredientImpact>();

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadListIgImpact();
    }
        protected virtual void LoadListIgImpact()
        {
         ingredientImpacts.Clear(); // Đảm bảo không bị trùng lặp
        ingredientImpacts.AddRange(GetComponentsInChildren<IngredientImpact>());
        }
      

  
  
}
