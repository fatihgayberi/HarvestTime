using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderController : MonoBehaviour
{
    [SerializeField] GameObject pumpkin;
    public float moveSped;
    bool spiderStop;
    Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        SpiderMove();
    }

    // spider hareketini saglar
    void SpiderMove()
    {
        if (!spiderStop)
        {
            transform.position = Vector3.Lerp(transform.position, pumpkin.transform.position, Time.deltaTime * moveSped);
        }
    }

    // spider in pumpkine temas edip atack yapmasını kontrol eder
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pumpkin"))
        {
            spiderStop = true;
            anim.Play("Attack");
        }
    }

    // spider in olmesini saglar
    public void Death()
    {
        GetComponent<Collider>().enabled = false;
        anim.Play("Death");
        spiderStop = true;
    }
}
