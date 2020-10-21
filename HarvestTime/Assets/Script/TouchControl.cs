using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControl : MonoBehaviour
{
    SpiderController spiderController;
    CloudController cloudController;
    WaterTap waterTap;

    // Update is called once per frame
    void Update()
    {
        Touch();
    }

    // dokulan objenin ne oldugunu anlayarak gerekli islemleri yapar
    void Touch()
    {     
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            if (hit.transform.CompareTag("Spider"))
            {
                spiderController = FindObjectOfType<SpiderController>();
                spiderController.Death();
            }
            if (hit.transform.CompareTag("Drop"))
            {
                cloudController = FindObjectOfType<CloudController>();
                cloudController.DropDeffender(hit.transform.gameObject);
            }
            if (hit.transform.CompareTag("Tap"))
            {
                waterTap = FindObjectOfType<WaterTap>();
                waterTap.Irrigation();
            }
        }    
    }
}
