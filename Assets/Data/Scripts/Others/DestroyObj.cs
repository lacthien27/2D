using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using System;
using UnityEngine.Video;
public class DestroyObj : ThienMonoBehaviour
{
 
    protected override void Start()
    {
        base.Start();
        Raycast.SignalDestroyBrick+=Destroyy;

    }

    protected virtual void Destroyy(GameObject hitObject)
    {
                Destroy(hitObject.transform.parent.gameObject);


    }

    protected virtual void OnDestroy() 
    {
               Raycast.SignalDestroyBrick-=Destroyy;
               

    }


}
