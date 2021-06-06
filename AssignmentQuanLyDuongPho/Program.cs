using System;
using System.Text;
using AssignmentQuanLyDuongPho.View;

namespace AssignmentQuanLyDuongPho
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            MenuDuongPho menuDuongPho = new MenuDuongPho();
            menuDuongPho.menuCRUDDuongPho();
        }
    }
}