using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeMetotOrnekler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir sonraki ayın birine kaç gün var?

            //DateTime date = DateTime.Now;
            //DateTime launchdate = new DateTime(date.Year, date.Month + 1, 1);

            //TimeSpan ts = launchdate - date;

            //Console.WriteLine(ts.Days);
            //Console.WriteLine(ts.TotalDays);



            //Hafta sonuna kaç gün var? (cumartesi ye kaç gün var?)
            //int day = Convert.ToInt32(date.DayOfWeek);
            //int sonuc = 6 - day;
            //Console.WriteLine(sonuc + " gün kaldı");

            //Bu ay kaç gün tatil var ?(cumartesi ve pazar tatil)

            //DateTime date = DateTime.Now;

            //DateTime nextmonth = new DateTime(date.Year, date.Month + 1, 1);
            //DateTime nowmonth = new DateTime(date.Year, date.Month , 1);

            //TimeSpan ts = nextmonth - nowmonth;
            //int gunsayisi = ts.Days;
            //int sayac = 0;
            //for (int i = 1; i <= gunsayisi; i++)
            //{
            //    DateTime d = new DateTime(date.Year, date.Month, i);

            //    int day = Convert.ToInt32(d.DayOfWeek);
            //    if (day == 6 || day == 0)
            //    {
            //        sayac++;
            //    }

            //}

            //Console.WriteLine("bu ayki tatil günü: " + sayac);
            //Console.ReadLine();


            //Dışarıdan 2 tane datetime alan bir metot yazıyorum. Bu metot tarihleri karşılaştıracak aynı gün ise (mesela iki tarih te perşembe ise true değilse false dönecek gibi)

            // bool DateControl(DateTime dt1, DateTime dt2)
            //{
            //    if (dt1.DayOfWeek == dt2.DayOfWeek)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}


            //Ayın ilk gününü datetime formatında getiren metot
            //DateTime GetFirstDay()
            //{
            //    DateTime dt = DateTime.Now;

            //    DateTime resultdate = new DateTime(dt.Year, dt.Month, 1);

            //    return resultdate;
            //}


            //Bu ay kaç iş günü var? => int

            //int GetWorkingDays()
            //{
            //    DateTime date = DateTime.Now;
            //    DateTime startdate = new DateTime(date.Year, date.Month, 1);
            //    DateTime enddate = new DateTime(date.Year, date.Month + 1, 1);

            //    TimeSpan ts = enddate - startdate;

            //    int gun = ts.Days;
            //    int sayac = 0;
            //    for (int i = 1; i <= gun; i++)
            //    {
            //        DateTime d = new DateTime(date.Year, date.Month, i);

            //        int day = Convert.ToInt32(d.DayOfWeek);
            //        if (day != 6 && day != 0)
            //        {
            //            sayac++;
            //        }
            //    }
            //}


            //Haftanın ilk iş gününü getiren metot => datetime
            DateTime GetFirstWorkDay()
            {
                DateTime date = DateTime.Now;
                
                int mevcutgun = Convert.ToInt32(date.DayOfWeek);


                switch (mevcutgun)
                {
                    case 1:
                        return date;
                    case 2:
                        return date.AddDays(-1);
                    case 3:
                        return date.AddDays(-2);
                    case 4:
                        return date.AddDays(-3);
                    case 5:
                        return date.AddDays(-4);
                    case 6:
                        return date.AddDays(-5);
                    case 0:
                        return date.AddDays(-6);

                    default:
                        return date;
                }



                //if (mevcutgun == 1)
                //{
                //    return date;
                //}
                //else if (mevcutgun == 2)
                //{
                //    return date.AddDays(-1);
                //}

            }

            //Haftanın son iş gününü getiren metot => datetime


          //  DateTime sonuc = GetLastWorkDay();

            DateTime GetLastWorkDay()
            {
                DateTime date = DateTime.Now;
                int mevcutgun = Convert.ToInt32(date.DayOfWeek);

                switch (mevcutgun)
                {
                    case 5:
                        return date;
                    case 6:
                        return date.AddDays(-1);
                    case 0:
                        return date.AddDays(-2);
                    case 1:
                        return date.AddDays(4);
                    case 2:
                        return date.AddDays(3);
                    case 3:
                        return date.AddDays(2);
                    case 4:
                        return date.AddDays(1);
                    default:
                        return date;
                }

            }


            //Verilen iki tarih arasındaki tatil günlerinin sayısını getiren metot datetime, datetime => int

            //DateTime d1 = new DateTime(2020, 8, 15);

            //int s = TatilGetir(d1, DateTime.Now);

            int TatilGetir(DateTime dt1, DateTime dt2)
            {
                TimeSpan ts = dt2 - dt1;
                
                int gunadet = ts.Days;

                int sayac = 0;
                for (int i = 0; i < gunadet; i++)
                {
                    DateTime controldate = dt1.AddDays(i);

                    int gun = Convert.ToInt32(controldate.DayOfWeek);

                    if (gun == 6 || gun == 0)
                    {
                        sayac++;
                    }
                }

                return sayac;
            }


            //Mevcut tarihe iş günü ekleyen metot datetime, int => datetime 
            DateTime AddWorkDays(int gunadet)
            {
                DateTime dt = DateTime.Now;
                DateTime fakedt = DateTime.Now;

                for (int i = 0; i < gunadet; i++)
                {
                   fakedt  = dt.AddDays(i);
                    int gun = Convert.ToInt32(fakedt.DayOfWeek);

                    if (gun == 0 || gun == 6)
                    {
                        gunadet++;
                    }
                }

                return fakedt;

            }



        }
    }
}
