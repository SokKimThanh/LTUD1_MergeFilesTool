
namespace MergeFilesTool
{
    public partial class FromMergeStringFile : Form
    {
        MergeFiles mergeFiles;
        public FromMergeStringFile()
        {
            InitializeComponent();
            mergeFiles = new MergeFiles();
        }

        private void btnShowStringMerge_Click(object sender, EventArgs e)
        {
            try
            {
                string path = txtPath.Text;
                string newFileName = txtNewFileName.Text;

                if (path == null || path == string.Empty)
                {
                    MessageBox.Show("Chưa có đường dẫn thư mục");
                    return;
                }
                if (newFileName == null || newFileName == string.Empty)
                {
                    MessageBox.Show("Chưa có tên file");
                    return;
                }
                if (mergeFiles.IsValidPathAndFileName(path, newFileName) == false)
                {
                    MessageBox.Show("Tên file hoặc đường dẫn chưa hợp lệ");
                    return;
                }
                //tao thong tin moi mergefile
                mergeFiles.FolderPath = path;
                mergeFiles.NewFileName = newFileName;
                if (mergeFiles.MergeSQLFiles())
                {
                    MessageBox.Show("Success! Please copy power shell comand then execute on CMD", "Copy Powershell Command");
                    rtbPowerShellCommand.Text = MergeFiles.lenhMerge;
                    btnResult.Visible = true;

                    btnResult.Text = "Show Result";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        // Khai báo biến flag ở ngoài hàm
        bool flag = true;

        private void btnResult_Click(object sender, EventArgs e)
        {
            // Đảo ngược giá trị của flag
            flag = !flag;

            // Gán giá trị của flag cho thuộc tính Visible của pbResult
            pbResult.Visible = flag;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Tạo một hộp thoại thông báo với nội dung, tiêu đề, các nút lựa chọn và biểu tượng
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra kết quả của việc người dùng nhấn vào các nút lựa chọn
            if (dg == DialogResult.Yes)
            {
                // Nếu người dùng nhấn nút Yes, thoát khỏi ứng dụng
                Application.Exit();
            }
            // Ngược lại, nếu người dùng nhấn nút No, không làm gì cả
        }

    }
}
