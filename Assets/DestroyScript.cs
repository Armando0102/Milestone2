using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour {
    public float meteorCount = 0;
    float rNum1;
    float rNum2;
    float xRange1 = 5.5f;
    float xRange2 = -5.5f;
    float yRange1 = 4.8f;
    float yRange2 = -4.8f;
    Vector2 randomX1;
    Vector2 randomX2;
    Vector2 randomY1;
    Vector2 randomY2;
    GameObject rock;
    void Update()
    {
        rNum1 = Random.Range(xRange1, xRange2);
        rNum2 = Random.Range(yRange1, yRange2);
        randomX1 = new Vector2(rNum1, yRange2);
        randomY1 = new Vector2(xRange2, rNum2);
        randomX2 = new Vector2(rNum1, yRange1);
        randomY2 = new Vector2(xRange1, rNum2);
        if (meteorCount < 10)
        {
            rock = GameObject.Find("Meteor");
            Create();
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Meteor")
        {
            --meteorCount;
        }
        Destroy(collision.gameObject);
    }
    void Create()
    {
        int pick = Random.Range(0, 8);
        if (pick == 0 || pick == 1)
        {
            ++meteorCount;
            GameObject rockCopy = Instantiate(rock, randomX1, Quaternion.identity);
            rockCopy.name = "Meteor";
            Debug.Log(pick);
        }else if (pick == 2 || pick ==3)
        {
            ++meteorCount;
            GameObject rockCopy = Instantiate(rock, randomY1, Quaternion.identity);
            rockCopy.name = "Meteor";
            Debug.Log(pick);
        }
        else if (pick == 4 || pick == 5)
        {
            ++meteorCount;
            GameObject rockCopy = Instantiate(rock, randomX2, Quaternion.identity);
            rockCopy.name = "Meteor";
            Debug.Log(pick);
        }
        else if (pick == 6 || pick == 7)
        {
            ++meteorCount;
            GameObject rockCopy = Instantiate(rock, randomY2, Quaternion.identity);
            rockCopy.name = "Meteor";
            Debug.Log(pick);
        }
    }
}
