using System.Collections;
using System.Collections.Generic;
using Mono.Cecil;
using UnityEngine;

public class Anchor : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 position;
    private float angle;
    private bool isAttatched;

    [SerializeField] private double velocity;
    
    void Start()
    {
        isAttatched = false;
        Debug.Log("Sup Bitch");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void setVelocity(Vector2 velocity)
    {
        GetComponent<Rigidbody2D>().velocity = velocity;
    }

    public void setAngle(float angle)
    {
        this.angle = angle;
        
        GetComponent<Rigidbody2D>().velocity = new Vector2(
            Mathf.Sin(angle) * (float)velocity,
            Mathf.Sin(angle) * (float)velocity
            );
    }
}
