using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Start()
    {
        Destroy(this.gameObject, 4.0f);
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
    }

    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    Debug.Log("Hit");
    //    //make player move with bubble
    //    if (other.gameObject.tag == "Player")
    //    {
    //        other.gameObject.transform.parent = this.transform;
    //        //other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
    //    }
    //}
    //private void OnTriggerExit2D(Collider2D other)
    //{
    //    Debug.Log("Hit");
    //    //make player move with bubble
    //    if (other.gameObject.tag == "Player")
    //    {
    //        other.gameObject.transform.parent = null;
    //        //other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
    //    }
    //}
}
