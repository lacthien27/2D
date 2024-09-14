using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using System;
using UnityEngine.Video;
using System.Linq;


public class RaycastMove : ThienMonoBehaviour
{
  [SerializeField]   protected float startNumber = -4;
    [SerializeField]  protected float endNumber = 4.4f;
    [SerializeField]  protected float step = 0.4f;

     [SerializeField] protected List<float> numbers;

     [SerializeField] protected  RaycastHit2D[] hits;

         public LayerMask triggerLayer; // Kéo thả layer của các object có trigger vào đây


[SerializeField] public  List<RaycastHit> storeRayTriggered;

    protected override void Start()
    {
        base.Start();
       IngredientImpact.OnImpactCollision+=PosMoveRay;
        this.GetPosMoveRay();
       // this.PosMoveRay();
    }

    protected virtual void Update()
     {
        this.Ray();    
    
    }

    protected virtual void GetPosMoveRay()
    { 
        float currentNumber = this.startNumber;
         while (currentNumber <= endNumber)
        {
            this.numbers.Add(currentNumber);

            currentNumber += step;
        }

    }
   protected virtual void PosMoveRay()
    {   
       foreach(float number in numbers)
       {

            transform.position= new Vector3(2.4f,number,0);
            hits = Physics2D.RaycastAll(transform.position, -Vector2.right,100f);


            foreach(RaycastHit2D hit in hits)
            {
             //   Debug.LogWarning(hit.transform.parent.name);
            }
       }
    }

    protected virtual void  Ray()
    {
        hits = Physics2D.RaycastAll(transform.position, -Vector2.right,100f);
           foreach(RaycastHit2D hit in hits)
            {
               // Debug.LogWarning(hit.transform.parent.name);
            }
    }


  
    

}

