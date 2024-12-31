using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using System;
using UnityEngine.Video;
using System.Linq;
using System.Globalization;


public class Raycast : ThienMonoBehaviour
{
  [SerializeField]   protected float startNumber = -4;
    [SerializeField]  protected float endNumber = 4.4f;
    [SerializeField]  protected float step = 0.4f;

    [SerializeField]  protected  bool isNotifying = false;

     [SerializeField] protected List<float> numbers;

     [SerializeField] protected  RaycastHit2D[] hits;

      [SerializeField] public  List<GameObject>  objectsToDestroy;

        public static event  Action<GameObject> SignalDestroyBrick;

        
         public static event Action SignalSpawnBrick;



[SerializeField] public  List<RaycastHit> storeRayTriggered;

    protected override void Start()
    {
        base.Start();
       StopState.OnImpactSignal+=PosMoveRay;  //  yet  cause
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
        isNotifying = false;

        Debug.LogWarning("raycast");
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
                        this.calHitsForFallState(transform.position.y);   //vị trí y của điểm bắn raycast
                        }
      
                    }
            } 
       }

       if (isNotifying) return;    //method control only 1 signal give
                         isNotifying = true;
                         SignalSpawnBrick?.Invoke();
                         Debug.LogWarning("signal spawn");
    }


    protected virtual void calHitsForFallState(float number)
    {
      Debug.LogWarning(number+0.4f);
    }





}




  
    



