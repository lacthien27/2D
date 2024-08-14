using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpawner : Spawner
{
  [SerializeField]  private static BrickSpawner  instance;

   [SerializeField] public static BrickSpawner Instance => instance;

    public static string Brick_1  = " Brick_1";
    public static string Brick_2  = " Brick_2";

  public static string Brick_3  = " Brick_3";
  public static string Brick_4  = " Brick_4";
  public static string Brick_5  = " Brick_5";
  public static string Brick_6  = " Brick_6";


    protected override void Awake()
    {
        base.Awake();
        if(BrickSpawner.instance !=null)  Debug.LogError("Only 1 BrickSpawner allow to exist");
        BrickSpawner.instance=this;
    }
}

