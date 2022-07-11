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
            // �߷��� ���ش�. (������ ���ư���)
            _rb.useGravity = false;
            // �Ѿ� ������ (clone)
            Missile = Instantiate(MissileFactory);

            // �Ѿ� �ӵ�
            _rb = Missile.GetComponent<Rigidbody>();
            _rb.AddForce(1000, 0, 0);

            // �Ѿ��� ������ ��ġ
            Missile.transform.position = FirePosition.transform.position;
            // ��ü�� ȸ���ϸ� �Ѿ˵� ȸ���Ѵ�.
            //FirePosition.transform.rotation = Helicopter.transform.rotation;

            //Destroy(Missile, 3f);
        }
    }
}
