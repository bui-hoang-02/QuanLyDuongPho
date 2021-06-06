using System;
using System.Collections.Generic;
using System.Text;
using AssignmentQuanLyDuongPho.Entity;
using AssignmentQuanLyDuongPho.Helper;
using MySql.Data.MySqlClient;

namespace AssignmentQuanLyDuongPho.Model
{
    public class DuongPhoModel
    {
        private List<DuongPho> _listDuongPho = new List<DuongPho>();
        
        public bool save(DuongPho duongPho)
        {
            var connection = ConnectionHelper.GetConnection();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = $"insert into duongphos (Ma, Ten, DienTa, NgayBatDauSuDung, LichSuTenDuong, TenQuan, TrangThai) values " +
                                       $"({duongPho.Ma}, '{duongPho.Ten}', '{duongPho.DienTa}', '{duongPho.NgayBatDauSuDung}', '{duongPho.LichSuTenDuong}', '{duongPho.TenQuan}', {duongPho.TrangThai})";
            int result = mySqlCommand.ExecuteNonQuery();
            if (result == 1)
            {
                return true;
            }
            return false;
        }

        public List<DuongPho> FindAll()
        {
            List<DuongPho> _listDuongPho = new List<DuongPho>();
            var connection = ConnectionHelper.GetConnection();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = $"select * from duongphos";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read())
            {
                int maDuongPho = mySqlDataReader.GetInt32("Ma");
                string tenDuongPho = mySqlDataReader.GetString("Ten");
                string dienTaDuongPho = mySqlDataReader.GetString("DienTa");
                string ngaySuDungDuongPho = mySqlDataReader.GetString("NgayBatDauSuDung");
                string lichSuTenDongPho = mySqlDataReader.GetString("LichSuTenDuong");
                string tenQuanDuongPho = mySqlDataReader.GetString("TenQuan");
                int trangThaiDuongPho = mySqlDataReader.GetInt32("TrangThai");
                DuongPho duongPho = new DuongPho();
                duongPho.Ma = maDuongPho;
                duongPho.Ten = tenDuongPho;
                duongPho.DienTa = dienTaDuongPho;
                duongPho.NgayBatDauSuDung = ngaySuDungDuongPho;
                duongPho.LichSuTenDuong = lichSuTenDongPho;
                duongPho.TenQuan = tenQuanDuongPho;
                duongPho.TrangThai = trangThaiDuongPho;
                _listDuongPho.Add(duongPho);
            }
            connection.Close();
            return _listDuongPho;
        }
        
        public DuongPho findById(int maDuongPho)
        {
            DuongPho duongPho = null;
            var connection = ConnectionHelper.GetConnection();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = $"select *from duongphos where Ma = {maDuongPho}";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            if (mySqlDataReader.Read())
            {
                int maDuongPho1 = mySqlDataReader.GetInt32("Ma");
                string tenDuongPho1 = mySqlDataReader.GetString("Ten");
                string dienTaDuongPho1 = mySqlDataReader.GetString("DienTa");
                string ngaySuDungDuongPho1 = mySqlDataReader.GetString("NgayBatDauSuDung");
                string lichSuTenDongPho1 = mySqlDataReader.GetString("LichSuTenDuong");
                string tenQuanDuongPho1 = mySqlDataReader.GetString("TenQuan");
                int trangThaiDuongPho1 = mySqlDataReader.GetInt32("TrangThai");
                duongPho = new DuongPho();
                duongPho.Ma = maDuongPho1;
                duongPho.Ten = tenDuongPho1;
                duongPho.DienTa = dienTaDuongPho1;
                duongPho.NgayBatDauSuDung = ngaySuDungDuongPho1;
                duongPho.LichSuTenDuong = lichSuTenDongPho1;
                duongPho.TenQuan = tenQuanDuongPho1;
                duongPho.TrangThai = trangThaiDuongPho1;
            }
            connection.Close();
            return duongPho;
        }

        public bool update(int maDuongPho, DuongPho updateDuongPho)
        {
            DuongPho duongPho = findById(maDuongPho);
            if (duongPho == null)
            {
                return false;
            }
            duongPho.Ten = updateDuongPho.Ten;
            duongPho.DienTa = updateDuongPho.DienTa;
            duongPho.NgayBatDauSuDung = updateDuongPho.NgayBatDauSuDung;
            duongPho.LichSuTenDuong = updateDuongPho.LichSuTenDuong;
            duongPho.TenQuan = updateDuongPho.TenQuan;
            duongPho.TrangThai = updateDuongPho.TrangThai;
            var connection = ConnectionHelper.GetConnection();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = $"update duongphos set ten = '{duongPho.Ten}', DienTa = '{duongPho.DienTa}', NgayBatDauSuDung = '{duongPho.NgayBatDauSuDung}', LichSuTenDuong = '{duongPho.LichSuTenDuong}', TenQuan = '{duongPho.TenQuan}', TrangThai = {duongPho.TrangThai} where Ma = {maDuongPho}";
            int result = mySqlCommand.ExecuteNonQuery();
            if (result == 1)
            {
                return true;
            }
            return false;
        }

        public bool delete(int maDuongPho)
        {
            var connection = ConnectionHelper.GetConnection();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = $"delete from duongphos where Ma = {maDuongPho}";
            int result = mySqlCommand.ExecuteNonQuery();
            if (result == 1)
            {
                return false;
            }
            return true;
        }
    }
}