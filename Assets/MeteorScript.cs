using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorScript : MonoBehaviour {
    GameObject target;
    float rSpeed = 360;
    float fSpeed = 0.5f;
	void Start () {
        target = GameObject.Find("PlayerShip");
        Vector3 vectorToTarget = target.transform.position - transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(angle + 90, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * rSpeed);
    }

    void Update () {
        transform.position -= transform.up * Time.deltaTime * fSpeed;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        --GameObject.Find("PlayZone").GetComponent<DestroyScript>().meteorCount;
        Destroy(col.gameObject);
        Destroy(gameObject);
    }
}
