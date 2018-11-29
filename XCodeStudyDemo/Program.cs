using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewLife.Log;
using NewLife.Security;
using NewLife.Serialization;
using XCode.Membership;

namespace XCodeStudyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            XTrace.UseConsole();

            //Test1();
            Test2();


            Console.WriteLine("OK!");
            Console.ReadKey();
        }

        static void Test1()
        {
            var s = new Student
            {
                Name = "IsMatch1",
                Age = 22,
                LastLoginIP = NewLife.Web.WebHelper.UserHost
            };

            s.Insert();

            Console.WriteLine($"ID{s.ID}");
        }

        static void Test2()
        {
            var isMatch = Student.FindByKey(1);
            Console.WriteLine(isMatch);
            Console.WriteLine(isMatch.ToJson(true));

            isMatch.Name = "Hello World!";
            isMatch.Save();

            Console.WriteLine(isMatch);
            Console.WriteLine(isMatch.ToJson(true));
        }

        static void Test3()
        {
            // 新增
            var st = new Student
            {
                Name = Rand.NextString(8),
                Age = Rand.Next(0, 100),
                Logins = Rand.Next(0, 2),
                Enable = true
            };
            st.Insert();

            var id = st.ID;
            Console.WriteLine("ID={0}", id);

            // 查找
            st = Student.FindByKey(id);
            Console.WriteLine(st);
            Console.WriteLine(st.ToJson(true));

            // 更新
            Console.WriteLine();
            st.Mail = Rand.NextString(16, true);
            st.Update();
            Console.WriteLine(st.ToJson(true));

            // 删除
            st.Delete();
            st = Student.FindByKey(id);
            Console.WriteLine(st == null);
        }
    }
}
