using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject explosion;
    private void OnTriggerEnter2D(Collider2D col)
    {
      GameObject e = Instantiate(explosion) as GameObject;
      e.transform.position = transform.position;
      Destroy(col.gameObject);
      this.gameObject.SetActive(false);
    }
}
