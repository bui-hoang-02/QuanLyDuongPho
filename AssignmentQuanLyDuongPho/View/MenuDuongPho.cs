using System;
using AssignmentQuanLyDuongPho.Controller;

namespace AssignmentQuanLyDuongPho.View
{
    public class MenuDuongPho
    {
        public void menuCRUDDuongPho()
        {
            DuongPhoController duongPhoController = new DuongPhoController();
            while (true)
            {
                Console.WriteLine("|-----Chương trình quản lý đường phố------|");
                Console.WriteLine("|-----------------------------------------|");
                Console.WriteLine("| 1. Thêm mới đường phố.                  |");
                Console.WriteLine("| 2. Hiển thị danh sách đường phố.        |");
                Console.WriteLine("| 3. Tìm đường phố theo mã.               |");
                Console.WriteLine("| 4. Sửa thông tin đường phố.             |");
                Console.WriteLine("| 5. Xoá thông tin đường phố.             |");
                Console.WriteLine("| 0. Thoát.                               |");
                Console.WriteLine("|-----------------------------------------|");
                Console.WriteLine("| Vui lòng nhập lựa chọn của bạn (0 -> 5):|");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        duongPhoController.TaoMoiDuongPho();
                        break;
                    case 2:
                        duongPhoController.HienThiDanhSachDuongPho();
                        break;
                    case 3:
                        duongPhoController.TimDuongPhoTheoMa();
                        break;
                    case 4:
                        duongPhoController.SuaThongTinDuongpho();
                        break;
                    case 5:
                        duongPhoController.XoaThongTinDuongPho();
                        break;
                    case 0:
                        break;
                }
            }
        }
    }
}