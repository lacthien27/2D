using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;
using UnityEditor.VersionControl;

public class IngredientImpact : IngredientAbs

{
    public static event Action OnImpactCollision;  // how much  ingredient impact is relative  signal;

   //     public static event Action OnExitCollision; //yet use // how much  ingredient impact is relative  signal;

     [SerializeField] protected Rigidbody2D rb2d;
    public Rigidbody2D Rigidbody2D => rb2d;


    [SerializeField] protected Collider2D cl2d;
    public Collider2D Collider2D => cl2d;

    
    [SerializeField]  protected  bool isSignalOfEnter = false;



    protected virtual void Settings()
    {
        rb2d.bodyType = RigidbodyType2D.Kinematic;
        this.cl2d.isTrigger =true; 
        transform.gameObject.layer= LayerMask.NameToLayer("Default");
                transform.localScale = new Vector3(0.1f,0.405f,0.1f);
    }

    
   protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCl2d();
        this.LoadRb2d();
        this.Settings();
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
        if (other.gameObject.layer == transform.gameObject.layer)  return; //avoid ingredient from colliding with each other
         
        if(other.transform.parent.name=="IngredientCtrl"||other.transform.parent.name=="ModelUnder") 
        {
    
        if (isSignalOfEnter) return;
                    Debug.LogWarning("1");

            isSignalOfEnter = true;
           if(OnImpactCollision!=null) OnImpactCollision?.Invoke(); // get signal to ModelCompleteCtrl to check trigger
           
        }

    }


  //  protected void 

        protected virtual void Handle()
        {

        }
    

  


}


    


    
        

    












 

   

   



