using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Enemy : MonoBehaviour
{
    public Action die;
    private Animator anim;

    private void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "Bullet")
        {
            this.StartCoroutine(this.WaitToDie());
        }
    }

    private IEnumerator WaitToDie()
    {
        this.anim.SetTrigger("Trigger");
        yield return new WaitForSeconds(0.6f);
        die();
    }
}
