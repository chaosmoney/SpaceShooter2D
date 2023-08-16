using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMain : MonoBehaviour
{
    [SerializeField]
    private Enemy enemy;
    [SerializeField]
    private Bullet bullet;
    [SerializeField]
    private List<GameObject> item;
    // Start is called before the first frame update
    void Start()
    {
        Enemy ene = Instantiate(enemy);
        ene.transform.position = Vector3.zero;
        ene.die = () =>
        {
            GameObject go = Instantiate(item[2]);
            go.transform.position = ene.transform.position;
            Destroy(ene.gameObject);
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
