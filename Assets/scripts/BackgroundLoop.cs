using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    private float width;
    private void Awake()
    {
        BoxCollider2D BackgroundCollider = GetComponent<BoxCollider2D>();
        width = BackgroundCollider.size.x;
    }


    private void Reposition()
    {
        Vector2 offset = new Vector2(width * 2f, 0);
        transform.position = (Vector2)transform.position + offset;
    }
    void Update()
    {
        if (transform.position.x <= -width)
        {
            Reposition();
        }
       
    }
}
