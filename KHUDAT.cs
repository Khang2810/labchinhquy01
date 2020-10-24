using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labchinhquy01b4
{
    class KHUDAT
    {
        public string diachi;
        public int giaban;
        public float dientich;
        public string Gdiachi
        {
            get
            {
                return diachi;
            }
            set { diachi = value; }
        }
        public int Ggiaban
        {
            get
            {
                return giaban;
            }
            set
            {
                giaban = value;
            }
        }
        public float Gdientich
        {
            get
            {
                return dientich;
            }
            set
            {
                dientich = value;
            }
        }
        public KHUDAT()
        {

        }
        public KHUDAT(string a, int b, float c)
        {
            diachi = a;
            giaban = b;
            dientich = c;
        }
        public virtual void input()
        {
            Console.Write("Nhap dia chi: ");
            diachi = Console.ReadLine();
            Console.Write("Nhap gia ban: ");
            giaban = int.Parse(Console.ReadLine());
            Console.Write("Nhap dien tich: ");
            dientich = float.Parse(Console.ReadLine());
        }
        public virtual void output()
        {
            Console.Write("Dia chi: {0}\nGia ban: {1}\nDien tich: {2}\n", diachi, giaban, dientich);
        }
        public virtual string type()
        {
            return null;
        }
    }
}
