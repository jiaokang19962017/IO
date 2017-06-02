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
            string path = @"E:\\test\\test1.txt";
            FileInfo fi = new FileInfo(path);
            if (fi.Exists) 
            {
                Console.WriteLine("文件存在");
            }
            if (File.Exists(path))
            {
                Console.WriteLine("文件存在");
            }
        }
    }
}
