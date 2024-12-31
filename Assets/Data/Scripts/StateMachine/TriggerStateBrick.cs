using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerStateBrick : ThienMonoBehaviour
{
     [SerializeField] protected BrickCtrl brickCtrl;
      public BrickCtrl BrickCtrl=> brickCtrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBrickCtrl();
    }

     protected virtual void LoadBrickCtrl()
    {
        if(this.brickCtrl !=null) return;

       this.brickCtrl =transform.GetComponent<BrickCtrl>();
        Debug.LogWarning(transform.name +" : LoadBrickCtrl ",gameObject);
    }



    protected virtual void Update()
    {
        
    }
}
  
