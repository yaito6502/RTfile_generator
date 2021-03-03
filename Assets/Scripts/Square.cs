using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(MeshRenderer))]
public class Square : MonoBehaviour
{
    [SerializeField] Vector3 position;
    [SerializeField] Vector3 rotation;
    [SerializeField] float sidesize;
    [SerializeField] Color32 color;
    [SerializeField] Material material;

    public Vector3 Position { get { return position; } }
    public Vector3 Rotation { get { return rotation; } }
    public float Sidesize { get { return sidesize; } }
    public Color32 Color { get { return color; } }

    private void OnValidate()
    {
        Transform transform = this.gameObject.transform;
        transform.position = new Vector3(position.x, position.y, position.z);
        transform.localScale = new Vector3(sidesize, sidesize, sidesize);
        transform.rotation = Quaternion.identity;
        rotation.x = Mathf.Clamp(rotation.x, -1, 1);
        rotation.y = Mathf.Clamp(rotation.y, -1, 1);
        rotation.z = Mathf.Clamp(rotation.z, -1, 1);
        transform.rotation = Quaternion.FromToRotation(Vector3.forward, rotation);
        material.color = new Color32(color.r, color.g, color.b, color.a);
    }
}