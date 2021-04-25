using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    // Start is called before the first frame update
    [HideInInspector]
    public float speed;

    private Rigidbody2D myBody;

    private void Awake() {
        myBody = gameObject.GetComponent<Rigidbody2D>();
        speed = 7f;
    }

    private void FixedUpdate() {
        myBody.velocity = new Vector2(speed, myBody.velocity.y);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
