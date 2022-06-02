using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyToOption : MonoBehaviour
{
    public GameObject Infor;
    // Start is called before the first frame update
    void Start()
    {
        Infor.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            Infor.gameObject.SetActive(true);
        }
    }
}
