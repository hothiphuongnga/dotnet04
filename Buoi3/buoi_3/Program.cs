#region Phân tích bài toàn
// IPO

/*
INPUT:  đầu vào của bài toán, dự liệu input
PROCESS: hướng xử lý của bài toán, thuật toán, công thức
OUTPUT: đầu ra 
*/
// Nhập vào quãng đường và thời gian đi , tính vận tốc

//input : quãng đường (double), thời gian (double)
//proccess: vận tốc = quãng đường(km) / thời gian(h) (double ) 
// output: vận tốc (double)

// input
// Console.Write("Quãng đường (km): ");
// int distance = int.Parse(Console.ReadLine());
// Console.Write("Thời gian (h): ");
// double time = double.Parse(Console.ReadLine());
// // process
// double result = distance / time; // => double


// // output
// Console.WriteLine($"Vận tốc là: {result:F2} km/h");



// // tính lương
// // input : lương cơ bản (decimal), số ngày làm việc (int)

// // process :
// // >40:   lương cb * 40 + lương tăng ca ()
// // <=40: luongcd * giờ làm việc

// // output: lương (decimal)

// Console.Write("Nhập vào số có 3 chữ số: ");
// int so = int.Parse(Console.ReadLine());
// int tongBaKySo = 0;
// if (so >= 100 && so <= 999)
// {
//     // số hàng trăm
//     int hangTram = so / 100;
//     int hangChuc = (so - hangTram * 100) / 10;
//     int hangDonVi = so - hangTram * 100 - hangChuc * 10;
//     tongBaKySo = hangTram + hangChuc + hangDonVi;
// }

// else
// {
//     Console.WriteLine("Số không hợp lệ, vui lòng nhập số có 3 chữ số.");
// }
// Console.WriteLine("Tổng 3 ký số là: " + tongBaKySo);
// 
#endregion

#region Toán tử ba ngôi
// vd mở máy lạnh  
// nêu nhiệt độ phòng > 25 thì mở máy lạnh còn không thì mở máy sưởi
// int nhietDo = 30;
// if (nhietDo > 25)
//     Console.WriteLine("Mở máy lạnh");
// else
// {
//     Console.WriteLine("Mở máy sưởi");
//     Console.WriteLine("test thử");
// }


// string ketqua = nhietDo > 25 ? "Mở máy lạnh" : "Mở máy sưởi" ;
// Console.WriteLine("ketQua : " + ketqua);
// // cú pháp điều kiện ? giá trị nếu đúng : giá trị nếu sai
// // điều kiện : true false nếu đúng lấy giá trị đầu , sai thì lấy giá trị sau


// double diem = 8;
// string xepLoai = (diem >= 8) ? "Gioi" 
// : 
// diem>=6? "Kha"
// :
// diem>=5? "Trung bình"
// :
//  "yếu";
#endregion




#region switch case
// kiểm tra giá trị 
/*
switch (biến)
{
    case "nhà":
        // xử lý nếu biến = giá trị 1
        break;
    case "cửa hàng":
        // xử lý nếu biến = giá trị 2
        break;
    default:
        // xử lý nếu không khớp với bất kỳ trường hợp nào
        break;
}
*/


// nhập vào số in ra thời tiết tương ứng
Console.Write("Hãy nhập vào số để kiểm tra thời tiết: ");
bool check = int.TryParse(Console.ReadLine(), out int so); // nếu nhập đúng là true, sai là false
// khởi tạo biến so 
if (!check) // !check : không đúng
{
    Console.WriteLine("Dữ liệu nhập không hợp lệ ");
    // lệnh tắt chương trình 
    return; // kết thúc chương trình
}
switch (so)
{
    case int number when number == 1: // so ==1
        Console.WriteLine("Thời tiết hôm nay là nắng");
        break;
    case 2: // so ==2
        Console.WriteLine("Thời tiết hôm nay là mưa");
        break;
    case 3:  // so ==3
        Console.WriteLine("Thời tiết hôm nay là gió");
        break;
    case 4:// so ==4
        Console.WriteLine("Thời tiết hôm nay là tuyết");
        break;
    default:// nếu không khớp với bất kỳ trường hợp nào
        Console.WriteLine("Không có thời tiết tương ứng với số đã nhập");
        break;
}
// kiểm tra khoảng  từ a đến b
// kiểm tra độ tuổi
// Dưới 15 tuổi: nghỉ hè
// 15–64 tuổi: lao động
// Trên 64 tuổi: nghỉ hưu
// net 7
Console.Write("Nhập tuổi: ");
int tuoi = int.Parse(Console.ReadLine());
switch (tuoi)
{
    case int age when age < 15:// gán giá trị tuoi vào age và đem age đi so sánh
        Console.WriteLine("Tuổi thiếu niên, nghỉ hè");
        break;
    case int age when age >= 15 && age <= 64:
        Console.WriteLine("Tuổi lao động, đi làm");
        break;
    case int age when age>64:
        Console.WriteLine("Tuổi nghỉ hưu");
        break;
    default:
        Console.WriteLine("Chưa xác định được độ tuổi");
        break;
}
// net 8  switch expression
string doTuoi = tuoi switch
{
    // xử lý 
    // điều kiện => giá trị 
    < 15 => "Tuổi thiếu niên, nghỉ hè",
    >= 15 and <= 64 => "Tuổi lao động, đi làm",//  && = and . || = or
    _ => "Tuổi nghỉ hưu",
};
Console.WriteLine("ver 8: " + doTuoi);

//net 9
// 
switch (tuoi)
{
    case (< 15):
        Console.WriteLine("Tuổi 15, nghỉ hè");
        break;
    // từ 15 đến 64
    case (>= 15 and <= 64):
        Console.WriteLine("Tuổi lao động, đi làm");
        break;
    case (> 64):
        Console.WriteLine("Tuổi nghỉ hưu");
        break;
    default:
        Console.WriteLine("Chưa xác định được độ tuổi");
        break;
}





#endregion


