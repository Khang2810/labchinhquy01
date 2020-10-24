using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labchinhquy01b1
{
    class bai1b
    {
        private static List<STUDENT> NhapDSSinhVien()
        {
            List<STUDENT> listStudents = new List<STUDENT>();
            Console.Write("Nhap tong so sinh vien N=");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n ====Nhap danh sach sinh vien====");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("\n - Nhap sinh vien thu {0}", i + 1);
                STUDENT temp = new STUDENT();
                temp.Input();
                listStudents.Add(temp);
            }
            return listStudents;
        }
        private static void XuatDSSinhVien(List<STUDENT> listStudents)
        {
            Console.WriteLine("\n ====Xuat danh sach sinh vien====");
            foreach (STUDENT sv in listStudents)
            {
                sv.Show();
            }
        }
        private static void DSSVthuoccuakhoa(string khoa, List<STUDENT> listStudents)
        {
            List<STUDENT> listStudentskhoa = (from s in listStudents
                                              where s.Faculty == khoa
                                              select s).ToList();
            if (listStudentskhoa.Count() == 0)
                Console.WriteLine("Khong co sinh vien thuoc khoa {0}", khoa);
            else
            {
                Console.Write("\n ====Khoa {0}:====", khoa);
                XuatDSSinhVien(listStudentskhoa);
            }
        }
        private static void DSSVtrendiemTB(float diem, List<STUDENT> listStudents)
        {
            List<STUDENT> listStudentskhoa = (from s in listStudents
                                              where s.AverageScore >= diem
                                              select s).ToList();
            if (listStudentskhoa.Count() == 0)
                Console.WriteLine("Khong co sinh vien co diem TB tren {0}", diem);
            else
            {
                Console.Write("\n ====Sinh vien tren {0} diem:====", diem);
                XuatDSSinhVien(listStudentskhoa);
            }
        }
        private static void DSSVsortbydiemTB(List<STUDENT> listStudents)
        {
            List<STUDENT> listStudentsorted = (from s in listStudents
                                               orderby s.AverageScore
                                               select s).ToList();
            XuatDSSinhVien(listStudentsorted);
        }
        private static void DSSVtren5cuaCNTT(float diem, string khoa, List<STUDENT> listStudents)
        {
            List<STUDENT> listStudentsorted = (from s in listStudents
                                               where s.AverageScore >= diem && s.Faculty == khoa
                                               select s).ToList();
            if (listStudentsorted.Count() == 0)
                Console.WriteLine("Khong co sinh vien co diem TB tren {0} thuoc khoa {1}", diem, khoa);
            else
            {
                XuatDSSinhVien(listStudentsorted);
            }
        }
        private static void DSSVtop1cuaCNTT(string khoa, List<STUDENT> listStudents)
        {
            List<STUDENT> listStudentsorted = (from s in listStudents
                                               where s.Faculty == khoa
                                               orderby s.AverageScore
                                               select s).ToList();
            if (listStudentsorted.Count() == 0)
                Console.WriteLine("Khong co sinh vien thuoc khoa {1}", khoa);
            else
            {
                STUDENT temp = listStudentsorted.Last();
                temp.Show();
            }

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            List<STUDENT> listStudents = NhapDSSinhVien();
            //XuatDSSinhVien(listStudents);
            //DSSVsortbydiemTB(listStudents);
            //DSSVtren5cuaCNTT(5, "CNTT", listStudents);
            //DSSVtop1cuaCNTT("CNTT",listStudents);
            Console.ReadKey();
        }
    }
}
