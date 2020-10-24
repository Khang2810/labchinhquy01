using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labchinhquy01b4
{
    class bai4
    {
        private static List<KHUDAT> nhap()
        {
            List<KHUDAT> ds = new List<KHUDAT>();
            Console.Write("Nhap tong so khu dat N= ?");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n ====Nhap danh sach khu dat====");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("\n - Nhap khu dat thu {0}\n", i + 1);
                Console.Write("Nhap loai khu dat ?: Nha pho (0), Chung cu (1)");
                int type = Convert.ToInt32(Console.ReadLine());
                if (type == 0)
                {
                    KHUDAT temp = new NHAPHO();
                    temp.input();
                    ds.Add(temp);
                }
                if (type == 1)
                {
                    KHUDAT temp = new CHUNGCU();
                    temp.input();
                    ds.Add(temp);
                }
            }
            return ds;
        }
        private static void xuat(List<KHUDAT> ds)
        {
            Console.WriteLine("\n ====Xuat danh sach khu dat====");
            foreach (KHUDAT sv in ds)
            {
                sv.output();
            }
        }
        private static void xuattonggia(List<KHUDAT> ds)
        {
            Console.WriteLine("\n ====Xuat danh sach tong gia cac loai khu dat====");
            int i = 0;
            int j = 0;
            foreach (KHUDAT sv in ds)
            {
                if (sv.type().CompareTo("chungcu") == 0)
                    j = j + sv.giaban;
                if (sv.type().CompareTo("nhapho") == 0)
                    i = i + sv.giaban;
            }
            Console.Write("Tong gia tri nha pho: {0} VND\nTong gia tri chung cu: {1}\n", i, j);
        }
        private static void DS100m(List<KHUDAT> ds)
        {
            List<KHUDAT> temp = (from s in ds
                                 where s.dientich >= 100
                                 select s).ToList();
            List<KHUDAT> temp1 = (from s in ds
                                  where s.dientich > 60 && s.type().CompareTo("nhapho") == 0 && ((NHAPHO)s).namxaydung >= 2020
                                  select s).ToList();
            if (temp.Count() == 0)
                Console.WriteLine("Khong tim thay khu dat tren 1000 m mong muon\n");
            else
            {
                xuat(temp);
            }
            if (temp1.Count() == 0)
                Console.WriteLine("Khong tim thay nha pho mong muon\n");
            else
            {
                xuat(temp1);
            }
        }
        private static void DSyeucau(List<KHUDAT> ds)
        {
            Console.Write("Nhap dia diem");
            String a = Console.ReadLine();
            Console.Write("Nhap gia");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap dien tich?");
            int c = Convert.ToInt32(Console.ReadLine());
            List<KHUDAT> temp = (from s in ds
                                 where s.dientich >= c && s.giaban <= b && s.diachi.CompareTo(a)==0 
                                select s).ToList();
            xuat(temp);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            List<KHUDAT> ds = nhap();
            xuat(ds);
            xuattonggia(ds);
            DS100m(ds);
            Console.ReadKey();
        }
    }
}
