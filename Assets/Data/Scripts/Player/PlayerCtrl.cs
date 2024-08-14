using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : ThienMonoBehaviour
{
    [SerializeField] protected PlayerMove playerMove;

    public PlayerMove PlayerMove => playerMove;

    [SerializeField] protected PlayerRotation playerRotation;

    public PlayerRotation PlayerRotation => PlayerRotation;

     [SerializeField] protected PlayerImpact playerImpact;

    public PlayerImpact PlayerImpact => playerImpact;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPlayerMove();
        this.LoadPlayerRotation();
        this.LoadPlayerImpact();
    }

    protected virtual void LoadPlayerImpact()
    {
       if(this.playerImpact!=null) return;
        this.playerImpact = GetComponentInChildren<PlayerImpact>();
        Debug.LogWarning(transform.name +" : LoadPlayerImpact" ,gameObject);
    }
    


    protected virtual void LoadPlayerRotation()
    {
       if(this.playerRotation!=null) return;
        this.playerRotation = GetComponentInChildren<PlayerRotation>();
        Debug.LogWarning(transform.name +" : LoadPlayerRotation" ,gameObject);
    }
    
    protected virtual void LoadPlayerMove()
    {
       if(this.playerMove!=null) return;
        this.playerMove = GetComponentInChildren<PlayerMove>();
        Debug.LogWarning(transform.name +" : LoadPlayerMove" ,gameObject);
    }






}

