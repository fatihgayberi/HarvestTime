using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Harvest : MonoBehaviour
{
    [SerializeField] Slider harvestSlider;
    [SerializeField] GameObject spider;
    [SerializeField] GameObject cloud;
    float spiderCaseTime = 3;
    float cloudCaseTime = 10;
    bool spiderEnd;
    bool cloudEnd;

    // Update is called once per frame
    void Update()
    {
        Harvester();
    }

    // harvest sliderinin dolmasını ve seviyesine gore olaylarin gerceklesmesini saglar
    public void Harvester()
    {
        harvestSlider.value += Time.deltaTime;

        if (harvestSlider.value > spiderCaseTime && !spiderEnd)
        {
            spider.SetActive(true);
            spiderEnd = true;
        }

        if (harvestSlider.value > cloudCaseTime && !cloudEnd)
        {
            cloud.SetActive(true);
            cloudEnd = true;
        }
    }
}
