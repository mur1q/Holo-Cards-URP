using UnityEngine;

public class CardIdleAnimation : MonoBehaviour
{
    public Vector3 _autoRotationAmplitude = new Vector3(2f, 2f, 2f);
    public Vector3 _autoRotationFrequency = new Vector3(0.8f, 0.7f, 0.9f);

    private Quaternion _baseRotation;

    void Start()
    {
        _baseRotation = transform.rotation;
    }

    void Update()
    {
        float time = Time.time;

        float rotX = _autoRotationAmplitude.x * Mathf.Sin(time * _autoRotationFrequency.x * 2f * Mathf.PI);
        float rotY = _autoRotationAmplitude.y * Mathf.Sin(time * _autoRotationFrequency.y * 2f * Mathf.PI + 0.3f);
        float rotZ = _autoRotationAmplitude.z * Mathf.Sin(time * _autoRotationFrequency.z * 2f * Mathf.PI + 1.1f);

        Quaternion offset = Quaternion.Euler(rotX, rotY, rotZ);
        transform.rotation = _baseRotation * offset;
    }
}