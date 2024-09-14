using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;

public class IngredientImpact : IngredientAbs

{
    [SerializeField] protected Vector3 setLocalScale =new Vector3 (0.1f,0.405f,0.1f);
    public static event Action OnImpactStart;

    public static event Action OnImpactExisting;

    public static event Action OnImpactCollision;

     [SerializeField] protected Rigidbody2D rb2d;
    public Rigidbody2D Rigidbody2D => rb2d;


    [SerializeField] protected Collider2D cl2d;
    public Collider2D Collider2D => cl2d;

    
    [SerializeField]  protected  bool isNotifying = false;
    [SerializeField]  protected  bool isNotifyingWall = false;


    protected override void Start()
    {
        base.Start();
        this.Settings();
        OnImpactStart?.Invoke();


        
    }
    protected virtual void Settings()
    {
        rb2d.bodyType = RigidbodyType2D.Dynamic;
        this.cl2d.isTrigger =true; 
        transform.gameObject.layer= LayerMask.NameToLayer("Default");
    }

    protected virtual  void FixedUpdate()
    {
    OnImpactExisting?.Invoke();
    
    }

   protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCl2d();
        this.LoadRb2d();
        transform.localScale = this.setLocalScale;

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
     /**   if (other.gameObject.layer == gameObject.layer)  return; //avoid ingredient from colliding with each other
         
        if(other.transform.parent.name=="ModelUnder"||other.transform.parent.name=="IngredientCtrl") 
        {

        if (isNotifying) return;
        
            isNotifying = true;

            OnImpactCollision?.Invoke();
   
        }**/


          if (other.gameObject.layer == gameObject.layer)  return; //avoid ingredient from colliding with each other
         
        if(other.transform.parent.name=="IngredientCtrl") 
        {

        if (isNotifying) return;
        
            isNotifying = true;

            OnImpactCollision?.Invoke();
   
        }

        if(other.transform.parent.name=="ModelUnder")
        {
              if (isNotifyingWall) return;
        
            isNotifyingWall = true;

            OnImpactCollision?.Invoke();
   
        }
        }


    
        

    }












 

   

   



