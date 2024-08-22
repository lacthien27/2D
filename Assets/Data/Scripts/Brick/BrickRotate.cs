using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Path;
using UnityEngine;

public class BrickRotate : BrickAbs
{
 
    [SerializeField] protected Transform  targetRotate;


    protected override void Start()
    {
        base.Start();
        this.RotateAroundPoint();
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
    

    
        base.LoadComponents();
        this.LoadTargetRotate();
    }

    protected virtual void LoadTargetRotate()
    {
        if(this.targetRotate !=null) return;
        this.targetRotate =transform.Find("TargetRotate");
        Debug.LogWarning(transform.name +" : LoadTargetRotate ",gameObject);    
    }




    protected virtual void RotateAroundPoint()
 {
  //  this.brickCtrl.modelComplete_1.transform.RotateAround(this.targetRotate.transform.position,Vector3.forward,90);
 }

}
