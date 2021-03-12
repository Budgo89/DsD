using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[AddComponentMenu("Camera-Control/MouseLook")]
public class MouseLook : MonoBehaviour
{
    //Выпадающий список для насткоек осей вращения
    [SerializeField]
    private enum RotationAxes { MouseXandxY = 0, MouseX = 1, MouseY = 2 };
    [SerializeField]
    private RotationAxes axes = RotationAxes.MouseXandxY;
    // переменная чувствительности мыши
    [SerializeField]
    private float sensitiviryX = 2f;
    [SerializeField]
    private float sensitiviryY = 2f;
    // максимальный угол вращения оси X
    [SerializeField]
    private float minimumX = -360f;
    [SerializeField]
    private float maximumX = 360f;
    // максимальный угол вращения оси Y
    [SerializeField]
    private float minimumY = -360f;
    [SerializeField]
    private float maximumY = 360f;
    //переменные определяющие текущий угол вращения

    float rotationX = 0f;
    float rotationY = 0f;

    //переменная содержащая тип вращения
    Quaternion originalRotation;

    // Start is called before the first frame update
    void Start()
    {
        if (GetComponent<Rigidbody>())
        {
            GetComponent<Rigidbody>().freezeRotation = true;            
        }
        originalRotation = transform.localRotation;
    }

    public static float ClampAngle (float angle, float min, float max)
    {
        if (angle < -360f) angle += 360f;
        if (angle > 360f) angle -= 360f;
        return Mathf.Clamp(angle, min, max);
    }


    // Update is called once per frame
    void Update()
    {
        if( axes == RotationAxes.MouseXandxY)
        {
            rotationX += Input.GetAxis("Mouse X") * sensitiviryX;
            rotationX += Input.GetAxis("Mouse Y") * sensitiviryY;

            rotationX = ClampAngle(rotationX, minimumX, maximumX);
            rotationY = ClampAngle(rotationY, minimumY, maximumY);
            Quaternion xQuaternion = Quaternion.AngleAxis(rotationX, Vector3.up);
            Quaternion yQuaternion = Quaternion.AngleAxis(rotationY, -Vector3.right);
            transform.localRotation = originalRotation * xQuaternion * yQuaternion;
        }
        else if (axes == RotationAxes.MouseX)
        {
            rotationX += Input.GetAxis("Mouse X") * sensitiviryX;
            rotationX = ClampAngle(rotationX, minimumX, maximumX);
            Quaternion xQuaternion = Quaternion.AngleAxis(rotationX, Vector3.up);
            transform.localRotation = originalRotation * xQuaternion;
        }
        else if (axes == RotationAxes.MouseY)
        {
            rotationY += Input.GetAxis("Mouse Y") * sensitiviryY;
            rotationY = ClampAngle(rotationY, minimumY, maximumY);
            Quaternion yQuaternion = Quaternion.AngleAxis(rotationX, -Vector3.right);
            transform.localRotation = originalRotation * yQuaternion;
        }
    }
}
