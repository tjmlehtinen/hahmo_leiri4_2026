using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public PartSelector hair;
    public PartSelector eyes;
    public PartSelector mouth;
    public PartSelector head;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LoadCharacter();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SavePart(PartSelector part, string id)
    {
        PlayerPrefs.SetInt(id + "sprite", part.GetIndex());
    }

    private void LoadPart(PartSelector part, string id)
    {
        int loadedIndex = PlayerPrefs.GetInt(id + "sprite", 0);
        part.SetIndex(loadedIndex);
    }

    public void SaveCharacter()
    {
        SavePart(hair, "hair");
        SavePart(eyes, "eyes");
        SavePart(mouth, "mouth");
        SavePart(head, "head");
    }

    public void LoadCharacter()
    {
        LoadPart(hair, "hair");
        LoadPart(eyes, "eyes");
        LoadPart(mouth, "mouth");
        LoadPart(head, "head");
    }
}
