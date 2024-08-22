using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientCtrl : ThienMonoBehaviour
{

     [SerializeField]  private static IngredientCtrl  instance;

   [SerializeField] public static IngredientCtrl Instance => instance;



   [SerializeField] protected IngredientImpact ingredientImpact;
   public IngredientImpact IngredientImpact =>ingredientImpact;

    protected override void Start()
    {
        base.Start();
         if(IngredientCtrl.instance !=null)  Debug.LogError("Only 1 BrickCtrl allow to exist");
        IngredientCtrl.instance=this;
    }

   

   

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
