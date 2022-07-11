using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileSpawner : MonoBehaviour
{
    public GameObject MissileFactory;
    public GameObject Missile;
    public GameObject FirePosition;
    public GameObject Helicopter;
    Rigidbody _rb;
    void Start()
    {
        _rb = Missile.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 중력을 없앤다. (무한히 날아가게)
            _rb.useGravity = false;
            // 총알 생성자 (clone)
            Missile = Instantiate(MissileFactory);

            // 총알 속도
            _rb = Missile.GetComponent<Rigidbody>();
            _rb.AddForce(1000, 0, 0);

            // 총알이 나가는 위치
            Missile.transform.position = FirePosition.transform.position;
            // 본체가 회전하면 총알도 회전한다.
            //FirePosition.transform.rotation = Helicopter.transform.rotation;

            //Destroy(Missile, 3f);
        }
    }
}
