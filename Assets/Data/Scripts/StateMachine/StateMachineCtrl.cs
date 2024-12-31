using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineCtrl : BrickAbs
{

    
    [SerializeField] public StateAbs  currentState;        //current state in real time
  [SerializeField] protected FallState fallState;
  public FallState FallState=> fallState;


  [SerializeField] protected StopState stopState;
  public StopState StopState=> stopState;

   

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadFallState();
        this.LoadStopState();
    }

      protected virtual void LoadFallState()
    {
        if(this.fallState !=null) return;
        this.fallState =transform.GetComponentInChildren<FallState>();
        Debug.LogWarning(transform.name +" : LoadFallState ",gameObject);
    }


      protected virtual void LoadStopState()
    {
        if(this.stopState !=null) return;
        this.stopState =transform.GetComponentInChildren<StopState>();
        Debug.LogWarning(transform.name +" : LoadStopState ",gameObject);
    }

    protected virtual void LoadState()
    {
        if(this.currentState!=null) return;
        Debug.LogWarning(transform.name+ " : LoadState",gameObject);
    }



    protected override void Start()
    {
        ChangeState(fallState);
    }

    protected virtual void Update()
    {
        if (currentState != null)
        {
            currentState.OnStateUpdate();
        }
    }

    public void ChangeState(StateAbs newState)  //give signal 3 time 
    {
        if (currentState != null)
        {
            currentState.OnStateExit();
  
        }
       
        currentState = newState;

        currentState.OnStateEnter(this);

        
    }
}

