using UnityEngine;

public class RandomizeMaterialColor : MonoBehaviour
{
    [SerializeField, Min(0f)] private float interval = 0.1f;

    private Material cachedMaterial;
    private float timer;

    private void Start()
    {
        Renderer r = GetComponent<Renderer>();
        if (r != null)
        {
            cachedMaterial = r.material;
        }
    }

    private void Update()
    {
        if (cachedMaterial == null)
        {
            return;
        }

        if (interval <= 0f)
        {
            cachedMaterial.color = Random.ColorHSV();
            return;
        }

        timer += Time.deltaTime;
        if (timer >= interval)
        {
            timer = 0f;
            cachedMaterial.color = Random.ColorHSV();
        }
    }
}
