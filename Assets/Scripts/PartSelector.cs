using UnityEngine;

public class PartSelector : MonoBehaviour
{
    public Sprite[] parts;
    private SpriteRenderer partRenderer;
    private int currentIndex = 0;

    void Awake()
    {
        partRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log("skripti liitetty objektiin: " + name);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangePart()
    {
        currentIndex = (currentIndex + 1) % parts.Length;
        partRenderer.sprite = parts[currentIndex];
    }

    public int GetIndex()
    {
        return currentIndex;
    }

    public void SetIndex(int newIndex)
    {
        currentIndex = newIndex;
        partRenderer.sprite = parts[currentIndex];
    }
}
