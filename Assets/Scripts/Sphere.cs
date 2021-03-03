using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(MeshRenderer))]
public class Sphere : MonoBehaviour
{
    [SerializeField] Vector3 position;
    [SerializeField] float diameter;
    [SerializeField] Color32 color;
    [SerializeField] Material material;

    public Vector3 Position { get { return position; } }
    public float Diameter { get { return diameter; } }
    public Color32 Color { get { return color; } }

    private void OnValidate()
    {
        Transform transform = this.gameObject.transform;
        transform.position = new Vector3(position.x, position.y, position.z);
        diameter = Mathf.Clamp(diameter, 0.0f, float.PositiveInfinity);
        transform.localScale = new Vector3(diameter, diameter, diameter);
        material.color = new Color32(color.r, color.g, color.b, color.a);
    }
}
