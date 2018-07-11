# OpencvsharpDemo
## 1.安装opencvsharp
nuget安装非常简单，直接在工具->nuget包管理器->管理解决方案的nuget程序包。
## 2.显示图片
> Cv2.ImShow("src image", src);<br>
using (new Window("src image", src))<br>

两种效果一样，基本上都是使用第一种，如果要在两个不同的窗口显示图片，窗口名字不能取一样，否则会直接在那个窗口上更新图片。
> pictureBox1.Image = Mat.ToBitmap()

需要使用 using OpenCvSharp.Extensions;
## 3.保存图片
> Cv2.ImWrite("lenna1.png", dst);//和exe在同一个文件夹下
## 3.绘制图片
> Cv2.PutText(src,                                      //目标图像<br>
                        "lenna",                        //字符串<br>
                        new Point(0,80),                //位置，注意这是字符串左下角的位置<br>
                        HersheyFonts.HersheyComplex,    //字体类型<br>
                        5,                              //字体大小<br>
                        Scalar.White);                  //颜色<br>
  //空心圆<br>
  Cv2.Circle(src,                           //目标图像<br>
                        new Point(80, 80),  //中心点坐标<br>
                        60,                 //半径<br>
                        Scalar.White);      //颜色<br>
  //实心圆<br>
  Cv2.Circle(src, new Point(80, 80), 30, Scalar.White,65);//多一个厚度，后面还有两个参数是LineTypes平滑程度，和shift缩小倍率<br>
  //线<br>
  Cv2.Line(src, 0, 0, 80, 80, Scalar.White);//目标图像，点1x，y,点2x，y，颜色<br>
  //框<br>
  Rect rect = new Rect(0, 0, 100, 100);<br>
  Cv2.Rectangle(src, rect, Scalar.White);<br>


                        
