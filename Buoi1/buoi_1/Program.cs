#region BÀI TẬP NHIỆT ĐỘ
// b1: nhập vào nhiệt độ

// Console.Write("Hãy nhập vào nhiệt độ C : ");
// string nhietDo = Console.ReadLine();
// //b2: tạm thời bỏ qua bước kiểm tra 

// // b3: dùng công thức để chuyển đổi nhiệt độ F = C * 9/5 + 32)
// // chuyển sang int hay double
// var ketQua = double.Parse(nhietDo) * 9 / 5 + 32;

// // b4: in ra kết quả
// Console.WriteLine("Kết quả chuyển đổi sang F là: " + ketQua);
#endregion

#region BÀI TẬP TÍNH DIỆN TÍCH HÌNH TRÒN
// b1: nhập bán kính
// Console.WriteLine("Kỹ sư hãy nhập vào bán kính hình tròn: ");
// double banKinh = double.Parse(Console.ReadLine()); // chuyển về double ngắn gọn
// //b2: tạm thời bỏ qua bước kiểm tra

// // b3: dùng công thức tính diện tích hình tròn S = π * r^2, chu vi C = 2 * π * r
// //cách 1: dùng thủ công
// var dienTich = 3.14 * banKinh * banKinh;
// var chuVi = 2 * 3.14 * banKinh;
// //cách 2: dùng Math.PI
// dienTich = Math.PI * Math.Pow(banKinh, 2);
// //Math.Pow(banKinh, 2) bán kính mũ 2
// chuVi = 2 * Math.PI * banKinh;

// //b4: in ra kết quả
// Console.WriteLine("Diện tích hình tròn là: " + Math.Round(dienTich, 2) ); // làm tròn đến 2 chữ số thập phân
// Console.WriteLine($"Diện tích hình tròn là: {dienTich:f2}"); // làm tròn đến 2 chữ số thập phân

// Console.WriteLine("Chu vi hình tròn là: " + Math.Round(chuVi, 2)); // làm tròn đến 2 chữ số thập phân
#endregion

#region Bài tập 3

// Yêu cầu tính BMI, cần có cân năng và chiều cao
//BMI = cân nặng (kg) / chiều cao² (m²).
// b1: nhập cân nặng và chiều cao
// Console.WriteLine("Nhập vào cân nặng (kg): ");
// double canNang = double.Parse(Console.ReadLine());
// Console.WriteLine("Nhập vào chiều cao (m): ");
// double chieuCao = double.Parse(Console.ReadLine());
// // b2: tạm thời bỏ qua bước kiểm tra

// // b3: dùng công thức BMI = cân nặng / (chiều cao * chiều cao)
// var BMI = canNang / (chieuCao * chieuCao);
// BMI = canNang / Math.Pow(chieuCao, 2);
// // b4: in ra kết quả
// Console.WriteLine("Chỉ số BMI của bạn là: " + Math.Round(BMI, 5)); // làm tròn đến 2 chữ số thập phân
// Console.WriteLine($"Chỉ số BMI của bạn là: {BMI:f5}"); 

#endregion

#region Toán tử is as
// is : kiểm tra xem biến có phải là KLD cụ thể hay không 
// return về true hoặc false
var tuoi = "20"; ;
bool laTuoi = tuoi is int; // kiểm tra xem tuổi có phải là int không
// nếu đúng là laTuoi=true ngược lại là false
Console.WriteLine($"Tuổi là int: {laTuoi}");

// as : kiểm tra và ép kiểu an toàn
// var tenLopHoc = "Dotnet 04";//

// object  là kiểu dữ liệu "cha" của tất cả các kiểu dữ liệu trong C#, nó có thể chứa bất kỳ kiểu dữ liệu nào.
object tenLopHoc = 04;//ép ngầm định (ép nhỏ sang lớn)
string tenLop = tenLopHoc as string;
// kiểm tra xem tenlophoc có phải là string không , nếu đúng thì gán vào tenLop
// nếu không phải thì tenLop sẽ là null
Console.WriteLine("Ten lớp học: " + tenLopHoc);
Console.WriteLine("Ten lớp : " + tenLop);

#endregion


// var soNguyen = 10; // dựạ vào giá trị để xd KDL
// soNguyen = 10.5; // ép ngầm định không được | báo lỗi;
object soThuc = 97.8; // vì object là kiểu dữ liệu cha của tất cả các kiểu dữ liệu trong C#, nên có thể gán bất kỳ kiểu dữ liệu nào vào nó
soThuc = 10;
soThuc = "Dotnet 04";
soThuc = true; // ép ngầm định sang object được



#region Toán tử khác
// typeof, sizeof, 
// typeof :kiểm tra kiểu , dùng với KDL

Console.WriteLine("Kiểu dữ liệu của số nguyên là : " + typeof(int));
// thoiGian: instance của kiểu dữ liệu int
// GetType: dùng với biến đã khởi tạo, instance của kiểu dữ liệu
int thoiGian = 30;
Console.WriteLine("KDL của thoiGian là: " + thoiGian.GetType()); // kiểm tra kiểu dữ liệu của biến thoiGian
// sizeof: lấy kích thước của kiểu dữ liệu trong bộ nhớ
Console.WriteLine("Kích thước của kiểu dữ liệu double là: " + sizeof(double) + " byte");

// default: giá trị mặc định của kiểu dữ liệu

int? tong; // giá trị mặc định của int là 0

// xử lý gán giá trị tính toán cho a
tong = 2 + 4;
//
Console.WriteLine("Your text here: " + tong); // giá trị mặc định của int là 0



#endregion




