using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipes;
    float timer = 0;
    public float timeDiff;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDiff)
        {
            GameObject newpipe = Instantiate(pipes);
            newpipe.transform.position = new Vector3(4, Random.Range(-2.5f, 3.0f), 0);
            timer = 0;
            Destroy(newpipe,5.0f);
        }
    }
}
