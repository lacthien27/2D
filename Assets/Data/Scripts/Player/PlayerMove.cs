using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TreeEditor;
using UnityEngine;
using UnityEngine.Video;

public class PlayerMove : PlayerAbs
{
    [SerializeField] protected TargetMoved targetMoved;
    public TargetMoved TargetMoved => targetMoved;


    [SerializeField] public Vector3 posMove;

    

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadTargetMoved();

    }

    protected virtual void LoadTargetMoved()
    {
        if(this.targetMoved!=null) return;
        this.targetMoved = GetComponentInChildren<TargetMoved>();
        Debug.LogWarning(transform.name +" : LoadTargetMoved" ,gameObject);
    }


    protected virtual void FixedUpdate() 
    {
        this.GetPosMouse();
        this.Move();
    }
    protected virtual void Move()
    {
      
     Vector3 pos = GetPosMouse();
     this.posMove= new Vector3(pos.x,-4.5f,0);
      transform.parent.position =this.posMove;
      
    }


    protected virtual Vector3 GetPosMouse()
    {
      return   GameCtrl.Instance.InputManager.MouseWorldPos;
    } 



}
