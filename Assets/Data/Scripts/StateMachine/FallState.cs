using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallState : StateAbs
{
    [SerializeField] protected  float speedMove=0.03f;
    [SerializeField] public Transform target;

    [SerializeField] protected bool switchState ;

     protected override void OnEnter()
    {
       
        //give  signal due to  rotation object
        this.LoadTarget();
        this.switchState=false;


    }
    protected virtual void LoadTarget()
    {
         if (this.target != null) return;
        this.target =transform.Find("Target");
        Debug.Log(transform.name + ": LoadTarget", gameObject);
    }

    protected virtual  void FixedUpdate()  
    {
        this.Move();
    
    }

    protected virtual void Move()
    {
        if(this.switchState) return;
        Vector3 posPlayer = GameCtrl.Instance.PlayerCtrl.PlayerImpact.posObjImpacted;     // pos của object ImpactEd
        posPlayer.x = Mathf.Clamp(posPlayer.x, -1.6f, 2f);

        Vector3 posCurrent =   new Vector3(posPlayer.x,transform.parent.parent.position.y,0);
        Vector3 newPos = Vector3.Lerp(posCurrent,this.target.transform.position,this.speedMove);
        transform.parent.parent.position =newPos;
    }


    protected override void OnExit()
    {
        //place effect
        // signal due to stop rotation object

        this.switchState=true;

    }
}
