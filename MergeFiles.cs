using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MergeFiles
{
    string folderPath;
    string newFileName;
    public static string lenhMerge;
    public MergeFiles() { }
    public MergeFiles(string folderPath, string newFileName)
    {

        this.folderPath = folderPath;
        this.newFileName = newFileName;
    }

    public string FolderPath { get => folderPath; set => folderPath = value; }
    public string NewFileName { get => newFileName; set => newFileName = value; }

    // Hàm merge tất cả nội dung file sql trong thư mục vào một file mới cùng thư mục
    // Thay đổi kiểu trả về từ void sang bool
    public bool MergeSQLFiles()
    {

        // Tạo một biến bool để lưu trạng thái của hàm
        bool result = true;

        // Tạo một đối tượng DirectoryInfo để lấy thông tin về thư mục
        DirectoryInfo dir = new DirectoryInfo(this.folderPath);

        // Tạo một đối tượng StreamWriter để tạo và ghi nội dung vào file mới
        using (StreamWriter sw = new StreamWriter(Path.Combine(this.folderPath, this.newFileName)))
        {

            //cmd /c 'copy /b file1.sql + file2.sql file3.sql'
            lenhMerge = "cmd /c 'copy /b  ";
            // Tạo một biến đếm để theo dõi số lượng file sql trong thư mục
            int count = dir.GetFiles("*.sql").Length;

            // Tạo một biến cờ để xác định khi nào là lần lặp cuối cùng
            bool last = false;

            // Duyệt qua danh sách các file sql trong thư mục
            foreach (FileInfo file in dir.GetFiles("*.sql"))
            {
                if (dir.GetFiles("*.sql").Length == 0)
                {
                    throw new Exception("không có file nào là sql");
                }
                // Kiểm tra xem tên file có trùng với newFileName hay không
                if (file.Name != newFileName)
                {
                    // Giảm biến đếm đi một
                    count--;

                    // Kiểm tra xem có phải là lần lặp cuối cùng không
                    if (count == 1)
                    {
                        // Nếu có, gán biến cờ là true
                        last = true;
                    }

                    // Nếu không, thêm tên file vào lệnh merge
                    lenhMerge += file.Name + "+";

                    // Nếu là lần lặp cuối cùng, thêm newfile.sql vào lệnh merge
                    if (last)
                    {
                        lenhMerge += " ";
                    }
                }
            }
            int index = lenhMerge.LastIndexOf('+'); // Tìm vị trí của dấu cộng cuối cùng
            lenhMerge = lenhMerge.Remove(index, 1); // Loại bỏ dấu cộng cuối cùng
                                                    // Thêm newfile.sql vào lệnh merge
            lenhMerge += "newfile.sql'";

            Console.WriteLine(lenhMerge);

        }
        // Trả về giá trị của biến result
        return result;
    }
    public bool IsValidPathAndFileName(string folderPath, string newFileName)
    {
        try
        {
            // Lấy đường dẫn tuyệt đối của folderPath
            string fullPath = Path.GetFullPath(folderPath);

            // Lấy phần mở rộng của newFileName
            string extension = Path.GetExtension(newFileName);

            // Lấy mảng các ký tự không hợp lệ cho đường dẫn và tên file
            char[] invalidPathChars = Path.GetInvalidPathChars();
            char[] invalidFileNameChars = Path.GetInvalidFileNameChars();

            // Kiểm tra xem đường dẫn và tên file có chứa ký tự không hợp lệ hay không
            if (folderPath.IndexOfAny(invalidPathChars) >= 0 || newFileName.IndexOfAny(invalidFileNameChars) >= 0)
            {
                // Nếu có, trả về false
                return false;
            }

            // Kiểm tra xem phần mở rộng của tên file có phải là .sql hay không
            if (extension != ".sql")
            {
                // Nếu không, trả về false
                return false;
            }

            // Nếu tất cả các điều kiện trên đều thỏa mãn, trả về true
            return true;
        }
        catch (Exception ex)
        {
            // Nếu có ngoại lệ, trả về false và hiển thị thông báo lỗi
            Console.WriteLine("Lỗi: " + ex.Message);
            return false;
        }
    }

}

