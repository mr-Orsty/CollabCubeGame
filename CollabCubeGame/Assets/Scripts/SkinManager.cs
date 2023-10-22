using UnityEngine;

public class SkinManager : MonoBehaviour
{
    public SpriteRenderer targetRenderer;
    public Sprite[] skins;

    private int selectedSkinIndex = 0;

    private void Start()
    {
        selectedSkinIndex = PlayerPrefs.GetInt("SelectedSkin", 0);
        ChangeSkin(selectedSkinIndex);
    }

    public void ChangeSkin(int skinIndex)
    {
        if (skinIndex >= 0 && skinIndex < skins.Length)
        {
            targetRenderer.sprite = skins[skinIndex];
        }
    }
}
