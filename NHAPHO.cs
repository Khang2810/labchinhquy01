using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labchinhquy01b4
{
    class NHAPHO : KHUDAT
    {
        public int namxaydung;
        public int sotang;
        public int Gnamxaydung
        {
            get
            {
                return namxaydung;
            }
            set { namxaydung = value; }
        }
        public int Gsotang
        {
            get
            {
                return sotang;
            }
            set { sotang = value; }
        }
        public override void input()
        {
            base.input();
            Console.Write("Nhap nam xay dung: ");
            namxaydung = int.Parse(Console.ReadLine());
            Console.Write("Nhap so tang: ");
            sotang = int.Parse(Console.ReadLine());
        }
        public override void output()
        {
            base.output();
            Console.Write("Nam xay dung: {0}\nSo tang: {1}", namxaydung, sotang);
        }
        public override string type()
        {
            return "nhapho";
        }
    }
}

