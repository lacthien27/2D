using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientImpact : ThienMonoBehaviour
{
     [SerializeField] protected Rigidbody2D rb2d;
    public Rigidbody2D Rigidbody2D => rb2d;


    [SerializeField] protected Collider2D cl2d;
    public Collider2D Collider2D => cl2d;





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
        Debug.LogWarning(other.transform.parent);

        if(other.transform.parent.gameObject.name=="ModelUnder")
        {



        }

    }

   


}
