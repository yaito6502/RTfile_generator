using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class Camera : MonoBehaviour
{
    [SerializeField] Vector3 position;
    [SerializeField] Vector3 rotation;
    [SerializeField] float fov;
    [SerializeField] Camera camera;

    public Vector3 Position { get { return position; } }
    public Vector3 Rotation { get { return rotation; } }
    public float Fov { get { return fov; } }

    private void OnValidate()
    {
        Transform transform = this.gameObject.transform;
        transform.position = new Vector3(position.x, position.y, position.z);
        transform.rotation = Quaternion.identity;
        rotation.x = Mathf.Clamp(rotation.x, -1, 1);
        rotation.y = Mathf.Clamp(rotation.y, -1, 1);
        rotation.z = Mathf.Clamp(rotation.z, -1, 1);
        transform.rotation = Quaternion.FromToRotation(Vector3.up, rotation);
        camera.fov = fov;
    }
}
