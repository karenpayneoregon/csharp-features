# About

Provides methods to load icon files to BitMap


![screenshot](../assets/IconToBitmap.png)

```csharp
private void OnFormShown(object? sender, EventArgs e)
{
    var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Icons", "agent1.ico");

    Agent1PictureBox.Image = Converters.FromBytesToBitMap(fileName);

    fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Icons", "Csharp.ico");
    cSharpPictureBox.Image = Converters.FromBytesToBitMap(fileName);

    fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Icons", "Excel.ico");
    // use extension method
    ExcelPictureBox.LoadIconFromFile(fileName);
}
```

### Methods

|Scope|Method/property   |Definition   |
| :---         |  :---  | :--- |
|public|FromIconToBitmap :small_orange_diamond:   |Convert from icon to bitmap   |
|public|BytesToIcon :small_orange_diamond:   |Convert byte array to Icon   |
|public|FromBytesToBitMap :small_orange_diamond:   |Read file contents and convert to BitMap   |

:small_orange_diamond: method



### Important

All code done in Visual Studio 2019 using .NET 5 and C# 9

#### Base off

https://social.technet.microsoft.com/wiki/contents/articles/17107.c-convert-an-ico-file-to-a-bmp.aspx