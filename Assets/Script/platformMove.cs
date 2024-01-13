using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class platformMove : MonoBehaviour
{
    public Transform pos1, pos2, startpos;
    Vector3 nextPos;
    public float speed = 1.0f;
    void Start()
    {
        nextPos = startpos.position;
    } 
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime); 
        if (transform.position == pos1.position)
        {
            nextPos = pos2.position;
        }else if(transform.position == pos2.position)
        {
            nextPos = pos1.position;
        }
    }
    private void OnDrawGizmoz()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);
    }
}

