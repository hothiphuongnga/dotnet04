
// demo

// Console.WriteLine("Bắt đầu đếm ngược!");
// for (int i = 10; i >= 1; i--)
// {
//     Console.WriteLine(i);
//     Thread.Sleep(1000); // Dừng 1 giây
//                         // Thread: xử lý đa luồng
//                         // chạy nhiều việc song song
// }
// khi chạy chương trình thì sẽ tạo thread 
// chạy thread chính của main chứ không tạo mới
// khi nào nó tạo mới : new Thread .....
// Task : chưa học 
// Console.WriteLine("Hết giờ! Bắt đầu sự kiện!");



// for, while, do while : đều là vòng lặp
// for 
/*
cú pháp  
for (khởi_tạo ; điều_kiện ; bước_lặp)
{
    // code thực hiện
}
in ra số từ 0 đến 9 đến
*/ 
for (int i = 11; i >10; i++)
{
    // xủ lý nếu còn chạy vòng lặp
    // in ra số i
    Console.WriteLine(i);
}

/*
int i = 0 : khởi tạo  , khởi tạo ra biến i có giá trị = 0
i < 10 : điều_kiện, điều kiện để vòng lặp tiếp tục chạy , nếu sai điều kiện thì dừng vòng lặp
i++ : bước lặp , sau mỗi lần lặp thì chạy biểu thức này


// luông chạy của for
1: khởi tạo i = 0
2: kiểm tra điều kiện 
3: nếu đúng chạy code trong vòng lặp, nếu sai thì dừng lại
4: bước lặp i++ 
5: quay lại bước 2
*/


// các yếu tố tạo thành vòng lặp  ()

