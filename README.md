# OpencvsharpDemo
## 1.安装opencvsharp
nuget安装非常简单，直接在工具->nuget包管理器->管理解决方案的nuget程序包。
## 2.显示图片
> Cv2.ImShow("src image", src);<br>
using (new Window("src image", src))<br>

两种效果一样，基本上都是使用第一种，如果要在两个不同的窗口显示图片，窗口名字不能取一样，否则会直接在那个窗口上更新图片。
> pictureBox1.Image = Mat.ToBitmap()

需要使用 using OpenCvSharp.Extensions;