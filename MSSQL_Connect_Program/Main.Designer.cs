namespace MSSQL_Connect_Program
{
    partial class Main
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
            this.uiLb_Connect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uiLb_Connect
            // 
            this.uiLb_Connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLb_Connect.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLb_Connect.Location = new System.Drawing.Point(0, 0);
            this.uiLb_Connect.Name = "uiLb_Connect";
            this.uiLb_Connect.Size = new System.Drawing.Size(284, 261);
            this.uiLb_Connect.TabIndex = 0;
            this.uiLb_Connect.Text = "Connect";
            this.uiLb_Connect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uiLb_Connect);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label uiLb_Connect;
    }
}

