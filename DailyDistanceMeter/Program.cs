using System;

namespace BilgeAdam.DailyRunningMeter
{
    public class Program
    {


        public static void Main(string[] args)
        {
            var flag = true;

            do
            {
                Console.Clear();
                Console.WriteLine("Günlük Koşu Mesafesi Ölçer ");
                var a = StepSize();
                var b = StepNumberInMinute();
                var c = RunningTime();
                var result = CalculateDistance(a, b, c);
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine($"Koşu mesafeniz : {result} metre ");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("");
                var yesOrNo = true;
                do
                {
                    Console.WriteLine("Programa devam etmek ister misiniz? EVET yada HAYIR yazınız :");
                    var answer = Console.ReadLine().ToUpper();
                    if (answer == "EVET" || answer == "E")
                    {

                        yesOrNo = false;
                    }
                    else if (answer == "HAYIR" || answer == "H")
                    {
                        yesOrNo = false;
                        flag = false;
                        Console.WriteLine("Programı kullandığınız için teşşekkürler.");

                    }
                    else
                    {

                        Console.WriteLine("************************");
                        Console.WriteLine("Hatalı giriş yaptınız!");
                        Console.WriteLine("************************");
                        yesOrNo = true;
                    }

                } while (yesOrNo);


            } while (flag);


        }

        static int StepSize()
        {
            var stepDistance = 0;
            int sayi;
            var flag1 = true;
            do
            {
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("Ortalama bir adımınızın Kaç cm olduğunu giriniz(cm):");
                var step = Console.ReadLine();

                if (!int.TryParse(step, out sayi))
                {
                    Console.WriteLine("Hatalı giriş yaptınız!");
                }
                else
                {
                    stepDistance = Convert.ToInt32(step);
                    if (stepDistance <= 0)
                    {
                        Console.WriteLine("************************");
                        Console.WriteLine("Negatif ve sıfır  değeri giremezsiniz !");
                        Console.WriteLine("************************");
                    }
                    else
                    {
                        flag1 = false;
                    }

                }

            } while (flag1);

            return stepDistance;
        }
        static int StepNumberInMinute()
        {
            var stepNumber = 0;
            int sayi1;
            var flag2 = true;
            do
            {
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("Bir dakikada kaç adım attığınızı giriniz:");
                var stepMinute = Console.ReadLine();

                if (!int.TryParse(stepMinute, out sayi1))
                {
                    Console.WriteLine("************************");
                    Console.WriteLine("Hatalı giriş yaptınız!");
                    Console.WriteLine("************************");
                }
                else
                {
                    stepNumber = Convert.ToInt32(stepMinute);
                    if (stepNumber <= 0)
                    {
                        Console.WriteLine("************************");
                        Console.WriteLine("Negatif ve sıfır  değeri giremezsiniz !");
                        Console.WriteLine("************************");
                    }
                    else
                    {
                        flag2 = false;
                    }

                }


            } while (flag2);

            return stepNumber;
        }
        static int RunningTime()
        {
            var durationHour = 0;
            var durationMinute = 0;
            int sayi2;
            var flag3 = true;
            var flag4 = true;
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Koşu süresini önce saat sonra olarak giriniz:");
            do
            {
                Console.Write("Saat :");
                var durationTimeHour = Console.ReadLine();
                if (!int.TryParse(durationTimeHour, out sayi2))
                {
                    Console.WriteLine("************************");
                    Console.WriteLine("Hatalı giriş yaptınız!");
                    Console.WriteLine("************************");
                }
                else
                {

                    durationHour = Convert.ToInt32(durationTimeHour);

                    if (durationHour < 0)
                    {
                        Console.WriteLine("************************");
                        Console.WriteLine("Negatif değer giremezsiniz !");
                        Console.WriteLine("************************");
                    }
                    else
                    {
                        flag3 = false;
                    }
                }

            } while (flag3);

            do
            {

                Console.Write("Dakika:");
                var durationTimeMinute = Console.ReadLine();
                if (!int.TryParse(durationTimeMinute, out sayi2))
                {
                    Console.WriteLine("************************");
                    Console.WriteLine("Hatalı giriş yaptınız!");
                    Console.WriteLine("************************");
                }
                else
                {
                    durationMinute = Convert.ToInt32(durationTimeMinute);
                    if (durationMinute > 60)
                    {
                        Console.WriteLine("************************");
                        Console.WriteLine("60 sayısından büyük dakika giremezsiniz !");
                        Console.WriteLine("************************");
                    }
                    else if (durationMinute <= 0)
                    {
                        Console.WriteLine("************************");
                        Console.WriteLine("0 ve daha küçük dakika giremezsiniz !");
                        Console.WriteLine("************************");
                    }
                    else
                    {
                        flag4 = false;
                    }

                }

            } while (flag4);

            var total = (durationHour * 60) + durationMinute;
            return total;

        }
        public static double CalculateDistance(int a, int b, int c)
        {
            var runningtime = Convert.ToDouble((a * b * c) / 100);

            return runningtime;
        }

    }
}

