using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kegel : MonoBehaviour
{
    public GameObject[] kegel;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(-12.0f, 0.5f, 0.0f);

        kegel[0].transform.localPosition = new Vector3(4.0f, 0.0f, 0.0f);
        kegel[1].transform.localPosition = new Vector3(2.0f, 0.0f, -2.0f);
        kegel[2].transform.localPosition = new Vector3(2.0f, 0.0f, 2.0f);
        kegel[3].transform.localPosition = new Vector3(0.0f, 0.0f, -4.0f);
        kegel[4].transform.localPosition = new Vector3(0.0f, 0.0f, 4.0f);
        kegel[5].transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
        kegel[6].transform.localPosition = new Vector3(-2.0f, 0.0f, -2.0f);
        kegel[7].transform.localPosition = new Vector3(-2.0f, 0.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
