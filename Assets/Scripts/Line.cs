using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    Vector3 startPos;
    Vector3 endPos;
    Vector3 mousePos;
    Vector3 mouseDir;
    Camera cam;
    LineRenderer lineRenderer;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer=GetComponent<LineRenderer>();
        cam=Camera.main;

        lineRenderer.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        mousePos=cam.ScreenToWorldPoint(Input.mousePosition);
        mouseDir=mousePos-gameObject.transform.position;
        mouseDir.z=0;
        mouseDir=mouseDir.normalized;

        startPos=gameObject.transform.position;
        startPos.z=0;
        lineRenderer.SetPosition(0, startPos);
        endPos=mousePos;
        endPos.z=0;
        lineRenderer.SetPosition(1, endPos);
    }
}
