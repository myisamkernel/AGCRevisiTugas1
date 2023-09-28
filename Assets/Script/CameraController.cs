using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    private Vector3 defaultPosition;

    private void Start()
    {
        defaultPosition = transform.position;
        target = null;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            StartCoroutine(MovePosition(target.position, 5));
        }
    }

    public void FocusAtTarget(Transform targetTransform)
    {
        target = targetTransform;

    }

    // belum dipakai
    public void GoBackToDefault()
    {
        target = null;

    }

    private IEnumerator MovePosition(Vector3 target, float time)
    {
        float timer = 0;
        Vector3 start = transform.position;

        while (timer < time)
        {
            transform.position = Vector3.Lerp(start, target, Mathf.SmoothStep(0.0f, 1.0f, timer / time));

            timer += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        transform.position = target;
    }
}
