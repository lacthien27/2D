using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpawnerCtrl : ThienMonoBehaviour
{



    
    [SerializeField] protected BrickSpawner brickSpawner;

    public BrickSpawner BrickSpawner => brickSpawner;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBrickSpawner();
    }

       protected virtual void LoadBrickSpawner()
    {
        if(this. brickSpawner !=null) return;
        this. brickSpawner =transform.GetComponent< BrickSpawner>();
        Debug.LogWarning(transform.name +" :  LoadBrickSpawner ",gameObject);
    }

      



   





}
