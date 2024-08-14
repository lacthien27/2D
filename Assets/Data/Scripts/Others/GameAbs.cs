using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameAbs : ThienMonoBehaviour
{
   [SerializeField] protected GameCtrl gameCtrl;

    public GameCtrl GameCtrl => gameCtrl;
    protected override void LoadComponents()
    {
        this.LoadGameCtrl();
    }

       protected virtual void LoadGameCtrl()
    {
        if(this. gameCtrl !=null) return;
        this. gameCtrl =FindAnyObjectByType< GameCtrl>();
        Debug.LogWarning(transform.name +" : LoadGameCtrl ",gameObject);
    }
}
