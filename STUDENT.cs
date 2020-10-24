using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labchinhquy01b2
{
    class STUDENT:PERSON
    {
        public float averageScore;
        public string faculty;
        public float AverageScore
        {
            get
            {
                return averageScore;
            }
            set
            {
                averageScore = value;
            }
        }
        public string Faculty
        {
            get
            {
                return faculty;
            }
            set
            {
                faculty = value;
            }
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap DTB: ");
            averageScore = float.Parse(Console.ReadLine());
            Console.Write("Nhap khoa: ");
            faculty = Console.ReadLine();
        }
        public override void Show()
        {
            Console.WriteLine("Khoa:{0} DiemTB:{1}", this.faculty, this.averageScore);
        }
        public override string type()
        {
            return "student";
        }
    }
}