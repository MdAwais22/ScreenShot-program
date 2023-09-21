//using System;
//using System.Drawing;
//using System.Drawing.Imaging;
//using System.Windows.Forms;

//class Program
//{
//    static void Main()
//    {
//        Random random = new Random();
//        int randomNumber = random.Next(1, 10);
//        Console.WriteLine("Your Random number is : " + randomNumber);

//        CaptureScreenshot("screenshot.png");

//        Console.WriteLine("Screenshot captured.");

//        Console.ReadLine();
//    }

//    static void CaptureScreenshot(string filePath)
//    {
//        using (Bitmap screenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height))
//        {
//            using (Graphics graphics = Graphics.FromImage(screenshot))
//            {
//                graphics.CopyFromScreen(0, 0, 0, 0, screenshot.Size);
//            }

//            string fileName = $"screenshot_{DateTime.Now:yyyyMMddHHmmss}.png";
//            screenshot.Save(fileName, ImageFormat.Png);
//            Console.WriteLine($"Screenshot saved as {fileName}");
//        }
//    }

//}





//      => First Day in Creative Rays 19-09-23

//.......... Task1 Comleted.................//

//using System;
//using System.Threading;

//namespace Random_Number
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            Random number = new Random();
//            int num = number.Next(1,5);
//            {

//                Console.WriteLine("You Random Number is :" + num);
//                System.Timers.Timer d = new System.Timers.Timer(1000);
//                d.Elapsed += (a, b) =>
//                {
//                    Console.WriteLine(number.Next(1, 10));
//                };
//                d.Start();
//                Timer time = new Timer(TakeScreenShot, null, 0, 3000);
//                Console.WriteLine("press any key to exit");
//                Console.ReadLine();
//            }

//        }

//        private static void TakeScreenShot(object state)
//        {
//            Console.WriteLine("Please take screenshot");
//        }
//    }

//}




//         => Project 1 is Completed


using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Threading;


class Program
{
    static int count = 0;
    static void Main()
    {

        Random random = new Random();
        int randomNumber = random.Next(1, 5);

        while (count!=randomNumber)
        {
            Console.WriteLine("random number is not equal");
            count = count + 1;
        }

        Console.WriteLine("your Random number is generated:" + randomNumber);
        System.Timers.Timer d = new System.Timers.Timer(1000);
            d.Elapsed += randomnumber;
        d.Start();
       
     
        Console.ReadLine();
    }
    static void randomnumber(object sender,EventArgs e)
    {
        Random random1 = new Random();
        int rand = random1.Next(1, 5);
        Console.WriteLine("you random number is:" + rand);
        CaptureScreenshot("screenshot.png");
        Console.WriteLine("captured screenshot");
        Console.WriteLine("Wow congratulation to successful to complete the Task");
    }
   
    static void CaptureScreenshot(string filePath)
    {
        using (Bitmap screenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height))
        {
            using (Graphics graphics = Graphics.FromImage(screenshot))
            {
                graphics.CopyFromScreen(0, 0, 0, 0, screenshot.Size);
            }

            string fileName = $"screenshot_{DateTime.Now:yyyyMMddHHmmss}.png";
            screenshot.Save(fileName, ImageFormat.Png);
            Console.WriteLine($"Screenshot saved as {fileName}");
        }
    }

}


