namespace lap1._3
{
    internal class Program
{
    static void Main(string[] args)
    {
            //int msv = 1;
            //string ten = "nguyen huy tu";
            //float can = 52.6f;
            //string gioi_tinh = "M";
            //int tuoi = 18;

            //Console.WriteLine("ma sinh vien : {0}", msv);
            //Console.WriteLine("ho va ten : {0}", ten);
            //Console.WriteLine("tuoi : " + tuoi);
            //Console.WriteLine("gioi tinh : {0}", gioi_tinh);
            //Console.WriteLine("can nang : " + can);
            //Console.Read();

            string msv, ten;
            double mon1, mon2, mon3, tb;
           DateTime ngay_sinh;

            Console.Write("nhap ma sinh vien : ");
            msv = Console.ReadLine();
            Console.Write("nhap ten :");
            ten = Console.ReadLine();
            Console.Write("ngay thang nam sinh : ");
            ngay_sinh = Convert.ToDateTime(Console.ReadLine());
            Console.Write("nhap diem mon 1 : ");
            mon1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("nhap diem mon 2 : ");
            mon2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("nhap diem mon 3 : ");
            mon3 = Convert.ToDouble(Console.ReadLine());
            tb = (mon1 + mon2 + mon3) / 3;
            Console.WriteLine("\n thong tin sinh vien");
            Console.WriteLine("ma sinh vien : {0}", msv);
            Console.WriteLine("ho va ten : ", ten);
            Console.WriteLine("ngay thang nam sinh: ", ngay_sinh);
            Console.WriteLinee("diem trung binh la : {0}", tb);
            Console.ReadLine();


            //string id, name;
            //double mark1, mark2, mark3, average;
            //DateTime birthday;
            //Console.Write("Nhap ma so:");
            //id = Console.ReadLine();
            //Console.Write("Nhap ten:");
            //name = Console.ReadLine();
            //Console.Write("Nhap ngay sinh:");
            //birthday = Convert.ToDateTime(Console.ReadLine());
            //Console.Write("Nhap diem mon 1:");
            //mark1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Nhap diem mon 2:");
            //mark2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Nhap diem mon 3:");
            //mark3 = Convert.ToDouble(Console.ReadLine());
            ////tính điểm trung bình
            //average = (mark1 + mark2 + mark3) / 3;
            ////In thông tin ra màn hình
            //Console.WriteLine("\n Thong tin sinh vien");
            //Console.WriteLine("Ma so:{0}", id);
            //Console.WriteLine("Ho va ten:{0}", name);
            //Console.WriteLine("Ngay sinh:{0:dd/MM/yyyy}", birthday);
            //Console.WriteLine("Diem 1:{0:N}, Diem 2:{1:N}, Diem 2:{2:N}", mark1,
            //mark2, mark3);
            //Console.WriteLine("Diem trung binh:{0:N}", average);
            //Console.ReadLine();
        }
}
}