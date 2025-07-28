using UnityEngine;

public class AlturaMinMax : MonoBehaviour
{
    public Transform targetObject;
    public float minScale = 0.5f;
    public float maxScale = 2.0f;

    public void SetScale(float value)
    {
        if (targetObject == null)
        {
            Debug.LogWarning("targetObject está NULL!");
            return;
        }

        float scale = Mathf.Lerp(minScale, maxScale, value);
        Vector3 newScale = new Vector3(scale, scale, scale);
        targetObject.localScale = newScale;

        Debug.Log($"SetScale chamado: value={value}, scale={scale}");
    }
}
