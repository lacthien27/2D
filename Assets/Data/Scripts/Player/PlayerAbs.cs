using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbs : ThienMonoBehaviour
{
  [SerializeField] protected PlayerCtrl playerCtrl;

  public PlayerCtrl PlayerCtrl => playerCtrl;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPlayerCtrl();
    }

    protected virtual void LoadPlayerCtrl()
    {
        if(this.playerCtrl!=null) return;
        this.playerCtrl = transform.parent.GetComponent<PlayerCtrl>();
        Debug.LogWarning(transform.name +" : LoadPlayerCtrl" ,gameObject);

    }
}
