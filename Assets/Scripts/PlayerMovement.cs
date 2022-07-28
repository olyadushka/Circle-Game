using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{

   List<Vector2> points = new List<Vector2>() { };

    public float speed = 10f;


    Vector2 lastClicedPos { get; set; }

    bool is_move;

    private void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            
            lastClicedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            points.Add(lastClicedPos);

            is_move = true;
        }


        if (is_move && (Vector2)transform.position != points[0])
        {
            for(var i=0;i<points.Count;i++)
            {
                float step = speed*Time.deltaTime;
                transform.position = Vector2.MoveTowards(transform.position, points[0], step);
                i++;
            }
            if ((Vector2)transform.position == points[0])
            {
                points.RemoveAt(0);
            }




        }
        else { is_move = false;  }
    }
}

  

