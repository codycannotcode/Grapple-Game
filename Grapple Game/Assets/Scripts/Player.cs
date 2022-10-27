using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 _position;
    public GameObject anchorPrefab;
    private Anchor anchor;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject a;
            a= Instantiate(anchorPrefab, this.transform.position, Quaternion.identity);
            float angle = Mathf.Atan2(
                Input.mousePosition.y - transform.position.y,
                Input.mousePosition.x - transform.position.x);
            anchor = a.GetComponent<Anchor>();
            anchor.setAngle(angle);
        }
    }

    public Vector2 getPosition()
    {
        return _position;
    }
}
