using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BackGroundSides : ThienMonoBehaviour
{
    
   [SerializeField] protected  List<Transform> wallImpacts;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadIngredientImpact();
    }

    protected virtual void LoadIngredientImpact()
    
    {
  
                if(this.wallImpacts.Count>0)return;

        Transform wallImpacts = transform.Find("WallImpact");
        foreach(Transform wallImpact in wallImpacts)
        {
            this.wallImpacts.Add(wallImpact);

            Collider2D wall =    wallImpact.GetComponent<Collider2D>();
            wall.isTrigger=true;

                

        }
    }




    
}
