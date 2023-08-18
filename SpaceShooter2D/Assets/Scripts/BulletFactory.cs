using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFactory : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [SerializeField]
    private Bullet bullet;

    private int level = 0;

    private void Update()
    {
        switch (level)
        {
            case 0:
                MakeBullet();
                break;
            case 1:
                MakeBullet1();
                break;
            case 2:
                MakeBullet2();
                break;
            case 3:
                MakeBullet3();
                break;
            case 4:
                MakeBullet4();
                break;
        }
    }
    private void MakeBullet()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Bullet bl = Instantiate(bullet);
            bl.transform.position = this.player.position + Vector3.up;
        }
    }
    private void MakeBullet1()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Bullet bl1 = Instantiate(bullet);
            Bullet bl2 = Instantiate(bullet);
            bl1.transform.position = this.player.position + Vector3.up +Vector3.left * 0.125f;
            bl2.transform.position = this.player.position + Vector3.up +Vector3.right*0.125f;
        }
    }
    private void MakeBullet2()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Bullet bl = Instantiate(bullet);
            bl.transform.position = this.player.position + Vector3.up;
            Bullet bl1 = Instantiate(bullet);
            Bullet bl2 = Instantiate(bullet);
            bl1.transform.position = this.player.position + Vector3.up + Vector3.left * 0.25f;
            bl2.transform.position = this.player.position + Vector3.up + Vector3.right * 0.25f;
        }
    }
    private void MakeBullet3()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Bullet bl = Instantiate(bullet);
            bl.transform.position = this.player.position + Vector3.up;
        }
    }
    private void MakeBullet4()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Bullet bl = Instantiate(bullet);
            bl.transform.position = this.player.position + Vector3.up;
        }
    }
    public void LevelUp()
    {
        this.level += 1;
    }
}
