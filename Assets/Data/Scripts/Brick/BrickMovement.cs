using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
 using System;
using UnityEngine.UIElements;

public class BrickMovement : BrickAbs
{
    [SerializeField] protected  float speedMove=0.03f;


    [SerializeField] public Transform target;

    [SerializeField] public  bool  stopMoved = false;

     protected override void Start()
    {
        base.Start();
        IngredientImpact.OnImpactCollision +=ActionStopMovement;        
                            IngredientImpact.OnExitCollision +=ActionActiveMovement;

    }

    protected virtual  void FixedUpdate()  

    {
        this.MoveVertical();

    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadTarget();
        this.speedMove=0.03f;
        
    }

    protected virtual void LoadTarget()
    {
         if (this.target != null) return;
        this.target =transform.Find("Target");
        Debug.Log(transform.name + ": LoadTarget", gameObject);
    }


     protected virtual void MoveVertical()
    {
        if(this.stopMoved) return;
    
        Vector3 posPlayer = GameCtrl.Instance.PlayerCtrl.PlayerImpact.posObjImpacted;     // pos của object ImpactEd
        posPlayer.x = Mathf.Clamp(posPlayer.x, -1.6f, 2f);

        Vector3 posCurrent =   new Vector3(posPlayer.x,transform.parent.position.y,0);
        Vector3 newPos = Vector3.Lerp(posCurrent,this.target.transform.position,this.speedMove);
        transform.parent.position =newPos;

    }

    protected virtual void ActionStopMovement()
    {
           this.stopMoved =true;
           Debug.Log("stand");
         
    }

    protected virtual void ActionActiveMovement()
    {
       this.stopMoved=false;
       Debug.Log("fall");

  

    }





    protected void OnDestroy() 
    {

        IngredientImpact.OnImpactCollision -=ActionStopMovement;
              IngredientImpact.OnExitCollision -=ActionActiveMovement;

    }

  







   
    
}
