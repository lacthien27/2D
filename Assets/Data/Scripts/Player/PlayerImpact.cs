using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class PlayerImpact : PlayerAbs
{
    [SerializeField] protected Rigidbody2D rb2d;
    public Rigidbody2D Rigidbody2D => rb2d;


    [SerializeField] protected Collider2D cl2d;
    public Collider2D Collider2D => cl2d;


    [SerializeField] public int isMove = 0;

    [SerializeField] public Vector3 posObjImpacted;

    [SerializeField] public String nameBrickImpact;

    [SerializeField] public int isReadyBrick = 1;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCl2d();
        this.LoadRb2d();

    }
    protected virtual void LoadCl2d()
    {
        if (this.cl2d != null) return;
        this.cl2d = GetComponent<Collider2D>();
        Debug.LogWarning(transform.name + " : LoadCollider2D", gameObject);
    }
    protected virtual void LoadRb2d()
    {
        if (this.rb2d != null) return;
        this.rb2d = GetComponent<Rigidbody2D>();
        Debug.LogWarning(transform.name + " : LoadRigidbody2D ", gameObject);
    }

    protected void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.parent.name == "Model")
        {
            this.isMove = 1;
            this.posObjImpacted = this.GetPosColliderImpact(other.transform);
        }

        

        if (other.transform.parent.name=="ModelBrick")
        {
            this.isReadyBrick = 0;
            Debug.LogWarning(this.isReadyBrick);
        }
    }
    protected void OnTriggerStay2D(Collider2D other)
    {
        this.isMove = 0;
    }
    protected virtual string GetNameBrickImpact(Transform other)
    {
        return other.transform.parent.name;
    }
    protected virtual Vector3 GetPosColliderImpact(Transform other)
    {
        Vector3 pos = other.transform.position;

        return pos;
    }



}
