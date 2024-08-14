using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class BrickCtrl : ThienMonoBehaviour
{
    [SerializeField] protected List<BrickObserver> observers = new List<BrickObserver>();

    [SerializeField] protected bool isSpawnBrick = false;

    [SerializeField] protected bool isExistingBrick = false;

    [SerializeField] protected bool isImpactBricked = false;


    [SerializeField] protected BrickMovement brickMovement;
    public BrickMovement  BrickMovement => brickMovement;


    [SerializeField] protected BrickRotate brickRotate;

    public BrickRotate  BrickRotate => brickRotate;

    [SerializeField] public Transform modelComplete_1;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBrickMovement();
        this.LoadBrickRotate();
        this.LoadModelComplete_1();
 
    }
     protected virtual void LoadModelComplete_1()
    {
        if(this.modelComplete_1 !=null) return;
        this.modelComplete_1 = transform.Find("ModelComplete_1");
        Debug.LogWarning(transform.name +" : LoadModelComplete_1 ",gameObject);
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
