using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SpawnPointBrick : GameAbs
{
 [SerializeField] protected Vector3 posSpawn;   
    public Vector3  PosSpawn => posSpawn;


    
    protected   virtual void FixedUpdate()
    {
        this.GetPosSpawnByMouse();
        this.PosSpawnPoint();


    }
    
    protected virtual Vector3 GetPosSpawnByMouse()
    {
      Vector3 pos = GameCtrl.Instance.PlayerCtrl.PlayerImpact.posObjImpacted;     // pos của object ImpactEd
      pos.x = Mathf.Clamp(pos.x, -1.6f, 2f);
      this.posSpawn =  new Vector3(pos.x,-1f,0);
     

      return this.posSpawn;
    }


    protected virtual void PosSpawnPoint()
    {
        transform.position = this.posSpawn;
    }

   
}

