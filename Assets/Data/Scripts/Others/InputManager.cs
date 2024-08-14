using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class InputManager : ThienMonoBehaviour
{


    [SerializeField] private static InputManager  instance;

     [SerializeField] public static InputManager Instance => instance;

      [SerializeField] protected Vector3 mouseWorldPos;   
    public Vector3  MouseWorldPos => mouseWorldPos;
    
    [SerializeField] public bool hardDrop;
    [SerializeField] public bool changeDirection;

    [SerializeField] public bool isButtonClickedLeft= false;
        [SerializeField] public bool isButtonClickedRight= false;




    protected override void Awake()
    {
        base.Awake();
        if(InputManager.instance !=null)  Debug.LogError("Only 1 InputManager allow to exist");
        InputManager.instance=this;
    }
    


    protected virtual void Update()
    {
        this.GetMouseLeft();
        this.GetMouseRight();
        
    }
  
    protected   virtual void FixedUpdate()
    {
        this.GetMousePos();
    }
    protected virtual void GetMouseLeft()
    {
        if (Input.GetMouseButtonDown(0) && !isButtonClickedLeft)          
        {
             isButtonClickedLeft = true;
            Debug.LogWarning("left");
        }
         if(Input.GetMouseButtonUp(0))
        {
            isButtonClickedLeft =false;
        }
    
    }

    protected virtual void GetMouseRight()
    {
        if (Input.GetMouseButtonDown(1) && !isButtonClickedRight)          
        {
             isButtonClickedRight = true;
            Debug.LogWarning("RIght");
        }
         if(Input.GetMouseButtonUp(0))
        {
            isButtonClickedRight =false;
        }
    
    }


        


    protected virtual void GetMousePos()
    {
        this.mouseWorldPos =Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
