using System.Runtime.Serialization;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D rb;

    public Vector2 movement;
    public float moveSpeed= 3f;
    public GameObject explosion;

    
    // Start is called before the first frame update
    void Start(){
      rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      movement.x = Input.GetAxisRaw("Horizontal");
      movement.y= Input.GetAxisRaw("Vertical");
      // float h = Input.GetAxis("Horizontal");
      // float v = Input.GetAxis("Vertical");
      // movement.x= h;
      // movement.y=v;
      // rb.AddForce(movement *moveSpeed);

    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
      GameObject e = Instantiate(explosion) as GameObject;
      e.transform.position = transform.position;
      Destroy(col.gameObject);
      this.gameObject.SetActive(false);
    }
}
