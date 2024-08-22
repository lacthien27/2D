using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientImpact : BrickAbs
{
     [SerializeField] protected Rigidbody2D rb2d;
    public Rigidbody2D Rigidbody2D => rb2d;


    [SerializeField] protected Collider2D cl2d;
    public Collider2D Collider2D => cl2d;


    public  bool  isImpacted= false;

    [SerializeField] protected List<BrickObserver> observers = new List<BrickObserver>();

    protected override void Start()
    {
        base.Start();
        this.ObserverStart();
    }

    protected virtual  void FixedUpdate()
    {
        if(this.isImpacted==true)return;
        this.ObserverExisting();
    }


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




    protected void OnCollisionEnter2D(Collision2D other) 
    {

      this.isImpacted = true;
      this.ObserverImpacted();
    }


     public virtual void ObjServerAdd(BrickObserver observer)
    {
        this.observers.Add(observer);
    }
    
    protected virtual void  ObserverStart()
    {
        foreach (BrickObserver observer in this.observers)
        {
            observer. ObserverStart();

        }
    }

     protected virtual void ObserverExisting()
    {
        foreach (BrickObserver observer in this.observers)
        {
            observer.ObserverExisting();

        }
    }


     protected virtual void ObserverImpacted()
    {
        foreach (BrickObserver observer in this.observers)
        {
            observer.ObserverImpacted();

        }
    }

   

   


}
