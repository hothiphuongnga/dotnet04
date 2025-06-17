#region Toán tử so sánh
// nếu 9h30 thì tan học,
// nếu hè thì nghỉ (Khối nghỉ hè)
// > < >= <=  bằng
// Tương tự như toán học


//!!!!! LƯU Ý  = 1 dấu bằng là gán giá trị 
// Toán tử so sanh trả ra giá trị là true hoặc false
// == so sánh giá trị bằng nhau  
// > so sánh lớn hơn
// < so sánh nhỏ hơn
// >= so sánh lớn hơn hoặc bằng
// <= so sánh nhỏ hơn hoặc bằng
// != so sánh khác nhau vd: 10 != 20 => 10 có khác 20 không ? -> có : true, không : false

// int a = 10;
// int b = 10;
// // 10 có lớn hơn hoặc bằng 10 không ? 
// // hoặc có nghĩa là 1 trong 2 điều kiện đúng thì sẽ là đúng
// // và có nghĩa là cả 2 điều kiện đều đúng thì mới là đúng 
// bool isEquals = a == b; // so sánh bằng
// Console.WriteLine($"SO sánh bằng giữa a và b là: {a == b}");
// Console.WriteLine($"So sánh lớn hơn giữa a và b là: {a > b}");
// Console.WriteLine($"So sánh nhỏ hơn giữa a và b là: {a < b}");
// Console.WriteLine($"So sánh lớn hơn hoặc bằng giữa a và b là: {a >= b}");
// Console.WriteLine($"So sánh nhỏ hơn hoặc bằng giữa a và b là: {a <= b}");
// Console.WriteLine($"So sánh khác nhau giữa a và b là: {a != b}");


// // so sanh 2 gtri có kdl khác nhau sẽ như nào

// object tuoi = 18;
// object strTuoi = 18;
// Console.WriteLine($"tuoi: {tuoi}");
// Console.WriteLine($"strtuoi: {strTuoi}");
// //so sánh
// bool ssTuoi = tuoi == strTuoi;
// Console.WriteLine("kết quả so sánh tuổi và strTuoi là: " + ssTuoi);


// // toán tử logic (&&, ||, !)


// // && - và - nếu tất cả điều kiện đều đúng thì kết quả cuối cùng mới đúng
// // nếu hôm nay trời mưa và các bạn không có áo mưa => ướt / ở nhà học online
// //        ok mưa                   không có         => 
// //        đúng                      đúng            =>  đúng là ướt

// // xinh gái    &&    học giỏi  => 
// // không xinh  &&   học không giỏi ==> không quen

// bool xinhGai = false;
// bool hocGioi = true;
// bool ketQua = xinhGai && hocGioi;
// Console.WriteLine("Em có đủ điều kiện để làm bạn gái tôi không? " + ketQua);


// // || - hoặc . Chỉ cần 1 trong các dk đúng thì kết quả cuối cùng sẽ đúng
// // giàu có         true       
// // thông minh      false
// // có công việc ổn đinhj    true
// // tình huống : bạn nữ quá giàu rồi
// bool giauCo = false;
// bool thongMinh = false;
// bool congViecOnDinh = false;
// bool ketQuaHoac = giauCo || thongMinh || congViecOnDinh;
// Console.WriteLine("Anh có đủ điều kiện để làm bạn trai tôi không? " + ketQuaHoac);
// // ! - phủ định

// // phủ định của 1 điều kiện, nếu đúng thì sẽ thành sai, nếu sai thì sẽ thành đúng

// bool isTrue = true;
// Console.WriteLine("Phủ định của isTrue là: " + !isTrue);

// bool phDinhSS = 10 == 10;
// Console.WriteLine($"phủ định của kết quả 10==10 là {!(10 == 10)}"); // false
// Console.WriteLine($"phủ định của kết quả 10==10 là {!phDinhSS}");
#endregion




#region Câu trúc điều kiện
// Dùng để kiểm tra điều kiện, nếu đúng thì sẽ làm 1 việc gì đó, nếu sai thì sẽ làm việc khác
// cú pháp
/*

điều kiện: KDL là bool hoặc biểu thức so sánh (vì nó sẽ trả về true hoặc false)
if(điều kiện)
{
    // nếu điều kiện đúng thì sẽ làm việc này
}
else
{
    // nếu điều kiện sai thì sẽ làm việc này
}

*/
//kiểm tra nhiệt độ cơ thể và thông báo tình trạng sức khỏe
// bình thường 36 - 37.5 độ C
// có vấn đề

//DEMO 1
//b1: nhập vào nhiệt độ cơ thể
// Console.WriteLine("Nhập vao nhiệt độ cơ thể của bạn (độ C): ");
// double nhietDoCoThe = double.Parse(Console.ReadLine());
// //b2: kiểm tra nhiệt độ cơ thể
// // nếu lớn hơn 37.5 thì thông báo có vấn  đề    // vế nếu là if
// // nếu nhỏ hơn 36 thì thông báo có vấn đề    // vế nếu là if
// //  còn lại là bình thường 
// if (nhietDoCoThe > 37.5)
// {
//     // nếu lớn hơn 37.5 thì code ở đây sẽ chạy
//     Console.WriteLine("Có vấn đề về sức khỏe, bạn nên đi khám bác sĩ.");
// }
// if (nhietDoCoThe < 36)
// {
//     // nếu nhỏ hơn 36 thì code ở đây sẽ chạy
//     Console.WriteLine("Có vấn đề về sức khỏe, bạn nên đi khám bác sĩ.");
// }
// else// những trường hợp còn lại sẽ là bình thường
// {
//     Console.WriteLine("Bạn có sức khỏe bình thường.");
// }



// // code thay thế bằng AI đã tối ưu

// if (nhietDoCoThe < 36 || nhietDoCoThe > 37.5) 
// // nếu nhiệt độ nhỏ hơn 36 hoăck lớn hơn 37.5 là có vấn đề
// {
//     Console.WriteLine("Có vấn đề về sức khỏe, bạn nên đi khám bác sĩ.");
// }
// else
// {
//     Console.WriteLine("Bạn có sức khỏe bình thường.");
// }
//b3: thông báo tình trạng sức khỏe


// nhập vào số tuổi và kiểm tra xem còn trong độ tuổi tham gia NVQS hay không
// độ tuổi NVQS là từ 18 - 27 

// điều kiện tham gia NVQS là từ 18 - 27 tuổi
//  Console.WriteLine("nhập tuổi: ");
//  int tuoi = int.Parse(Console.ReadLine());
// // nếu tuổi nhỏ hơn 18 thì không đủ tuổi tham gia NVQS
// // nếu tuổi lớn hơn 27 thì không đủ tuổi tham gia NVQS

// //

// // điều kiện miễn than gia 
// if (tuoi < 18 || tuoi > 27)
// {
//     Console.WriteLine("Bạn không đủ tuổi tham gia NVQS.");
// }
// else // những trường hợp còn lại sẽ là đủ tuổi
// {
//     Console.WriteLine("Bạn đủ tuổi tham gia NVQS.");
// }


Console.WriteLine("Nhập vào số tuổi của bạn: ");
int age = 17;

if (age < 18)  // đúng
{
    Console.WriteLine("Bạn chưa đủ tuổi nghĩa vụ quân sự.");
}
else if (age >= 18 && age <= 27) // từ đây trở xuống sẽ không chạy
{
    Console.WriteLine("Bạn đủ tuổi nghĩa vụ quân sự.");
}
else
{
    Console.WriteLine("Bạn đã quá tuổi nghĩa vụ quân sự.");
}



// if => else if ..... else if ..... => else 

if (true) // 
{
    Console.WriteLine("hello");
}


// diểm
// dtb => học lực giỏi, khá, trung bình, yếu, kém
// điểm từ 8.0 - 10.0 là giỏi
// điểm từ 6.5 - 7.9 là khá
// điểm từ 5.0 - 6.4 là trung bình
// điểm từ 3.0 - 4.9 là yếu
// nhập vào điểm trung bình và thông báo học lực

//b1 : nhập điểm trung bình
// Console.WriteLine("Nhập điểm trung bình cách 1: ");
// string input = Console.ReadLine();
// double dtb = 0;
// //b2 : Kiểm tra điểm hợp lệ hay chưa
// bool isValid = double.TryParse(input, out dtb);
// nếu như input là số thì gán nó cho dtb và isValid sẽ là true
// nếu không phải là số thì isValid sẽ là false và dtb sẽ là 0
// cách 2
Console.WriteLine("Nhập điểm trung bình cách 2: ");
bool hopLe = double.TryParse(Console.ReadLine(), out double diemTrungBinh);
// bool hopLe2 = double.TryParse(Console.ReadLine(), out dtb);
// kiểm tra dữ liệu nhập có hợp lệ không nếu có thì tạo biến diemTrungBinh gán giá trị cho nó
// nếu hợp lệ thì isValid sẽ là true và diemTrungBinh sẽ có giá trị là số nhập vào
Console.WriteLine($"Diểm trung bình là: {diemTrungBinh}");
if (hopLe && diemTrungBinh >= 0 && diemTrungBinh <= 10)// bổ sung kiểm tra ở đây kiểm tra >0 <=10
// nếu hợp lệ (là số)  >0    <10
{
    Console.WriteLine("Đã nhập đúng");
}
else
{
    Console.WriteLine("Điểm không hợp lệ, vui lòng nhập lại.");
    return; // dừng chương trình nếu điểm không hợp lệ, thoát hẳn luôn 
}

//b3 : tính điểm tb
if (diemTrungBinh >= 8.0) // diem =7
{
    Console.WriteLine("Học lực giỏi.");
}
else if (diemTrungBinh >= 6.5) // nếu lớn hơn 7.9 thì kẹt ở trên rồi 
{
    Console.WriteLine("Học lực khá.");
}
else if (diemTrungBinh >= 5.0)
{
    Console.WriteLine("Học lực trung bình.");
}
else if (diemTrungBinh >= 3.0)
{
    Console.WriteLine("Học lực yếu.");
}
else
{
    Console.WriteLine("Học lực kém.");
}
//b4 : thông báo học lực




#endregion

#region Switch case
// switch case : là một cấu trúc điều kiện khác, dùng để kiểm tra giá trị của biến, nếu giá trị của biến khớp với giá trị nào thì sẽ chạy vào case đó

// cú pháp

// switch(biến kiểm tra){
//     case giá trị 1: 
//         // code sẽ chạy vào đây nếu biến == giá trị 1    
//         break;
//     case giá trị 2:
//         // code sẽ chạy vào đây nếu biến == giá trị 2
//         break;
//     default:
//         // code sẽ chạy vào đây nếu không khớp với giá trị nào
//         break;
// }
//gọi cho tổng đài ví dụ như tổng đài 1800xxxx

// 1 dịch vụ sim số 
// 2 dịch vụ internet
// 3 dịch vụ truyền hình
// 4 dịch vụ khác
Console.WriteLine("Chào mừng bạn đến với tổng đài chăm sóc khách hàng.");
Console.WriteLine("Nhập chức năng: ");
int luaChon = int.Parse(Console.ReadLine());
// switch dùng để kiểm tra giá trị của biến

// break: 
switch (luaChon)
{
    case 1:
        Console.WriteLine("Bạn đã chọn dịch vụ sim số.");
        break;
    case 2:
        Console.WriteLine("Bạn đã chọn dịch vụ internet.");
        break;
    case 3:
        Console.WriteLine("Bạn đã chọn dịch vụ truyền hình.");
        break;
    case 4:
        Console.WriteLine("Bạn đã chọn dịch vụ khác.");
        break;
    default:// khi không có case nào khớp với giá trị thì sẽ chạy vào đây
        Console.WriteLine("KHông có chức năng");
        break;
}



#endregion



