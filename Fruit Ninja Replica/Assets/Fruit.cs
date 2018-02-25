using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour {


    public GameObject fruitSlicedPrefab;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Blade")
        {
            Debug.Log("HIT");
            Vector3 direction = (col.transform.position - transform.position).normalized;

            Quaternion rotation = Quaternion.LookRotation(direction);

            Instantiate(fruitSlicedPrefab, transform.position, rotation);
            Destroy(gameObject);
        }
    }
}
