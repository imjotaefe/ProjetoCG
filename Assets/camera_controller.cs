using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_controller : MonoBehaviour
{
    public float unidadeRx, unidadeRy;
    float vr;
    public GameObject player;

    void Start()
    {
        vr = 50f;
        unidadeRx = 0f;
        Cursor.lockState = CursorLockMode.Locked;

    }

    void Update()
    {
        unidadeRx += Input.GetAxis("Mouse Y") * vr * Time.deltaTime;
        unidadeRx = Mathf.Clamp(unidadeRx, -60f, 60f);
        transform.localEulerAngles = new Vector3(-unidadeRx, 0, 0);

        unidadeRy = Input.GetAxis("Mouse X") * vr * Time.deltaTime;
        player.transform.Rotate(0, unidadeRy, 0);
    }
}
