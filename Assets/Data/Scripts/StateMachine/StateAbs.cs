


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class StateAbs : ThienMonoBehaviour
{

    [SerializeField] public StateMachineCtrl  stateMachineCtrl;     // current state in real time

            [SerializeField]  protected  bool isSignalEnter = false;

            [SerializeField]  protected  bool isSignalExit = false;



     public void OnStateEnter(StateMachineCtrl state)  // place  trigger   ,give 3  signal time
    {
       
        stateMachineCtrl =state;
        if (isSignalEnter) return;    //method control only 1 signal give
         this.isSignalEnter = true;
        OnEnter();
    }
    protected virtual void OnEnter() //place implement  logic  ,,give only once signal time
    {
        
    }

      public void OnStateUpdate() // place  trigger
    {
      
        OnUpdate();
    }

    protected virtual void OnUpdate() //place implement  logic
    
    {

    }


    public void OnStateExit() // place  trigger  ,  ,give 3  signal time
    {
        if (isSignalExit) return;    //method control only 1 signal give
         this.isSignalExit = true;
        OnExit();
    }

    protected virtual void OnExit()  //place implement  logic  , ,,give only once signal time
    {

    }
}