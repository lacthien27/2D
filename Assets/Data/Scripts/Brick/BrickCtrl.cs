using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class BrickCtrl : ThienMonoBehaviour
{
  



    [SerializeField] protected bool isSpawnBrick = false;

    [SerializeField] protected bool isExistingBrick = false;

    [SerializeField] protected bool isImpactBricked = false;

    [SerializeField] protected bool isPetrified  =false;


    [SerializeField] protected BrickMovement brickMovement;
    public BrickMovement  BrickMovement => brickMovement;


    [SerializeField] protected BrickRotate brickRotate;

    public BrickRotate  BrickRotate => brickRotate;


    [SerializeField] public Transform modelComplete;
   
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBrickMovement();
        this.LoadBrickRotate();
        this.LoadModelComplete();

    }

      protected virtual void LoadModelComplete()
    {
        if(this.modelComplete !=null) return;
        this.modelComplete =transform.Find("ModelComplete");
        Debug.LogWarning(transform.name +" : LoadModelComplete ",gameObject);
    }



    protected virtual void LoadBrickRotate()
    {
        if(this.brickRotate !=null) return;
        this.brickRotate =transform.GetComponentInChildren<BrickRotate>();
        Debug.LogWarning(transform.name +" : LoadBrickRotate ",gameObject);
    }

      protected virtual void LoadBrickMovement()
    {
        if(this.brickMovement !=null) return;
        this.brickMovement =transform.GetComponentInChildren<BrickMovement>();
        Debug.LogWarning(transform.name +" : LoadBrickMovement ",gameObject);
    }



     


   
}
