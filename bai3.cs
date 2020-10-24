using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labchinhquy01b3
{
    class bai3
    {
        private static List<KHUDAT> DSkhudat()
        {
            List<KHUDAT> ds = new List<KHUDAT>();
            Console.Write("Nhap tong so khu dat N= ?");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n ====Nhap danh sach khu dat====");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("\n - Nhap khu dat thu {0}", i + 1);
                KHUDAT temp = new KHUDAT();
                temp.input();
                ds.Add(temp);
            }
            return ds;
        }
        private static void XuatDSkhudat(List<KHUDAT> ds)
        {
            Console.WriteLine("\n ====Xuat danh sach khu dat====");
            foreach (KHUDAT sv in ds)
            {
                sv.output();
            }
        }
        private static void DSsortbydientich(List<KHUDAT> ds)
        {
            List<KHUDAT> temp = (from s in ds
                                 orderby s.dientich
                                 select s).ToList();
            XuatDSkhudat(temp);
        }
        private static void DSgia1tyrong60m2(List<KHUDAT> ds)
        {
            List<KHUDAT> temp = (from s in ds
                                 where s.giaban < 1000000000 && s.dientich >= 60
                                 select s).ToList();
            if (temp.Count() == 0)
                Console.WriteLine("Khong tim thay khu dat mong muon\n");
            else
            {
                XuatDSkhudat(temp);
            }
        }
        private static void trungbinh1m2(List<KHUDAT> ds)
        {
            List<KHUDAT> temp = (from s in ds
                                 where s.dientich > 1000
                                 select s).ToList();
            if (temp.Count() == 0)
                Console.WriteLine("Khong tim thay khu dat mong muon\n");
            else
            {
                foreach (KHUDAT sv in ds)
                {
                    sv.output();
                    Console.Write("1m2 co gia: {0}", (sv.giaban / sv.dientich));
                }
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            List<KHUDAT> ds = DSkhudat();
            XuatDSkhudat(ds);
            DSsortbydientich(ds);
            DSgia1tyrong60m2(ds);
            trungbinh1m2(ds);
            Console.ReadKey();
        }
    }
}