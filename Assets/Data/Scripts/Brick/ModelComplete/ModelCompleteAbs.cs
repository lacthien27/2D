using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelCompleteAbs : ThienMonoBehaviour
{
    [Header("Model CompleteAbs")]
   [SerializeField] protected ModelCompleteCtrl modelCompleteCtrl;

      public ModelCompleteCtrl ModelCompleteCtrl=>  modelCompleteCtrl ;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadModelCompleteCtrl();
    }

    protected virtual void LoadModelCompleteCtrl()
    {
        if(this.modelCompleteCtrl !=null) return;

       this.modelCompleteCtrl =transform.parent.GetComponent<ModelCompleteCtrl>();
        Debug.LogWarning(transform.name +" : LoadModelCompleteCtrl ",gameObject);
    }
}
