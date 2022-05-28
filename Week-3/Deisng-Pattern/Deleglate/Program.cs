using System;

delegate int NumberChanger(int n);
namespace DelegateAppl
{

    class TestDelegate
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            //tạo thể hiện delegate
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            //gọi phương thức sử dụng đối tượng delegate
            nc1(25);
            Console.WriteLine("Giá trị của số: {0}", getNum());
            nc2(5);
            Console.WriteLine("Giá trị của số: {0}", getNum());
            Console.ReadKey();
        }
    }
}