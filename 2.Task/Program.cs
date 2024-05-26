//Calculator
//Add 
//Multi
//Divide
//- 
//funksiyalari olsun
//ve switch istifade ederek 
//kalkulyator yazmaq lazimdir.

namespace _2.Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            static void toplama(ref int num1, ref int num2)
            {
                int a = (num1 + num2);
                Console.WriteLine($"Cem : {a}");
            }

            static void cixma(ref int num1, ref int num2)
            {
                int a = (num1 - num2);
                Console.WriteLine($"Ferq : {a}");

            }

            static void vurma(ref int num1, ref int num2)
            {
                int a = (num1 * num2);
                Console.WriteLine($"Hasil : {a}");

            }

            static void bolme(ref int num1, ref int num2)
            {
                if (num2 != 0)
                {
                    int a = (num1 / num2);
                    Console.WriteLine($"Qismet : {a}");
                }
                else
                {
                    Console.WriteLine("0 a Bolme Olmaz !");
                }


            }
            while (true)
            {
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                Console.Write("1 - ci Ededi Daxil Et ! ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2 - ci Ededi Daxil Et ! ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nHansi Emeliyyat Icra Olunacaq + , - , * , / : ");
                string a = Console.ReadLine();
                if (a == "+" || a == "-" || a == "*" || a == "/")
                {
                    switch (a)
                    {
                        case "+":
                            toplama(ref num1, ref num2);
                            break;
                        case "-":
                            cixma(ref num1, ref num2);
                            break;
                        case "*":
                            vurma(ref num1, ref num2);
                            break;
                        case "/":
                            bolme(ref num1, ref num2);
                            break;
                        default:
                            Console.WriteLine("SEHF : ");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Secim Sehfdir ! Yeniden Ceht Et ! ");
                }

                continue;
            }
            //            while (true)
            //            {


            //                //System.Threading.Thread.Sleep(2100);
            //                //Console.Clear();
            //                //Console.Write("\nHansi Emeliyyat Icra Olunacaq + , - , * , / : ");
            //                //string a = Console.ReadLine();
            //                //if (a == "+" || a == "-" || a == "*" || a == "/")
            //                //{
            //                //    Console.Write("Eded 1 i Sec ! ");
            //                //    string b = Console.ReadLine();
            //                //    Console.Write("Eded 2 i Sec ! ");
            //                //    string c = Console.ReadLine();
            //                //    switch (a)
            //                //    {
            //                //        case "+":
            //                //            int e = int.Parse(c);
            //                //            int r = int.Parse(b);
            //                //            int d = (e + r);
            //                //            Console.Write( $"Cem = {d}");
            //                //            break;
            //                //        case "-":
            //                //            int p = int.Parse(c);
            //                //            int l = int.Parse(b);
            //                //            int m = (l - p);
            //                //            Console.Write($"Ferq = {m}");
            //                //            break;
            //                //        case "*":
            //                //            int pl = int.Parse(c);
            //                //            int ll = int.Parse(b);
            //                //            int ml = (ll * pl);
            //                //            Console.Write($"Hasil = {ml}");
            //                //            break;
            //                //        case "/":
            //                //            int pll = int.Parse(c);
            //                //            int lll = int.Parse(b);
            //                //            if (pll != 0)
            //                //            {
            //                //                int mmm = (lll / pll);
            //                //                Console.Write($"Qismet = {mmm}");
            //                //            }
            //                //            else
            //                //            {
            //                //                Console.WriteLine("0 a Bolmek Olmaz !");
            //                //            }
            //                //            break;
            //                //        default:
            //                //            Console.WriteLine("SEHF : ");
            //                //            break;
            //                //    }

            //                //}
            //                //else
            //                //{ Console.WriteLine("Secim Yanlishdir ! Yeniden Daxil Et !"); };
            //            }
            //        }
                /// bunu Commentden Cixarma ! 
            //    }
            //}   // bu Funsiyasizdir !!
        }
    }
}