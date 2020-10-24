using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labchinhquy01b2
{
    class bai2
    {
        private static List<PERSON> nhap()
        {
            List<PERSON> list = new List<PERSON>();
            Console.Write("Nhap tong so doi tuong N=");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n ====Nhap danh sach doi tuong====");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("\n - Nhap sinh vien{0}, giao vien (1)", i + 1);
                int type = Convert.ToInt32(Console.ReadLine());
                if (type == 0)
                {
                    PERSON temp = new STUDENT();
                    temp.Input();
                    list.Add(temp);
                }
                if (type == 1)
                {
                    PERSON temp = new TEACHER();
                    temp.Input();
                    list.Add(temp);
                }
            }
            return list;
        }
        private static void svCNTT(List<PERSON> list)
        {
            List<PERSON> temp = (from s in list
                                              where ((STUDENT)s).Faculty == "CNTT"
                                              select s).ToList();
            if (temp.Count() == 0)
                Console.WriteLine("Khong co sinh vien thuoc khoa CNTT");
            else
            {
                Console.Write("\n ====Khoa CNTT:====");
                xuat(temp);
            }
        }
        private static void xuat(List<PERSON> list)
        {
            Console.WriteLine("\n ====Xuat danh sach====");
            foreach (PERSON sv in list)
            {
                sv.Show();
            }
        }
        private static void DSSVduoi5cuaCNTT(List<PERSON> list)
        {
            List<PERSON> temp = (from s in list
                                               where ((STUDENT)s).AverageScore < 5 && ((STUDENT)s).Faculty == "CNTT"
                                               select s).ToList();
            if (temp.Count() == 0)
                Console.WriteLine("Khong co sinh vien co diem TB duoi 5 thuoc khoa CNTT");
            else
            {
                xuat(temp);
            }
        }
        private static void giaovienQ9(List<PERSON> list)
        {
            List<PERSON> temp = (from s in list
                                 where ((TEACHER)s).diachi == "Quan 9"
                                 select s).ToList();
            if (temp.Count() == 0)
                Console.WriteLine("Khong co giao vien Q 9");
            else
            {
                xuat(temp);
            }
        }
        private static void giaovienma(List<PERSON> list)
        {
            List<PERSON> temp = (from s in list
                                 where ((TEACHER)s).ID == "CHN06286" && ((TEACHER)s).type().CompareTo("teacher")==0
                                 select s).ToList();
            if (temp.Count() == 0)
                Console.WriteLine("Khong co giao vien nay");
            else
            {
                xuat(temp);
            }
        }
        private static void DSSVtop1cuaCNTT(List<PERSON> list)
        {
            List<PERSON> temp0 = (from s in list
                                               where ((STUDENT)s).Faculty == "CNTT"
                                               orderby ((STUDENT)s).AverageScore
                                               select s).ToList();
            if (temp0.Count() == 0)
                Console.WriteLine("Khong co sinh vien thuoc khoa CNTT");
            else
            {
                STUDENT temp = (STUDENT)temp0.Last();
                temp.Show();
            }

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            List<PERSON> list = nhap();
            xuat(list);
            svCNTT(list);
            DSSVduoi5cuaCNTT(list);
            giaovienQ9(list);
            giaovienma(list);
            DSSVtop1cuaCNTT(list);
            Console.ReadKey();
        }
    }
}
