using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labchinhquy01b2
{
    class TEACHER:PERSON
    {
        public string diachi;
        public string gdiachi
        {
            get
            {
                return diachi;
            }
            set
            {
                diachi = value;
            }
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap dia chi: ");
            diachi = Console.ReadLine();
        }
        public override void Show()
        {
            Console.WriteLine("Khoa:{0}", this.diachi);
        }
        public override string type()
        {
            return "teacher";
        }
    }
}
