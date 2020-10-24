using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labchinhquy01b2
{
    class PERSON
    {
        public string ID;
        public string fullName;
        public string gID
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }
        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                fullName = value;
            }
        }
        public PERSON() { }
        public PERSON(string id, string name, float score, string faculty)
        {
            ID = id;
            fullName = name;
        }
        public virtual void Input()
        {
            Console.Write("Nhap ID: ");
            ID = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            fullName = Console.ReadLine();
        }
        public virtual void Show()
        {
            Console.WriteLine("MSSV:{0} Ho ten:{1}", this.ID, this.fullName);
        }
        public virtual string type()
        {
            return null;
        }
    }
}
