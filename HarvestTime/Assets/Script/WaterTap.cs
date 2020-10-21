using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterTap : MonoBehaviour
{
    [SerializeField] GameObject valve;
    [SerializeField] Slider waterSlider;
    public float positiveWater;
    public float negativeWater;

    // Start is called before the first frame update
    void Start()
    {
        waterSlider.value = 2.5f; // water optimum seviyesi
    }

    // Update is called once per frame
    void Update()
    {
        SoldierBar();
    }

    // muslugun vanasini dondurur ve su seviyesini yukseltir
    public void Irrigation()
    {
        waterSlider.value += Time.deltaTime * positiveWater;
        valve.transform.Rotate(0, 0.5f, 0, Space.World);
    }

    // su seviyesinin surekli dusmesini saglar
    void SoldierBar()
    {
        waterSlider.value -= Time.deltaTime * negativeWater;
    }
}
