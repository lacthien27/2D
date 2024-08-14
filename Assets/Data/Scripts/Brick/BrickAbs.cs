using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BrickAbs : ThienMonoBehaviour
{
    [Header("Brick Abstract")]
   [SerializeField] protected BrickCtrl brickCtrl;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBrickCtrl();
    }

    protected virtual void LoadBrickCtrl()
    {
        if(this.brickCtrl !=null) return;

        this.brickCtrl =transform.parent.GetComponent<BrickCtrl>();
        Debug.LogWarning(transform.name +" : LoadBrickCtrl ",gameObject);
    }
}
