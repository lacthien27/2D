using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;
using UnityEditor.VersionControl;

public class IngredientImpact : IngredientAbs

{
    public static event Action OnImpactCollision;  // how much  ingredient impact is relative  signal;

       //public static event Action OnYetImpact; //yet use // how much  ingredient impact is relative  signal;

     [SerializeField] protected Rigidbody2D rb2d;
    public Rigidbody2D Rigidbody2D => rb2d;


    [SerializeField] protected Collider2D cl2d;
    public Collider2D Collider2D => cl2d;


     
    [SerializeField] public List<GameObject> listObjImpact = new List<GameObject>();



        [SerializeField]  protected  bool isCheckList = false;

    
    [SerializeField]  protected  bool isSignalOfEnter = false;



    protected virtual void Settings()
    {
        rb2d.bodyType = RigidbodyType2D.Kinematic;
        this.cl2d.isTrigger =true; 
        transform.gameObject.layer= LayerMask.NameToLayer("Default");
                transform.localScale = new Vector3(0.1f,0.405f,0.1f);
    }

    protected virtual void FixedUpdate()
    {
       // OnYetImpact?.Invoke();  
        //this.checkMissImpact();   
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


    protected virtual void checkMissImpact()
    {
        if( transform.gameObject.layer== LayerMask.NameToLayer("IngredientImpact"))
        {
        Debug.LogWarning("true state");
        if(this.listObjImpact.Count==0)
        
        Debug.LogWarning("state fall");
        
        
        }
    }


    protected void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.layer == transform.gameObject.layer) 
        {
            if (  transform.position.y  > other.gameObject.transform.position.y)
            this.listObjImpact.Add(other.gameObject);
          
            return;  //avoid ingredient from colliding with each other

        }

         
        if(other.transform.parent.name=="IngredientCtrl"||other.transform.parent.name=="ModelUnder") 
        {
        
        if (isSignalOfEnter) return;
            isSignalOfEnter = true;
           if(OnImpactCollision!=null) OnImpactCollision?.Invoke(); // get signal to ModelCompleteCtrl to check trigger
           this.ingredientCtrl.ModelCompleteCtrl.BrickCtrl.StateMachineCtrl.ChangeState(this.ingredientCtrl.ModelCompleteCtrl.BrickCtrl.StateMachineCtrl.StopState);


        }



    }



}
   

  



     
    

  





    


    
        

    












 

   

   



