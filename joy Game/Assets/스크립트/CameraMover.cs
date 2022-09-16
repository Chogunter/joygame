using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public float speed = 1f;
    private float s;

    public bool DoGuUSING = false;
    public bool ishelgi = false;

    GameObject parent;

    [SerializeField]
    private float min;
    [SerializeField]
    private float max;

    public float xRotate = 0.0f;

    [SerializeField] Vector3 or_pos;
    [SerializeField] Vector3 shakepos;
    [SerializeField] Vector3 Max_shakepos;
    float shakestime;
    public float shakedegree;
    float degrees;

    private void Start()
    {
        parent = transform.parent.gameObject;
        or_pos = transform.localPosition;
    }

    void Update()
    {
        speed = transform.parent.GetComponent<PlayerOption>().Moussegamdo;
        if (!DoGuUSING && !ishelgi)
        {
            float xRotateSize = -Input.GetAxis("Mouse Y") * speed;
            xRotate = Mathf.Clamp(xRotate + xRotateSize, min, max);
            transform.localRotation = Quaternion.Euler(xRotate, 0, 0);
        }
    }
    private void FixedUpdate()
    {
        if (shakestime > 0)
        {
            screen_shakes(degrees);
            shakestime -= Time.fixedDeltaTime;
        }
        else
        {
            transform.localPosition = or_pos;
            shakestime = 0;
        }
    }

    public void screen_shake(float degree, float time)
    {
        if(shakestime > 0)
        {
            return;
        }
        degrees = degree;
        shakestime = time;
    }

    void screen_shakes(float degree)
    {
        float x = Random.Range(-Max_shakepos.x * degree, Max_shakepos.x * degree);
        float y = Random.Range(-Max_shakepos.y * degree, Max_shakepos.y * degree);

        Vector3 randpos = new Vector3(x, y, 0);
        transform.localPosition = or_pos + randpos;
    }
}
