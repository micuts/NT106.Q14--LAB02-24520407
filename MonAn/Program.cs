using System;
using System.Data.SQLite;

namespace MonAn
{
    internal class DatabaseHelper
    {
        private const string DbFileName = "MonAn.db";
        private static string connectionString = $"Data Source={DbFileName};Version=3;";

        // Phương thức tạo file DB và các bảng
        public static void InitializeDatabase()
        {
            if (!System.IO.File.Exists(DbFileName))
            {
                // 1. Tạo file Database
                SQLiteConnection.CreateFile(DbFileName);
                Console.WriteLine($"Database file '{DbFileName}' created.");

                // 2. Tạo các bảng và chèn dữ liệu mẫu
                CreateTablesAndInsertData();
            }
            else
            {
                Console.WriteLine($"Database file '{DbFileName}' already exists. Skipping creation.");
            }
        }

        // Phương thức tạo các bảng và chèn dữ liệu
        private static void CreateTablesAndInsertData()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Tạo bảng NguoiDung (Người đóng góp)
                string createNguoiDungTable = @"
                    CREATE TABLE NguoiDung (
                        IDNCC INTEGER PRIMARY KEY,
                        HoVaTen TEXT NOT NULL,
                        QuyenHan TEXT
                    );";
                using (var command = new SQLiteCommand(createNguoiDungTable, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Tạo bảng MonAn
                string createMonAnTable = @"
                    CREATE TABLE MonAn (
                        IDMA INTEGER PRIMARY KEY,
                        TenMonAn TEXT NOT NULL,
                        HinhAnh TEXT, -- Lưu đường dẫn đến hình ảnh
                        IDNCC INTEGER,
                        FOREIGN KEY(IDNCC) REFERENCES NguoiDung(IDNCC)
                    );";
                using (var command = new SQLiteCommand(createMonAnTable, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Chèn dữ liệu mẫu vào NguoiDung
                string insertNguoiDung = @"
                    INSERT INTO NguoiDung (HoVaTen, QuyenHan) VALUES 
                    ('Nguyễn Văn A', 'Thành viên'),
                    ('Trần Thị B', 'Quản trị viên'),
                    ('Lê Hoàng C', 'Thành viên');";
                using (var command = new SQLiteCommand(insertNguoiDung, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Chèn dữ liệu mẫu vào MonAn
                // Giả sử HìnhAnh là tên file ảnh (ví dụ: 'pho.jpg') được đặt trong thư mục Project/Resources
                string insertMonAn = @"
                    INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES 
                    ('Phở Bò', 'pho.jpg', 1),
                    ('Bún Chả', 'buncha.jpg', 2),
                    ('Bánh Mì', 'banhmi.jpg', 1),
                    ('Cơm Tấm', 'comtam.jpg', 3);";
                using (var command = new SQLiteCommand(insertMonAn, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            Console.WriteLine("Tables created and sample data inserted.");
        }
    }
}