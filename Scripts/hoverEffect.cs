using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class hoverEffect : MonoBehaviour,IPointerEnterHandler, IPointerExitHandler
{
    public Text targetImage; // Reference the image component
    public Color hoverColor; // Color for the hover effect

    private Color originalColor; // Store the original color
    // Start is called before the first frame update
    void Start()
    {
        originalColor = targetImage.color; // Store the initial color
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
       // Change color on hover to D9BB41 (hex code)
        targetImage.color = new Color(0xD9 / 255f, 0xBB / 255f, 0x41 / 255f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        targetImage.color = new Color(0xFF, 0x00, 0x00);// Restore original color on exit
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
