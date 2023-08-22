using System.Globalization;
using var writer = File.CreateText("target.txt");
CultureInfo.CurrentCulture = new CultureInfo("ja-JP", false);
writer.WriteLine(123.ToString("C"));
CultureInfo.CurrentCulture = new CultureInfo("zh-CN", false);
writer.WriteLine(123.ToString("C"));
