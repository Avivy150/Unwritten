using UnityEngine;

[ExecuteInEditMode]
public class OrderInLayer : MonoBehaviour
{
    public int sortingOrder;
    private SpriteRenderer spriteRenderer;
    public float multiplier = 50f;
    /// This is the difference between the very bottom of the sprite and the bottom of the frame 
	public int bottomOffset = 0;
    public bool setCustomSortingOrder = false;
    public int customSortingOrder;

    // Use this for initialization
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (spriteRenderer)
        {
            if (!setCustomSortingOrder)
            {
                spriteRenderer.sortingOrder = CalculateOrderInLayer();
            }
            else if (setCustomSortingOrder)
            {
                spriteRenderer.sortingOrder = customSortingOrder;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (spriteRenderer)
        {
            if (!setCustomSortingOrder)
            {
                sortingOrder = CalculateOrderInLayer();

                if (spriteRenderer.sortingOrder != sortingOrder)
                {
                    spriteRenderer.sortingOrder = sortingOrder;
                }
            }
            else if (setCustomSortingOrder)
            {
                spriteRenderer.sortingOrder = customSortingOrder;
            }
        }
    }

    int CalculateOrderInLayer()
    {
        int order = Mathf.RoundToInt(-((spriteRenderer.sprite.bounds.size.y - bottomOffset) - spriteRenderer.sprite.bounds.max.y) + (transform.localPosition.y * multiplier)) * -1;

        return order;
    }
}
