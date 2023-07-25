using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace subject_system
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int iTtlCnt = 0, iCkCnt = 0;//iTtlCn：課程總數量；iCkCnt：勾選種數量

        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] sElt = {"微積分","線性代數", "計算機概論", "程式設計", "離散數學", "基本電學", "資料結構",
                            "邏輯設計","資料庫管理","互動設計入門","網路通訊概論","組合語言與系統程式","演算法概論",
                            "作業系統","計算機圖學","人工智慧","網路程式設計","網頁軟體開發","雲端技術與應用",
                            "行動計算概論","區域網路概論","行動應用軟體開發","編譯程式"};

            /*for (int i = 0; i < sElt.Length; i++) 
            { cklstbx.Items.Add(sElt[i]); }*/

            cklstbx.Items.AddRange(sElt);
            vSeletctState();

        }

        private void cklstbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            vSeletctState();
        }

        private void but_Add_Click(object sender, EventArgs e)
        {
            lstbx.Items.Clear();
            for (int i = 0; i < iCkCnt; i++) 
            { lstbx.Items.Add(cklstbx.CheckedItems[i]); }
        }

        private void vSeletctState() 
        {
            iTtlCnt = cklstbx.Items.Count;
            iCkCnt = cklstbx.CheckedItems.Count;
            lab_Cnt.Text = iCkCnt + " / " + iTtlCnt;
        }
    }
}
