using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Array
            คุณสมบัติของ Array
            1. ใช้เก็บกลุ่มของข้อมูล
            2. ข้อมูลที่อยู่ในอาร์เรย์จะเรียกว่าสมาชิก หรือ อิลิเมนต์ (Element)
            3. แต่ละอิลิเมนต์ (Element) จะเก็บค่าข้อมูล (Value) และ อินเด็กซ์ (Index) เอาไว้
            4. Index หมายถึงคีย์ของอาเรย์ใช้อ้างอิงตำแหน่งของ Element เริ่มต้นที่ 0
            5. สมาชิกใน Array ต้องมีชนิดข้อมูลเหมือนกัน
            6. สมาชิกใน Array จะถูกคั่นด้วยเครื่องหมาย Comma

            // การสร้าง Array มี 2 รูปแบบ คือ
            1. แบบไม่ประกาศค่าเริ่มต้น ใช้สัญลักษณ์ []
                ชนิดข้อมูล[] ชื่อตัวแปร = new ชนิดข้อมูล [ขนาด];
                เช่น int[] number = new int[4];
            2. แบบประกาศค่าเริ่มต้น ใช้สัยลักษณ์ {}
                ชนิดข้อมูล[] ชื่อตัวแปร = {สมาชิก,....};
                เช่น int[] number = {10,20,30,40};
            */
            /*
            // Array แบบประกาศค่าเริ่มต้น
            int[] number = { 10, 20, 30, 40 };
            double[] grade = { 4.00, 3.53, 3.29 };

            // การเปลี่ยนค่าใน Array 
            number[2] = 100;
            number[3] = 200;

            // แสดงผลค่าใน Array >> numner
            Console.WriteLine("Array >> numner");
            Console.WriteLine("number Index 0 = {0}", number[0]);
            Console.WriteLine("number Index 1 = {0}", number[1]);
            Console.WriteLine("number Index 2 = {0}", number[2]);
            Console.WriteLine("number Index 3 = {0}", number[3]);

            // แสดงผลค่าใน Array >> grade
            Console.WriteLine("Array >> grade");
            Console.WriteLine("Grade Index 0 = {0}", grade[0]);
            Console.WriteLine("Grade Index 1 = {0}", grade[1]);
            Console.WriteLine("Grade Index 2 = {0}", grade[2]);

            Console.ReadKey();
            */

            //-------------------------------------------------------------------------------------

            /*
            // นับจำนวนสมาชิกใน Array
            // Array แบบประกาศค่าเริ่มต้น
            int[] number = { 10, 20, 30, 40 };
            double[] grade = { 4, 3.45, 3.63, 2.95 };
            string[] students = { "Jony", "Kong", "Nutto" };

            //แสดงผลจำนวนค่าใน Array
            Console.WriteLine("Count Array Number = {0}",number.Length);
            Console.WriteLine("Count Array Grade = {0}", grade.Length);
            Console.WriteLine("Count Array Students = {0}", students.Length);

            Console.ReadKey();
            */

            //-------------------------------------------------------------------------------------

            /*
            // เข้าถึงสมาชิกใน Array ด้วย For Loop
            // Array แบบประกาศค่าเริ่มต้น
            int[] number = { 10, 20, 30, 40 };
            double[] grade = { 4, 3.45, 3.63, 2.95 };
            string[] students = { "Jony", "Kong", "Nutto", "Mod", "Naja", "Java" };

            // แสดงผลค่าใน Array
            for(int index = 0; index < students.Length; index++)
            {
                Console.WriteLine("Student Index {0} = {1}", index, students[index]);
            }
            Console.ReadKey();
            */

            //-------------------------------------------------------------------------------------

            /*
            // เข้าถึงสมาชิกใน Array ด้วย For Each
            // Array แบบประกาศค่าเริ่มต้น
            int[] number = { 10, 20, 30, 40 };
            double[] grade = { 4, 3.45, 3.63, 2.95 };
            string[] students = { "Jony", "Kong", "Nutto", "Mod", "Naja", "Java" };

            // แสดงผลค่าใน Array
            foreach(string name in students)
            {
                Console.WriteLine("Student {0}", name);
            }
            Console.ReadKey();
            */

            //-------------------------------------------------------------------------------------

            /*
            // Array 2 มิติ
            รูปแบบของ Array
            - Array 1 มิติ (Single Dimensional Array)
            - Array หลายมิติ (Multidimensional Array)
            - Jagged Array
            */
            /*
            // Array 2 มิติ
            string[,] students =
            {
                {"kong", "kan", "khing", "keaw" },
                {"nick", "nook", "nun", "nim" },
                {"mod", "mand", "mee", "mood" }
            };

            Console.WriteLine(students[0,0]);
            Console.WriteLine(students[0,1]);
            Console.WriteLine(students[0,2]);
            Console.WriteLine(students[0,3]);

            Console.WriteLine(students[1, 0]);
            Console.WriteLine(students[1, 1]);
            Console.WriteLine(students[1, 2]);
            Console.WriteLine(students[1, 3]);

            Console.WriteLine(students[2, 0]);
            Console.WriteLine(students[2, 1]);
            Console.WriteLine(students[2, 2]);
            Console.WriteLine(students[2, 3]);

            Console.ReadKey();
            */

            //-------------------------------------------------------------------------------------

            /*
            // For Loop ใน Array 2 มิติ
            string[,] students =
            {
                {"kong", "kan", "khing", "keaw" },
                {"nick", "nook", "nun", "nim" },
                {"mod", "mand", "mee", "mood" }
            };

            for (int row = 0; row < students.GetLength(0); row++)
            {
                for (int cols = 0; cols < students.GetLength(1);cols++)
                {
                    Console.WriteLine("Students[{0}][{1}] = {2}", row, cols, students[row, cols]);
                }
                Console.WriteLine("#################");
            }

            Console.ReadKey();
            */

            //-------------------------------------------------------------------------------------

            /*
            // For Each ใน Array 2 มิติ
            string[,] students =
            {
                {"kong", "kan", "khing", "keaw" },
                {"nick", "nook", "nun", "nim" },
                {"mod", "mand", "mee", "mood" }
            };
            foreach (string name in students)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
            */

            //-------------------------------------------------------------------------------------

            /*
            // Jagged Array
            - Array ที่มีข้อมูลสมาชิกภายในเป็น Array (Array ซ้อน Array)
            - มีโครงสร้างเป็นรูปแบบแถว (แนวนอน) และคอลัมน์ (แนวตั้ง)
            - มีจำนวนสมาชิกในแต่ละ Array ย่อยเท่ากันหรือต่างกันได้
            */
            /*
            string[,] students =
            {
                {"kong", "kan", "khing", "keaw" },
                {"nick", "nook", "nun", "nim" },
                {"mod", "mand", "mee", "mood" }
            };

            // Jagged Array
            string[][] jaggedArray =
            {
                new string[] { "kong", "kan", "keaw" },
                new string[] { "nick", "nook" },
                new string[] { "mood" }
            };
            jaggedArray[0][1] = "jojo";
            Console.WriteLine(jaggedArray[0][1]);
            Console.ReadKey();
            */

            //-------------------------------------------------------------------------------------

            /*
            // เข้าถึงสมาชิกใน Jagged Array
            string[,] students =
            {
                {"kong", "kan", "khing", "keaw" },
                {"nick", "nook", "nun", "nim" },
                {"mod", "mand", "mee", "mood" }
            };

            // Jagged Array
            string[][] jaggedArray =
            {
                new string[] { "kong", "kan", "keaw" },
                new string[] { "nick", "nook" },
                new string[] { "mood" }
            };
            for (int row = 0; row < jaggedArray[row].Length; row++)
            {
                for (int cols = 0; cols < jaggedArray[row].Length;cols++)
                {
                    Console.WriteLine("Students Jagged Array [{0}][{1}] = {2}", row, cols, jaggedArray[row][cols]);
                }
            }
            Console.ReadKey();
            */

            //[1]-------------------------------------------------------------------------------------

            /*
            // การสร้างเมธอด (Method)
            เมธอด (Method) คือชุดคำสั่งที่นำมาเขียนรวมกันเป็นกลุ่มเพื่อให้เรียกใช้งานตามวัตถุประสงค์ที่ต้องการและลดความซ้ำซ้อนของคำสั่งที่ใช้งานบ่อยๆ
            เมธอดสามารถนำไปใช้งานได้ทุกที่และแก้ไขได้ในภายหลัง ทำให้โค้ดในโปรแกรมมีระเบียบและใช้งานได้สะดวกมากยิ่งขึ้น
            เมธอดมี 2 รูปแบบ
            - Predefined method - เมธอดที่ทำงานอยู่ใน C#
            - user - defined method - เมธอดที่สร้างเอง
            
            sayHi();
            */

            //[2]-------------------------------------------------------------------------------------

            /*
            // เมธอดรับค่าข้อมูล
            showData("Mod", "Data", "Rayong");
            showData("Num", "Mara", "Bangkok");
            Console.ReadKey();
            */

            //[3]-------------------------------------------------------------------------------------
            /*
            // เมธอด return ค่าข้อมูล
            bool result = checkNumber();
            Console.WriteLine("Result = {0}", result);
            Console.ReadKey();
            */
        }
        /*
        //[1]-------------------------------------------------------------------------------------
        // การนิยาม Mathod
        static void sayHi()
        {
            Console.WriteLine("Hello C#");
            Console.ReadKey();
        }
        */

        //[2]-------------------------------------------------------------------------------------
        /*
        static void sayHi(string message)
        {
            Console.WriteLine("Hello " + message);
        }
        static void showData(string fname, string lname, string address)
        {
            Console.WriteLine("firstName = {0}", fname);
            Console.WriteLine("lastName = {0}", lname);
            Console.WriteLine("address = {0}", address);
            Console.WriteLine("###############");
        }
        */

        //[3]-------------------------------------------------------------------------------------
        /*
        static string getIPAddress()
        {
            return "127.0.0.1";
        }
        // getIPAddress(): เป็นเมธอดที่ไม่รับพารามิเตอร์และมีการกำหนดค่าคืน (return) เป็นสตริง (string) ที่มีค่า 
        // "127.0.0.1" ซึ่งในที่นี้เป็นที่อยู่ IP ที่บ่งชี้ถึงเครื่อง localhost (คือเครื่องคอมพิวเตอร์เราเอง) ซึ่งใช้ในการทดสอบ
        // แอปพลิเคชันบางกรณีเมื่อต้องเชื่อมต่อกับตัวเองผ่านทางเครือข่าย
        static bool checkNumber()
        {
            int number = 49;
            if (number % 2 == 0)
            {
                return true;
            } 
            else
            {
                return false;
            }
            //checkNumber(): เป็นเมธอดที่ไม่รับพารามิเตอร์และมีการกำหนดค่าคืน (return) เป็นชนิดข้อมูล bool 
            //ซึ่งหมายความว่าจะคืนค่า true หากตัวเลขที่กำหนดในตัวแปร number เป็นเลขคู่ (หารด้วย 2 ลงตัว) 
            //และคืนค่า false ถ้าตัวเลขนั้นเป็นเลขคี่
            }
        */
    }
}
