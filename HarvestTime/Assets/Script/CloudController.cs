using System.Collections;
using System.Collections.Generic;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.UI;

public class CloudController : MonoBehaviour
{
    [SerializeField] GameObject drop;
    Vector3 targetPos = new Vector3(5, 7, 0);
    public float cloudSpeed;
    public float rainSpeed;
    bool rain = true;

    private void Awake()
    {
        StartCoroutine(DropGenerator());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CloudMove();
    }

    // cloudun hareketini yapar
    void CloudMove()
    {
        if (transform.position != targetPos)
        {
            transform.position = new Vector3(transform.position.x + cloudSpeed, transform.position.y, transform.position.z);
        }
        else
        {
            rain = false;
        }
    }

    // drop uretir
    IEnumerator DropGenerator()
    {
        while (rain)
        {
            yield return new WaitForSeconds(rainSpeed);

            Vector3 dropPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            Instantiate(drop, dropPos, Quaternion.identity);
        }
    }

    // droplari destroy eder
    public void DropDeffender(GameObject drop)
    {
        Destroy(drop);
    }
}
