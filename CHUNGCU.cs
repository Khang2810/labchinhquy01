using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labchinhquy01b4
{
    class CHUNGCU : KHUDAT
    {
        public int sotang;
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
            Console.Write("Nhap so tang: ");
            sotang = int.Parse(Console.ReadLine());
        }
        public override void output()
        {
            base.output();
            Console.Write("So tang: {0}\n", sotang);
        }
        public override string type()
        {
            return "chungcu";
        }
    }
}
