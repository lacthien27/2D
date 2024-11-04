using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolDrawCollider : MonoBehaviour
{




    

    private void OnDrawGizmos()
    {
       

        BoxCollider2D collider = GetComponent<BoxCollider2D>();
        if (collider != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireCube(transform.position , collider.size);
        }
    }

}
