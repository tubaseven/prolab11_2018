﻿using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestObject t1 = new TestObject() { value = 5 };
            //TestObject t2 = t1;

            //t2 = null;
            //Console.WriteLine(t1.value);

            //TestObject t1 = new TestObject() { value = 5 };
            //TestObject t2 = new TestObject() { value = 6 };
            //TestObject t3 = new TestObject() { value = 7 };

            //List<TestObject> liste = new List<TestObject>();
            //liste.Add(t1);
            //liste.Add(t2);
            //liste.Add(t3);
            //for (int i = 0; i < liste.Count; i++)
            //{
            //    TestObject to = liste.ElementAt(i);

            //    Console.WriteLine(to.value);

            //    if (i == 1)
            //        liste.Remove(to);
            //}


            //int hipotenus = (int)Math.Sqrt(Math.Pow((120 * Math.Pow(10, -3)), 2) + Math.Pow(207, 2));

            //Console.WriteLine(hipotenus);

            Console.WriteLine(Math.Atan(((double)120) / 207) * 180 / Math.PI);

            //Console.WriteLine( GetDistanceAsKM(40.76694, 29.91694, 37.76441, 38.27629));
            Console.Read();
        }

        private static int GetDistanceAsKM(double sLatitude, double sLongitude, double eLatitude, double eLongitude)
        {
            var sCoord = new GeoCoordinate(sLatitude, sLongitude);
            var eCoord = new GeoCoordinate(eLatitude, eLongitude);

            return (int)(sCoord.GetDistanceTo(eCoord) / 1000);
        }

    }

    public class TestObject
    {
        public int value { get; set; }
    }
}
