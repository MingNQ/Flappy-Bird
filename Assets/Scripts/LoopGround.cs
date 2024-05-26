using UnityEngine;

public class LoopGround : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private float width = 6f;

    private SpriteRenderer spriteRender;
    private Vector2 startSize; 

    private void Awake()
    {
        spriteRender = GetComponent<SpriteRenderer>();
        startSize = new Vector2(spriteRender.size.x, spriteRender.size.y);
    }

    private void Update()
    {
        spriteRender.size = new Vector2(spriteRender.size.x + speed * Time.deltaTime, spriteRender.size.y);

        if (spriteRender.size.x > width)
        {
            spriteRender.size = startSize;
        }
    }
}
