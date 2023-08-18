using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float moveSpeed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
        Vector3 worldPos = Camera.main.WorldToViewportPoint(this.transform.position);
        if (worldPos.y > 1f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
    }
}
