using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{   
    public float speed;
    public Rigidbody2D rb;
    public Vector2 startPosition;
    private float x , y ;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        launch(); 
    }

    private void launch ()
    {
        x = Random.Range(0,2) == 0 ? -1 : 1 ;
        y = Random.Range(0,2) == 0 ? -1 : 1 ;
        rb.velocity = new Vector2 (speed *x , speed *y);

    }
    // Update is called once per frame
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        launch();
    }
}
