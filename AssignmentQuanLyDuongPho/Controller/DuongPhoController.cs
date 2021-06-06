using System;
using System.Collections.Generic;
using System.Text;
using AssignmentQuanLyDuongPho.Entity;
using AssignmentQuanLyDuongPho.Model;

namespace AssignmentQuanLyDuongPho.Controller
{
    public class DuongPhoController
    {
        private DuongPhoModel _duongPhoModel = new DuongPhoModel();
        public void TaoMoiDuongPho()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Vui lòng nhập thông tin đường phố.");
            Console.WriteLine("Nhập mã đường phố.");
            DuongPho duongPho = new DuongPho();
            var maduongpho = int.Parse(Console.ReadLine());
            duongPho.Ma = maduongpho;
            Console.WriteLine("Nhâp tên đường phố.");
            var tenDuongPho = Console.ReadLine();
            duongPho.Ten = tenDuongPho;
            Console.WriteLine("Nhâp diễn tả đường phố.");
            var dienTaDuongPho = Console.ReadLine();
            duongPho.DienTa = dienTaDuongPho;
            Console.WriteLine("Nhâp ngày bắt đầu đường phố.");
            var ngayBatDauSuDungDuongPho = Console.ReadLine();
            duongPho.NgayBatDauSuDung = ngayBatDauSuDungDuongPho;
            Console.WriteLine("Nhập lịch sử tên dường phố.");
            var lichSuTenDuongPho = Console.ReadLine();
            duongPho.LichSuTenDuong = lichSuTenDuongPho;
            Console.WriteLine("Nhập tên quận của đường phố.");
            var tenQuanDuongPho = Console.ReadLine();
            duongPho.TenQuan = tenQuanDuongPho;
            Console.WriteLine("Nhập trạng thái đường phố.");
            var trangThaiDuongPho = int.Parse(Console.ReadLine());
            duongPho.TrangThai = trangThaiDuongPho;
            bool result = _duongPhoModel.save(duongPho);
            if (result)
            {
                Console.WriteLine("Tạo đường phố mới thành công.");
            }
            else
            {
                Console.WriteLine("Tạo đường phố mới thất bại. Vui lòng liên hệ Admin");
            }
        }

        public void HienThiDanhSachDuongPho()
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<DuongPho> listDuongPho = _duongPhoModel.FindAll();
            Console.WriteLine("Thông tin sinh viên vừa nhâpj là:");
            for (int i = 0; i < listDuongPho.Count; i++)
            {
                var duongPho = listDuongPho[i];
                Console.WriteLine($"Mã: {duongPho.Ma}, tên: {duongPho.Ten}, diễn tả: {duongPho.DienTa}, ngày sử dụng: {duongPho.NgayBatDauSuDung}, lịch sử đường: {duongPho.LichSuTenDuong}, tên quận: {duongPho.TenQuan}, trạng thái: {duongPho.TrangThai}");
            }
        }

        public void TimDuongPhoTheoMa()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var duongPhoModel = new DuongPhoModel();
            Console.WriteLine("Nhập mã đuòng phố cần tìm.");
            int maDuongPho = int.Parse(Console.ReadLine());
            DuongPho dp1 = duongPhoModel.findById(maDuongPho);
            Console.WriteLine($"Mã: {dp1.Ma}, tên: {dp1.Ten}, diễn tả: {dp1.DienTa}, ngày sử dụng: {dp1.NgayBatDauSuDung}, lịch sử đường: {dp1.LichSuTenDuong}, tên quận: {dp1.TenQuan}, trạng thái: {dp1.TrangThai}");
        }

        public void SuaThongTinDuongpho()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var duongPhoDbModel = new DuongPhoModel();
            Console.WriteLine("Nhập mã đường phố cần sửa.");
            var maDuongPho = int.Parse(Console.ReadLine());
            DuongPho duongPho1 = duongPhoDbModel.findById(maDuongPho);
            if (duongPho1 == null)
            {
                Console.WriteLine("Không tìm được đuòng phố cần sửa.");
                return;
            }
            Console.WriteLine("Nhâp tên đường phố cần update.");
            var tenDuongPho = Console.ReadLine();
            duongPho1.Ten = tenDuongPho;
            Console.WriteLine("Nhâp diễn tả đường phố cần update.");
            var dienTaDuongPho = Console.ReadLine();
            duongPho1.DienTa = dienTaDuongPho;
            Console.WriteLine("Nhâp ngày bắt đầu đường phố cần update.");
            var ngayBatDauSuDungDuongPho = Console.ReadLine();
            duongPho1.NgayBatDauSuDung = ngayBatDauSuDungDuongPho;
            Console.WriteLine("Nhập lịch sử tên dường phố cần update.");
            var lichSuTenDuongPho = Console.ReadLine();
            duongPho1.LichSuTenDuong = lichSuTenDuongPho;
            Console.WriteLine("Nhập tên quận của đường phố cần update.");
            var tenQuanDuongPho = Console.ReadLine();
            duongPho1.TenQuan = tenQuanDuongPho;
            Console.WriteLine("Nhập trạng thái đường phố cần update.");
            var trangThaiDuongPho = int.Parse(Console.ReadLine());
            duongPho1.TrangThai = trangThaiDuongPho;
            bool result = duongPhoDbModel.update(maDuongPho, duongPho1);
            if (result)
            {
                Console.WriteLine("Sửa thông tin thành công.");   
            }
            else
            {
                Console.WriteLine("Sửa thông tin không thành công. Vui lòng liên hệ admin.");
            }
        }

        public void XoaThongTinDuongPho()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var duongPhoDbModel = new DuongPhoModel();
            Console.WriteLine("Nhập mã đường phố cần xoá.");
            var maDuongPho = int.Parse(Console.ReadLine());
            DuongPho duongPho = duongPhoDbModel.findById(maDuongPho);
            if (duongPho == null)
            {
                Console.WriteLine("Không tìm thấy đường phố.");
                return;
            }
            Console.WriteLine($"Tìm thấy đường phố có mã là: {duongPho.Ma}, tên: {duongPho.Ten}, diễn tả: {duongPho.DienTa}, ngày bắt đầu sử dụng: {duongPho.NgayBatDauSuDung}, lịch sử tên đường: {duongPho.LichSuTenDuong}, tên quận: {duongPho.TenQuan}, trạng thái: {duongPho.TrangThai}");
            Console.WriteLine("Bạn có chắc muốn xoá tên đường này không. Cho nghĩ lại lần nữa: (yes/no)?");
            string choice = Console.ReadLine();
            if (choice.ToLower().Equals("yes")) 
            { 
                bool result = duongPhoDbModel.delete(maDuongPho); 
                if (result) 
                { 
                    Console.WriteLine("Xoá thành công");
                }
                else 
                { 
                    Console.WriteLine("Xoá thất bại. Vui lòng liên hệ admin.");
                }
            }
        }
    }
}