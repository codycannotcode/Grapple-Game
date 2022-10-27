using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticRope : MonoBehaviour
{
    Player player;
    private float length;
    private float angle;
    private Vector2 anchorPosition;

    [SerializeField]
    [Range(0,1)]
    private float grapplePointSpeed;

    [SerializeField]
    private float ropeMaxLength;
    
    // Start is called before the first frame update
    void Start()
    {
        Vector3 mousePosition = Input.mousePosition;
        angle = Mathf.Atan2(
            mousePosition.y - player.getPosition().y,
            mousePosition.x - player.getPosition().x);
        anchorPosition = player.getPosition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float getDistance()
    {
        return Vector2.Distance(player.getPosition(), anchorPosition);
    }
    
    
}
