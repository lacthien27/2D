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




    [SerializeField] protected BrickRotate brickRotate;

    public BrickRotate  BrickRotate => brickRotate;

    [SerializeField] protected StateMachineCtrl stateMachineCtrl;

    public StateMachineCtrl  StateMachineCtrl => stateMachineCtrl;


//    [SerializeField] public Transform modelCompleteCtrl;

    [SerializeField] protected ModelCompleteCtrl modelCompleteCtrl;

    public ModelCompleteCtrl  ModelCompleteCtrl => modelCompleteCtrl;


    
   
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBrickRotate();
        this.LoadModelCompleteCtrl();
        this.LoadStateMachineCtrl();
    }

    /** protected virtual void LoadModelComplete()
    {
        if(this.modelComplete !=null) return;
        this.modelComplete =transform.Find("ModelComplete");
        Debug.LogWarning(transform.name +" : LoadModelComplete ",gameObject);

    }**/
    
    protected virtual void  LoadModelCompleteCtrl()
    {
        if(this.modelCompleteCtrl !=null) return;
        this.modelCompleteCtrl =GetComponentInChildren<ModelCompleteCtrl>();
        Debug.LogWarning(transform.name +" : LoadModelCompleteCtrl ",gameObject);  
    }



    protected virtual void LoadBrickRotate()
    {
        if(this.brickRotate !=null) return;
        this.brickRotate =transform.GetComponentInChildren<BrickRotate>();
        Debug.LogWarning(transform.name +" : LoadBrickRotate ",gameObject);
    }

    


     protected virtual void LoadStateMachineCtrl()
    {
        if(this.stateMachineCtrl !=null) return;
        this.stateMachineCtrl =transform.GetComponentInChildren<StateMachineCtrl>();
        Debug.LogWarning(transform.name +" : LoadStateMachineCtrl ",gameObject);
    }



     


   
}

