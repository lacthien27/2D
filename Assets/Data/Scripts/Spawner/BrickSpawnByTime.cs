using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

public class BrickSpawnByTime : ThienMonoBehaviour
{
    [SerializeField] protected float time=3f;
    protected override void Start()
    {
       // InvokeRepeating("ImplementSpawn",2f,2f);
    }



    protected virtual void ImplementSpawn()
    {
    if(GameCtrl.Instance.PlayerCtrl.PlayerImpact.isReadyBrick==0) return;
      Transform newPrefab=   BrickSpawner.Instance.Spawn(BrickSpawner.Instance.RandomPrefab(),GameCtrl.Instance.SpawnPointBrick.PosSpawn,GameCtrl.Instance.SpawnPointBrick.transform.rotation);
        newPrefab.gameObject.SetActive(true);
    }

  

    
}
