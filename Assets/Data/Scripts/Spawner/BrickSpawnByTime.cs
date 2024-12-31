using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;
 using System;


public class BrickSpawnByTime : GameAbs
{
    protected override void Start()
    {
     // Raycast.SignalSpawnBrick+=ImplementSpawn;
   // ModelCompleteCtrl.OnSpawnSignal+=ImplementSpawn;
      this.ImplementSpawn();  
    }
    protected virtual void ImplementSpawn()
    {
      Transform newPrefab=   BrickSpawner.Instance.Spawn(BrickSpawner.Instance.RandomPrefab(),GameCtrl.Instance.SpawnPointBrick.PosSpawn,GameCtrl.Instance.SpawnPointBrick.transform.rotation);
        GameCtrl.Instance.PlayerCtrl.PlayerMove.TargetMoved.UpdateLatestBrick(newPrefab);// tells who the player is controlling
        newPrefab.gameObject.SetActive(true);           
    }
  
    protected virtual  void OnDestroy() 
    {
         //  Raycast.SignalSpawnBrick-=ImplementSpawn;

    }


  

    
}
