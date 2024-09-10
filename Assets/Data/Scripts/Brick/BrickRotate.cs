using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Path;
using UnityEngine;
using System;
using UnityEngine.Video;


public class BrickRotate : BrickAbs
{
 
    [SerializeField] protected Transform  targetRotate;

    protected override void Start()
    {
        base.Start();
        InputManager.OnButtonClickedLeft +=RotateBrick;
        IngredientImpact.OnImpactCollision+=FixedObject;


    }

    protected override void LoadComponents()
    {

        base.LoadComponents();
        this.LoadTargetRotate();
    }

    protected virtual void LoadTargetRotate()
    {
        if(this.targetRotate !=null) return;
        this.targetRotate =transform.Find("TargetRotate");
        Debug.LogWarning(transform.name +" : LoadTargetRotate ",gameObject);    

    }

    protected virtual  void RotateBrick()
    {
        this.brickCtrl.modelComplete.transform.RotateAround(this.targetRotate.transform.position,Vector3.forward,90);

    }


    protected virtual void  FixedObject()
    {

                    InputManager.OnButtonClickedLeft -=RotateBrick; 
                    IngredientImpact.OnImpactCollision-=FixedObject;


    }



}
