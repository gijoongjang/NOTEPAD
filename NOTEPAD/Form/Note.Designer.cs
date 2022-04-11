
namespace NOTEPAD
{
    partial class Note
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.make = new System.Windows.Forms.ToolStripMenuItem();
            this.open = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pageSet = new System.Windows.Forms.ToolStripMenuItem();
            this.print = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cut = new System.Windows.Forms.ToolStripMenuItem();
            this.copy = new System.Windows.Forms.ToolStripMenuItem();
            this.paste = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.find = new System.Windows.Forms.ToolStripMenuItem();
            this.nextFind = new System.Windows.Forms.ToolStripMenuItem();
            this.바꾸기RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이동GToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.모두선택AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.시간날짜DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(629, 413);
            this.textBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(629, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.make,
            this.open,
            this.save,
            this.saveAs,
            this.toolStripSeparator1,
            this.pageSet,
            this.print,
            this.toolStripSeparator2,
            this.exit});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일ToolStripMenuItem.Text = "파일(F)";
            // 
            // make
            // 
            this.make.Name = "make";
            this.make.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.make.Size = new System.Drawing.Size(194, 22);
            this.make.Text = "새로만들기(N)";
            // 
            // open
            // 
            this.open.Name = "open";
            this.open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.open.Size = new System.Drawing.Size(194, 22);
            this.open.Text = "열기(O)";
            // 
            // save
            // 
            this.save.Name = "save";
            this.save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.save.Size = new System.Drawing.Size(194, 22);
            this.save.Text = "저장(S)";
            // 
            // saveAs
            // 
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(194, 22);
            this.saveAs.Text = "다른 이름으로 저장(A)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // pageSet
            // 
            this.pageSet.Name = "pageSet";
            this.pageSet.Size = new System.Drawing.Size(194, 22);
            this.pageSet.Text = "페이지 설정(U)";
            // 
            // print
            // 
            this.print.Name = "print";
            this.print.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.print.Size = new System.Drawing.Size(194, 22);
            this.print.Text = "인쇄(P)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(191, 6);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(194, 22);
            this.exit.Text = "끝내기(X)";
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undo,
            this.toolStripSeparator3,
            this.cut,
            this.copy,
            this.paste,
            this.delete,
            this.toolStripSeparator4,
            this.find,
            this.nextFind,
            this.바꾸기RToolStripMenuItem,
            this.이동GToolStripMenuItem,
            this.모두선택AToolStripMenuItem,
            this.시간날짜DToolStripMenuItem});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.편집ToolStripMenuItem.Text = "편집(E)";
            // 
            // undo
            // 
            this.undo.Name = "undo";
            this.undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undo.Size = new System.Drawing.Size(184, 22);
            this.undo.Text = "실행 취소(U)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(181, 6);
            // 
            // cut
            // 
            this.cut.Name = "cut";
            this.cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cut.Size = new System.Drawing.Size(184, 22);
            this.cut.Text = "잘라내기(T)";
            // 
            // copy
            // 
            this.copy.Name = "copy";
            this.copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copy.Size = new System.Drawing.Size(184, 22);
            this.copy.Text = "복사(C)";
            // 
            // paste
            // 
            this.paste.Name = "paste";
            this.paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.paste.Size = new System.Drawing.Size(184, 22);
            this.paste.Text = "붙여넣기(P)";
            // 
            // delete
            // 
            this.delete.Name = "delete";
            this.delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.delete.Size = new System.Drawing.Size(184, 22);
            this.delete.Text = "삭제(L)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(181, 6);
            // 
            // find
            // 
            this.find.Name = "find";
            this.find.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.find.Size = new System.Drawing.Size(184, 22);
            this.find.Text = "찾기(F)";
            // 
            // nextFind
            // 
            this.nextFind.Name = "nextFind";
            this.nextFind.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.nextFind.Size = new System.Drawing.Size(184, 22);
            this.nextFind.Text = "다음 찾기(N)";
            // 
            // 바꾸기RToolStripMenuItem
            // 
            this.바꾸기RToolStripMenuItem.Name = "바꾸기RToolStripMenuItem";
            this.바꾸기RToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.바꾸기RToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.바꾸기RToolStripMenuItem.Text = "바꾸기(R)";
            // 
            // 이동GToolStripMenuItem
            // 
            this.이동GToolStripMenuItem.Name = "이동GToolStripMenuItem";
            this.이동GToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.이동GToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.이동GToolStripMenuItem.Text = "이동(G)";
            // 
            // 모두선택AToolStripMenuItem
            // 
            this.모두선택AToolStripMenuItem.Name = "모두선택AToolStripMenuItem";
            this.모두선택AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.모두선택AToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.모두선택AToolStripMenuItem.Text = "모두 선택(A)";
            // 
            // 시간날짜DToolStripMenuItem
            // 
            this.시간날짜DToolStripMenuItem.Name = "시간날짜DToolStripMenuItem";
            this.시간날짜DToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.시간날짜DToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.시간날짜DToolStripMenuItem.Text = "시간/날짜(D)";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 437);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Note";
            this.Text = "제목 없음";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem make;
        private System.Windows.Forms.ToolStripMenuItem open;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem saveAs;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem pageSet;
        private System.Windows.Forms.ToolStripMenuItem print;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cut;
        private System.Windows.Forms.ToolStripMenuItem copy;
        private System.Windows.Forms.ToolStripMenuItem paste;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem find;
        private System.Windows.Forms.ToolStripMenuItem nextFind;
        private System.Windows.Forms.ToolStripMenuItem 바꾸기RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이동GToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모두선택AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 시간날짜DToolStripMenuItem;
        public System.Windows.Forms.TextBox textBox1;
    }
}

