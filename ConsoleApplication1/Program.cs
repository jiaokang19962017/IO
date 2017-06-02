using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建.删除.查看目录
            /*  string path = "E:test99";
              try
              {
                  if (Directory.Exists(path))
                  {
                      Console.WriteLine("已存在此目录");
                  }
                  else
                  {
                      //创建一个目录
                      DirectoryInfo dict = Directory.CreateDirectory(path);
                      Console.WriteLine("创建目录成功" + Directory.GetCreationTime(path));
                  }
              }
              catch (Exception ie)
              {

                  Console.WriteLine(ie.Message);
              }

              //删除目录,加true删除包括里面的内容
              Directory.Delete(path,true);
              //查看当前目录
              Console.WriteLine(Directory.GetCurrentDirectory());*/


            //判断文件是否存在

            /*  string path = @"E:\\test\\test1.txt";
              FileInfo file = new FileInfo(path);
              if (file.Exists) //第一种
              {
                  Console.WriteLine("文件存在");
              }
              else
              {
                  file.Create();
                  Console.WriteLine("创建成功");
              }
              /*   if (File.Exists(path))//第二种
                 {
                     Console.WriteLine("文件存在");
                 }*/

            #region 文件流
            string path = @"E:\\test\\1.txt";
            FileStream fs;
            if (!File.Exists(path))//如果文件不存在
            {
                //写入文件
                 fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                Console.WriteLine("请输入内容");
                string s = Console.ReadLine();
                sw.Write(s);
                sw.Close();//关闭流
                fs.Close();
            }
            else//如果文件存在
            {
                //读取文件
                /*  fs = new FileStream(path,FileMode.Open,FileAccess.Read);
                  StreamReader sr = new StreamReader(fs);
                  //string str;
                  //while ((str = sr.ReadLine())!=null)
                  //{
                  //Console.WriteLine( str);
                  //}
                  Console.WriteLine(sr.ReadToEnd());
                  sr.Close();
                  fs.Close();*/

                //追加文件
                fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("你好12122");
                sw.Close();
                fs.Close();

                Console.WriteLine(File.ReadAllText(path));//读取文件

            }


            #endregion
        }
    }
}
