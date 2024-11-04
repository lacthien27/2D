using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using System;
using UnityEngine.Video;
using System.Linq;


public class Raycast : ThienMonoBehaviour
{
  [SerializeField]   protected float startNumber = -4;
    [SerializeField]  protected float endNumber = 4.4f;
    [SerializeField]  protected float step = 0.4f;

     [SerializeField] protected List<float> numbers;

     [SerializeField] protected  RaycastHit2D[] hits;

      [SerializeField] public  List<GameObject>  objectsToDestroy;

        public static event  Action<GameObject> SignalDestroyBrick;



[SerializeField] public  List<RaycastHit> storeRayTriggered;

    protected override void Start()
    {
        base.Start();
       ModelCompleteCtrl.OnSpawnSignal+=PosMoveRay;  //  yet  cause
        this.GetPosMoveRay();
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
            if(hits.Length==5) 
            {
                foreach(RaycastHit2D hit in hits)
                    {   
                        if(hit.collider.gameObject.layer == 6)
                        {
                        GameObject hitObject = hit.collider.gameObject;
                        SignalDestroyBrick?.Invoke(hitObject);

 
                        }


                        
                    }
            }

            
       
       }
    }

}




  
    



