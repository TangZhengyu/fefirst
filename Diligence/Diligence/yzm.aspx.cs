using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Drawing.Imaging;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace Diligence
{
    public partial class yzm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
                //一、用来生成验证码图片
                string str = "abcdefghijklmnopqrstuvywxyzABCDEFGHIJKLMNOPQRSTUVYWXZ1234567890";
                Bitmap img = new Bitmap(80, 40);
                Graphics g = Graphics.FromImage(img);
                g.FillRectangle(new SolidBrush(Color.Aqua), 0, 0, 80, 40);
                Random random = new Random();
                random.Next(0, str.Length);
                string s = "";
                for (int i = 0; i < 4; i++)
                {
                    s += str.Substring(random.Next(0, str.Length), 1);
                }
                g.DrawString(s, new Font("华文楷体", 20), new SolidBrush(Color.Red), 0, 10);

                Session["yzm"] = s;

                //二、保存图片
                //1、确定保存的格式
                MemoryStream stream = new MemoryStream();
                img.Save(stream, ImageFormat.Jpeg);
                Response.ContentType = "Image/Jpeg";
                Response.BinaryWrite(stream.ToArray());
                Response.End();
            
        }
    }
}