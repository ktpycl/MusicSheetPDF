using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace MusicSheetPDF
{

    public partial class MainForm : Form
    {
        public string[] Parts = { "", "1st", "2nd", "3rd", "4th", "5th", "solo" };

        private Dictionary<String, ClassInstrument> instrumentDic = new Dictionary<string, ClassInstrument>();
        bool searchFlg;
        String firstStr;
        String secondStr;

        public void initInstrumentDic()
        {
            ClassInstrument clsInst = new ClassInstrument();
            clsInst.ShortName = "TP";
            clsInst.FullName = "Trumpet";
            clsInst.SheetWriteFlg = true;
            clsInst.Order = 1;

            instrumentDic.Add(clsInst.ShortName, clsInst);

            clsInst = new ClassInstrument();
            clsInst.ShortName = "TB";
            clsInst.FullName = "Trombone";
            clsInst.SheetWriteFlg = true;
            clsInst.Order = 2;

            instrumentDic.Add(clsInst.ShortName, clsInst);

            searchFlg = false;
            firstStr = "";
            secondStr = "";

        }

        public MainForm()
        {
            InitializeComponent();

            initInstrumentDic();
        }

        //---------------------
        //----- txtFolder -----
        //---------------------
        private void txtFolder_DragDrop(object sender, DragEventArgs e)
        {
            //コントロール内にドロップされたとき実行される
            //ドロップされたすべてのファイル名を取得する
            string[] foderName =
                (string[])e.Data.GetData(DataFormats.FileDrop, false);
            //フォルダパス取得
            txtFolder.Text = foderName[0];

            // フォルダ配下のPDFファイル名をGridへ設定
            foreach (string pdfFileName in Directory.GetFiles(txtFolder.Text, "*.pdf"))
            {
                //DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
                //column.Items.AddRange(Parts);

                dgvMusicSheet.Rows.Add(false, Path.GetFileName(pdfFileName), "", "");
            }
        }

        private void txtFolder_DragEnter(object sender, DragEventArgs e)
        {
            //コントロール内にドラッグされたとき実行される
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                //ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                //ファイル以外は受け付けない
                e.Effect = DragDropEffects.None;
            }
        }

        //-------------------------
        //----- dgvMusicSheet -----
        //-------------------------
        private void dgvMusicSheet_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //表示されているコントロールがDataGridViewTextBoxEditingControlか調べる
            if (e.Control is DataGridViewTextBoxEditingControl)
            {
                DataGridView dgv = (DataGridView)sender;

                //編集のために表示されているコントロールを取得
                DataGridViewTextBoxEditingControl tb =
                    (DataGridViewTextBoxEditingControl)e.Control;

                //イベントハンドラを削除
                tb.KeyUp -=
                    new KeyEventHandler(dataGridViewTextBox_KeyUp);

                //該当する列か調べる
                if (dgv.CurrentCell.OwningColumn.Name == "col_Instrument")
                {
                    //KeyUpイベントハンドラを追加
                    tb.KeyUp +=
                        new KeyEventHandler(dataGridViewTextBox_KeyUp);
                }
            }
        }

        //DataGridViewに表示されているテキストボックスのKeyUpイベントハンドラ
        private void dataGridViewTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            Console.WriteLine((char)e.KeyCode);
            if (e.Control == true)
            {
                if (!searchFlg)
                {
                    firstStr = ((char)e.KeyCode).ToString();
                }
                else
                {
                    secondStr = ((char)e.KeyCode).ToString();

                    ClassInstrument clsInst = instrumentDic[firstStr + secondStr];
                    if (clsInst != null)
                    {
                        ((TextBox)sender).Text = clsInst.FullName;
                        int activeColIndex = dgvMusicSheet.SelectedCells[0].ColumnIndex;
                        int activeRowIndex = dgvMusicSheet.SelectedCells[0].RowIndex;

                        if (activeColIndex == 2)
                        {
                            activeColIndex = 3;
                        } else if (activeColIndex == 3)
                        {
                            activeColIndex = 1;
                            if (dgvMusicSheet.RowCount > activeRowIndex)
                            {
                                activeRowIndex++;
                            }

                        }
                        dgvMusicSheet[activeColIndex, activeRowIndex].Selected = true;
                    }
                }

                if (searchFlg)
                {
                    searchFlg = false;
                }
                else
                {
                    searchFlg = true;
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                searchFlg = false;
            }
        }

        private void dgvMusicSheet_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //表示されているコントロールがDataGridViewTextBoxEditingControlか調べる
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3)
            {
                dgvMusicSheet.BeginEdit(true);
            }
        }
    }
}
