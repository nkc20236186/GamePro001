using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KintamaGenerator : MonoBehaviour
{
    public GameObject kintamaPrefab;
    float span = 0.4f;
    float delta = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(kintamaPrefab);
            int px = Random.Range(-4, 4);
            go.transform.position = new Vector3(12, px, 0);
        }
    }
}
