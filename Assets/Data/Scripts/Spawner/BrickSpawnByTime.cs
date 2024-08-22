using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

public class BrickSpawnByTime : GameAbs
{
    protected override void Start()
    {
        InvokeRepeating("ImplementSpawn",2f,7f);
    }



    protected virtual void ImplementSpawn()
    {
    if(GameCtrl.Instance.PlayerCtrl.PlayerImpact.isReadyBrick==0) return;

    
      Transform newPrefab=   BrickSpawner.Instance.Spawn(BrickSpawner.Instance.RandomPrefab(),GameCtrl.Instance.SpawnPointBrick.PosSpawn,GameCtrl.Instance.SpawnPointBrick.transform.rotation);
        GameCtrl.Instance.PlayerCtrl.PlayerMove.TargetMoved.UpdateLatestBrick(newPrefab);// tells who the player is controlling
        newPrefab.gameObject.SetActive(true);
    }



  

    
}
