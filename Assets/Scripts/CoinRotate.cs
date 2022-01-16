using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinRotate : MonoBehaviour
{
    [SerializeField] float speedx;
    [SerializeField] float speedy;
    [SerializeField] float speedz;
    [SerializeField] Text Cointext;







    void Update()
    {

        transform.Rotate(360 * speedx * Time.deltaTime, 360 * speedy * Time.deltaTime, 360 * speedz * Time.deltaTime);
       /*transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
        //  rb = transform.Rotate(Vector3.right * Time.deltaTime,0,0,Space.Self);*/

    }
}
