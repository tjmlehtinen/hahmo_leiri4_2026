using UnityEngine;
using UnityEngine.UI;

public class ColorChooser : MonoBehaviour
{
    private PartSelector part;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (Button colorButton in GetComponentsInChildren<Button>())
        {
            Color color = colorButton.GetComponent<Image>().color;
            colorButton.onClick.AddListener(() =>
            {
                part?.SetColor(color);
            });
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetPart(PartSelector part)
    {
        this.part = part;
    }
}
