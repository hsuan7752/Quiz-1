using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject tinyExplosionPrefab;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.position = new Vector3(40.0f, 2.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            this.GetComponent<Rigidbody>().AddForce(Vector3.left * speed);

        if (Input.GetKey(KeyCode.A))
            this.GetComponent<Rigidbody>().AddForce(Vector3.back * speed);

        if (Input.GetKey(KeyCode.D))
            this.GetComponent<Rigidbody>().AddForce(Vector3.forward * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 11)
        {
            this.gameObject.SetActive(false);
            tinyExplosionPrefab.transform.position = this.transform.position;
            Instantiate(tinyExplosionPrefab, transform.position, transform.rotation);
            Destroy(tinyExplosionPrefab);
            Destroy(gameObject);
        }
    }
}
