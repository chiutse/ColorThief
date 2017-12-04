using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Demo : MonoBehaviour {

	public Texture2D texture;
	public RawImage image;
	public Image dominantColor;
	public Image[] paletteColors;

	public string imagePath;

	// Use this for initialization
	IEnumerator Start () {
		WWW www = new WWW(imagePath);
		yield return www;
		if(string.IsNullOrEmpty(www.error))
		{
			texture = www.texture;
			image.texture = texture;
			image.SetNativeSize();
			var dominant = new ColorThief.ColorThief();
			dominantColor.color = dominant.GetColor(texture).Color.ToColor();
			
			var palette = new ColorThief.ColorThief();
			List<ColorThief.QuantizedColor> colors = palette.GetPalette(texture, paletteColors.Length);
			for(int i=0; i<colors.Count; i++)
				paletteColors[i].color = colors[i].Color.ToColor(); 
		}
		else
			Debug.Log(www.error);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
