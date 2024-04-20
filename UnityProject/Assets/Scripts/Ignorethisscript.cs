using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
public class Ignorethisscript : MonoBehaviour
{
    public Color gizmoColor = Color.yellow;

    private BoxCollider boxCollider;

    private void Start()
    {
        InitializeBoxCollider();
    }

    private void InitializeBoxCollider()
    {
        boxCollider = GetComponent<BoxCollider>();
        if (boxCollider == null)
        {
            boxCollider = gameObject.AddComponent<BoxCollider>();
        }
    }

    private void OnDisable()
    {
        if (boxCollider != null && Application.isPlaying)
        {
            Destroy(boxCollider);
        }
    }


    private void Update()
    {
        if (!Application.isPlaying && transform.hasChanged)
        {
            transform.hasChanged = false;
        }
    }

    private void OnDrawGizmos()
    {
        if (boxCollider != null)
        {
            // Double the intensity of the color
            Color doubledIntensityColor = gizmoColor * 1f;

            Gizmos.color = doubledIntensityColor;
            Gizmos.DrawCube(transform.position + boxCollider.center, boxCollider.size);
        }
        else
        {
            // Double the intensity of the color
            Color doubledIntensityColor = gizmoColor * 2f;

            Gizmos.color = doubledIntensityColor;
            Gizmos.DrawCube(transform.position, Vector3.one);
        }
    }
}
