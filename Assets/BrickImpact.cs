using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class BrickImpact : BrickAbs
{
       [SerializeField]   public int angle =0; 

     [SerializeField] protected Rigidbody2D rb2d;
    public Rigidbody2D Rigidbody2D => rb2d;

        public static event Action OnImpactCollision;



    [SerializeField] protected CompositeCollider2D cl2d;
    public CompositeCollider2D Collider2D => cl2d;
   protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCl2d();
        this.LoadRb2d();

    }

    protected virtual void LoadCl2d()
    {
        if (this.cl2d != null) return;
        this.cl2d = GetComponent<CompositeCollider2D>();
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
        Debug.LogWarning(other.transform.parent.name);
        if(other.transform.parent.name=="WallImpact") 
        {

            Debug.LogWarning("h");
            OnImpactCollision?.Invoke();

           
        }

      
    }

    protected void Update() 
    {

       
    }


}

