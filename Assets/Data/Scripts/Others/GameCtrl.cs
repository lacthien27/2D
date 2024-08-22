using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCtrl : ThienMonoBehaviour
{

    
  [SerializeField]  private static GameCtrl  instance;

   [SerializeField] public static GameCtrl Instance => instance;

   
     [SerializeField] protected PlayerCtrl playerCtrl;

    public PlayerCtrl PlayerCtrl => playerCtrl;

     [SerializeField] protected SpawnPointBrick spawnPointBrick;

    public SpawnPointBrick SpawnPointBrick => spawnPointBrick;

     [SerializeField] protected InputManager inputManager;

    public InputManager InputManager => inputManager;

    
     [SerializeField] protected BrickSpawner brickSpawner;

    public BrickSpawner BrickSpawner => brickSpawner;



     protected override void Awake()
    {
        base.Awake();
        if(GameCtrl.instance !=null)  Debug.LogError("Only 1 GameCtrl allow to exist");
        GameCtrl.instance=this;
    }



        protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPlayerCtrl();
        this.LoadSpawnPointBrick();
        this.LoadInputManager();
        this.LoadBrickSpawner();

    }
   

     protected virtual void LoadBrickSpawner()
    {
        if(this. brickSpawner !=null) return;
        this. brickSpawner =FindAnyObjectByType< BrickSpawner>();
        Debug.LogWarning(transform.name +" : LoadBrickSpawner ",gameObject);
    }
            protected virtual void LoadInputManager()
    {
        if(this.inputManager !=null) return;
        this.inputManager =FindAnyObjectByType< InputManager>();
        Debug.LogWarning(transform.name +" : LoadInputManager ",gameObject);
    } 
    

        protected virtual void LoadSpawnPointBrick()
    {
        if(this.spawnPointBrick !=null) return;
        this.spawnPointBrick =FindAnyObjectByType< SpawnPointBrick>();
        Debug.LogWarning(transform.name +" : LoadPlayerCtrl ",gameObject);
    } 


       protected virtual void LoadPlayerCtrl()
    {
        if(this. playerCtrl !=null) return;
        this. playerCtrl =FindAnyObjectByType< PlayerCtrl>();
        Debug.LogWarning(transform.name +" : LoadPlayerCtrl ",gameObject);
    }
}
