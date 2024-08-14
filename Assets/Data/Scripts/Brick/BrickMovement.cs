using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class BrickMovement : BrickAbs
{
    [SerializeField] protected  float speedMove = 0.005f;
    [SerializeField] protected Transform target;

    protected virtual  void Update() 

    {
        this.MoveVertical();
    }

    

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadTarget();
    }

    protected virtual void LoadTarget()
    {
         if (this.target != null) return;
        this.target =transform.Find("Target");
        Debug.Log(transform.name + ": LoadTarget", gameObject);
    }


    


    protected virtual void MoveVertical()
    {
       
        Vector3 posCurrent =   new Vector3(GameCtrl.Instance.SpawnPointBrick.PosSpawn.x,transform.parent.position.y,0);
        Vector3 newPos = Vector3.Lerp(posCurrent,this.target.transform.position,this.speedMove);
        
        transform.parent.position =newPos;
    }

    protected  virtual void MoveHorizontal()
    {

    }




   
    
}
