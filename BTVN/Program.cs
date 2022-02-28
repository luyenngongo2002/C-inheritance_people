using System;
namespace BTVN
{
    class Person
    {
        public string name;
        public int birthday;
        public Person()
        {
            name = "Luyen Ngo";
            birthday = 2002;
        }
        public Person(string name, int birthday)
        {
            this.name = name;
            this.birthday = birthday;
        }
        public void hienthi()
        {
            Console.WriteLine(" Tên: {0}, năm sinh: {1}", name,birthday);
        }
    }
    class Subject
    {
        public string monhoc;
        public int sotiet;
        public Subject()
        {
            monhoc = "toan";
            sotiet = 20;
        }
        public Subject(string monhoc, int sotiet)
        {
            this.monhoc = monhoc;
            this.sotiet = sotiet;
        }
        public Subject(int sotiet)
        {
            
            this.sotiet = sotiet;
        }
        public void hienthi()
        {
            Console.WriteLine(" Mon hoc:{0},sotiet{1}", monhoc, sotiet);
        }

    }
    class Teachers : Person
    {
        public string bomon;
        public string monhoc;
        public Teachers()
        {
            bomon = "the duc";
            monhoc = "toan";
        }
        public Teachers(string name,int birthday, string bomon, string monhoc):base(name, birthday)
        {
            this.bomon = bomon;
            this .monhoc = monhoc;
            
        }
        public new void hienthi()
        {
            base.hienthi();
            Console.WriteLine(" Bộ môn:{0},mon hoc:{1}", bomon, monhoc);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap ten: ");
            string name = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh: ");
            int birthday = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mon hoc: ");
            string bomon = Console.ReadLine();
            Console.WriteLine("Nhap mon day: ");
            string monhoc = Console.ReadLine();
            Console.WriteLine("Nhap so tiet: ");
            int sotiet = int.Parse(Console.ReadLine());
            Teachers TC = new Teachers(name, birthday,bomon ,monhoc);
            TC.hienthi();
            Subject SB = new Subject(sotiet);// tạo đối tượng
            SB.hienthi();


            //Teachers GV = new Teachers();// tạo đối tượng
            //GV.hienthi();
            //Subject SB = new Subject();// tạo đối tượng
            //SB.hienthi();

        }
    }
}


