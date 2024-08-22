using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class TargetMoved :  GameAbs
{
   [SerializeField] public Transform target; 
    public void UpdateLatestBrick(Transform newBrick)
{
    target = newBrick;
}


    protected  void FixedUpdate() 
    {
        //this.LoadSynMoveOfBrick();
    }

    protected virtual void LoadSynMoveOfBrick()
    {
         Vector3 synMove =  GameCtrl.Instance.PlayerCtrl.transform.parent.position;


        this.target.transform.parent.position= new Vector3(this.target.transform.parent.position.x,this.target.transform.parent.position.y,synMove.z);
    }





}





