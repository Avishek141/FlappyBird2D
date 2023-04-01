using UnityEngine;

public class Parralax : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    [SerializeField]private float animationSpeed = 0.05f;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();

    }

    private void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed*Time.deltaTime,0f);
    }
}
