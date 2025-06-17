// See https://aka.ms/new-console-template for more information 
// note lại thông tin, ghi chú ... 
// Console.WriteLine("Hello, World!");


// // code của intern nga

// Console.WriteLine("Đây là code của Nga");

// // end code của nga


// #region  đây là code của fresher Nga , bỏ qua những dòng này không biên dịch
// var name = "Tiến"; // khai báo biến name
// // biến là gì ?
// // biến là một vùng nhớ được đặt tên, dùng để lưu trữ dữ liệu

// Console.WriteLine("Đây là code của  " + name);

// #endregion

// var age = 18; // khai báo biến age
// Console.WriteLine("Hello " + name + " " + age + " tuổi");// Hello Tiến 18 tuổi
// // cách in ra giá trị bằng string interpolation 
// // đặt biến bên trong dấu ngoặc nhọn {}
// Console.WriteLine($"Hello {name}, {age} tuổi"); // Hello Tiến 18 tuổi



// #region Input và output
// // lệnh nhập Console.Readline() : kiểu dữ liệu trr về là string : chuỗi
// // Chuỗi String : 
// Console.Write("Hãy nhập tên của bạn: ");
// string yourName = Console.ReadLine();// kẹt lại đợi nhập dữ liệu từ bàn phím
// // biến yourName có KDL là string : chuỗi và 
// Console.WriteLine($"Hello {yourName}");
// #endregion
 
// //Cài màu cho chữ trong console
// Console.WriteLine("Text");

// Console.WriteLine("Hello dotnet 04");
// Console.ResetColor();// reset lại màu chữ về mặc định
// ctrl + c : dừng dự án đang chạy (ở ternimal)


//câu lệnh tạo dự án 
//dotnet new console -n ten_du_an
//
// Program.cs : file chính của dự án console

//input 
//Console.ReadLine() : nhập dữ liệu từ bàn phím
// ngừng lại , 

//output
//Console.WriteLine() : có xuống dòng sau mỗi lần in
//Console.Write() : in không xuống dòng
Console.WriteLine("write line");
Console.WriteLine("write line");
Console.WriteLine("write line");
Console.Write("write");
Console.Write("write");
Console.Write("write");

// nối chuỗi
// + : nối chuỗi
// $: chuỗi nội suy
string myName = "PNGA";
Console.WriteLine("Hello " + "World");
Console.WriteLine($"Hello {myName}"); // chuỗi nội suy

