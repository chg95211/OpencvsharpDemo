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
<pre><code>  //文字
  Cv2.PutText(src,                                      //目标图像
                        "lenna",                        //字符串
                        new Point(0,80),                //位置，注意这是字符串左下角的位置
                        HersheyFonts.HersheyComplex,    //字体类型
                        5,                              //字体大小
                        Scalar.White);                  //颜色
  //空心圆
  Cv2.Circle(src,                           //目标图像
                        new Point(80, 80),  //中心点坐标
                        60,                 //半径
                        Scalar.White);      //颜色
  //实心圆
  Cv2.Circle(src, new Point(80, 80), 30, Scalar.White,65);//多一个厚度，后面还有两个参数是LineTypes平滑程度，和shift缩小倍率
  //线
  Cv2.Line(src, 0, 0, 80, 80, Scalar.White);//目标图像，点1x，y,点2x，y，颜色
  //框
  Rect rect = new Rect(0, 0, 100, 100);
  Cv2.Rectangle(src, rect, Scalar.White);
</code></pre>


                        
