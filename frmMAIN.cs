namespace JSdifficulty
{
    public partial class frmMAIN : Form
    {
        public frmMAIN()
        {
            InitializeComponent();
        }
        private void btnCLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbDandD_DragDrop(object sender, DragEventArgs e)
        {
            // ファイルがD&Dされたときにここに来る

            // 変換確認メッセージを表示する。
            DialogResult result = MessageBox.Show("変換を開始しますか？\n変換するソースの修正が事実畳出来なくなります。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // D&Dされたファイルのパスを取得する
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                // 変換処理を行う
                foreach (string file in files)
                {
                    // ☆ここで変換処理を実装する
                    ConvertJavaScriptFile(file);
                }
                MessageBox.Show("変換が完了しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // JavaScriuptファイルを変換する処理を実装する
        private int ConvertJavaScriptFile(string filePath)
        {
            string s=filePath;
            // やって欲しい事

            // (1)変換前にソースファイルのバックアップを作成する  

            // (2)変換前のソースファイルを読み込む

            // (3)難読化処理を実効
            // <script>～</script>に囲まれた部分を難読化する



            return 0;
        }
    }
}
