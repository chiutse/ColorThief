# Color Thief Unity
A code for grabbing the color palette from an image. Uses C#.NET and Unity 2DTexture to make it happen.

Origin Project [Color Thief](https://github.com/lokesh/color-thief)

Ported Project of [Color Thief .NET](https://github.com/KSemenenko/ColorThief) 

## How To Use
Dominant Color
```cs
var dominant = new ColorThief.ColorThief();
Color color = dominant.GetColor(texture).UnityColor;
```

Palette Color
```cs
var palette = new ColorThief.ColorThief();
List<ColorThief.QuantizedColor> colors = palette.GetPalette(texture, paletteColors.Length);
```
