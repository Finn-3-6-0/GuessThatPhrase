
namespace GuessThatWord
{
    partial class AdminPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.userDropDown = new System.Windows.Forms.ComboBox();
            this.oldUsernamelbl = new System.Windows.Forms.Label();
            this.oldPasswordlbl = new System.Windows.Forms.Label();
            this.oldEmaillbl = new System.Windows.Forms.Label();
            this.oldAvatarlbl = new System.Windows.Forms.Label();
            this.oldScorelbl = new System.Windows.Forms.Label();
            this.newScoretb = new System.Windows.Forms.TextBox();
            this.newEmailtb = new System.Windows.Forms.TextBox();
            this.newPasswordtb = new System.Windows.Forms.TextBox();
            this.newUserLbl = new System.Windows.Forms.Label();
            this.passwordSubmit = new System.Windows.Forms.Label();
            this.emailSubmit = new System.Windows.Forms.Label();
            this.avatarSubmit = new System.Windows.Forms.Label();
            this.highScoreSubmit = new System.Windows.Forms.Label();
            this.avatarCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adminExitlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userDropDown
            // 
            this.userDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDropDown.FormattingEnabled = true;
            this.userDropDown.Location = new System.Drawing.Point(356, 316);
            this.userDropDown.Name = "userDropDown";
            this.userDropDown.Size = new System.Drawing.Size(287, 45);
            this.userDropDown.TabIndex = 0;
            this.userDropDown.SelectedIndexChanged += new System.EventHandler(this.userDropDown_SelectedIndexChanged);
            this.userDropDown.TextUpdate += new System.EventHandler(this.userDropDown_TextUpdate);
            // 
            // oldUsernamelbl
            // 
            this.oldUsernamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldUsernamelbl.Location = new System.Drawing.Point(101, 381);
            this.oldUsernamelbl.Name = "oldUsernamelbl";
            this.oldUsernamelbl.Size = new System.Drawing.Size(250, 40);
            this.oldUsernamelbl.TabIndex = 1;
            // 
            // oldPasswordlbl
            // 
            this.oldPasswordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPasswordlbl.Location = new System.Drawing.Point(101, 453);
            this.oldPasswordlbl.Name = "oldPasswordlbl";
            this.oldPasswordlbl.Size = new System.Drawing.Size(250, 40);
            this.oldPasswordlbl.TabIndex = 2;
            // 
            // oldEmaillbl
            // 
            this.oldEmaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldEmaillbl.Location = new System.Drawing.Point(101, 526);
            this.oldEmaillbl.Name = "oldEmaillbl";
            this.oldEmaillbl.Size = new System.Drawing.Size(250, 40);
            this.oldEmaillbl.TabIndex = 3;
            // 
            // oldAvatarlbl
            // 
            this.oldAvatarlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldAvatarlbl.Location = new System.Drawing.Point(101, 599);
            this.oldAvatarlbl.Name = "oldAvatarlbl";
            this.oldAvatarlbl.Size = new System.Drawing.Size(250, 40);
            this.oldAvatarlbl.TabIndex = 4;
            // 
            // oldScorelbl
            // 
            this.oldScorelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldScorelbl.Location = new System.Drawing.Point(101, 675);
            this.oldScorelbl.Name = "oldScorelbl";
            this.oldScorelbl.Size = new System.Drawing.Size(250, 40);
            this.oldScorelbl.TabIndex = 5;
            // 
            // newScoretb
            // 
            this.newScoretb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newScoretb.Location = new System.Drawing.Point(650, 675);
            this.newScoretb.Name = "newScoretb";
            this.newScoretb.Size = new System.Drawing.Size(247, 38);
            this.newScoretb.TabIndex = 7;
            // 
            // newEmailtb
            // 
            this.newEmailtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEmailtb.Location = new System.Drawing.Point(650, 526);
            this.newEmailtb.Name = "newEmailtb";
            this.newEmailtb.Size = new System.Drawing.Size(247, 38);
            this.newEmailtb.TabIndex = 9;
            // 
            // newPasswordtb
            // 
            this.newPasswordtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordtb.Location = new System.Drawing.Point(650, 453);
            this.newPasswordtb.Name = "newPasswordtb";
            this.newPasswordtb.Size = new System.Drawing.Size(247, 38);
            this.newPasswordtb.TabIndex = 10;
            // 
            // newUserLbl
            // 
            this.newUserLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserLbl.Location = new System.Drawing.Point(647, 379);
            this.newUserLbl.Name = "newUserLbl";
            this.newUserLbl.Size = new System.Drawing.Size(250, 40);
            this.newUserLbl.TabIndex = 11;
            this.newUserLbl.Text = "Cannot update username";
            this.newUserLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordSubmit
            // 
            this.passwordSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.passwordSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordSubmit.Location = new System.Drawing.Point(917, 451);
            this.passwordSubmit.Name = "passwordSubmit";
            this.passwordSubmit.Size = new System.Drawing.Size(57, 40);
            this.passwordSubmit.TabIndex = 12;
            this.passwordSubmit.Text = ">";
            this.passwordSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passwordSubmit.Click += new System.EventHandler(this.passwordSubmit_Click);
            // 
            // emailSubmit
            // 
            this.emailSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.emailSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailSubmit.Location = new System.Drawing.Point(917, 528);
            this.emailSubmit.Name = "emailSubmit";
            this.emailSubmit.Size = new System.Drawing.Size(57, 40);
            this.emailSubmit.TabIndex = 13;
            this.emailSubmit.Text = ">";
            this.emailSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.emailSubmit.Click += new System.EventHandler(this.emailSubmit_Click);
            // 
            // avatarSubmit
            // 
            this.avatarSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.avatarSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avatarSubmit.Location = new System.Drawing.Point(917, 601);
            this.avatarSubmit.Name = "avatarSubmit";
            this.avatarSubmit.Size = new System.Drawing.Size(57, 40);
            this.avatarSubmit.TabIndex = 14;
            this.avatarSubmit.Text = ">";
            this.avatarSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.avatarSubmit.Click += new System.EventHandler(this.avatarSubmit_Click);
            // 
            // highScoreSubmit
            // 
            this.highScoreSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.highScoreSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreSubmit.Location = new System.Drawing.Point(917, 673);
            this.highScoreSubmit.Name = "highScoreSubmit";
            this.highScoreSubmit.Size = new System.Drawing.Size(57, 40);
            this.highScoreSubmit.TabIndex = 15;
            this.highScoreSubmit.Text = ">";
            this.highScoreSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.highScoreSubmit.Click += new System.EventHandler(this.highScoreSubmit_Click);
            // 
            // avatarCB
            // 
            this.avatarCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avatarCB.FormattingEnabled = true;
            this.avatarCB.Items.AddRange(new object[] {
            "AvatarRegLBL1",
            "AvatarRegLBL2",
            "AvatarRegLBL3"});
            this.avatarCB.Location = new System.Drawing.Point(644, 593);
            this.avatarCB.Name = "avatarCB";
            this.avatarCB.Size = new System.Drawing.Size(260, 45);
            this.avatarCB.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 736);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 40);
            this.label1.TabIndex = 17;
            this.label1.Text = "Delete";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // adminExitlbl
            // 
            this.adminExitlbl.AutoSize = true;
            this.adminExitlbl.BackColor = System.Drawing.Color.Transparent;
            this.adminExitlbl.Location = new System.Drawing.Point(1, 2);
            this.adminExitlbl.MinimumSize = new System.Drawing.Size(100, 100);
            this.adminExitlbl.Name = "adminExitlbl";
            this.adminExitlbl.Size = new System.Drawing.Size(100, 100);
            this.adminExitlbl.TabIndex = 69;
            this.adminExitlbl.Click += new System.EventHandler(this.adminExitlbl_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.adminExitlbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.avatarCB);
            this.Controls.Add(this.highScoreSubmit);
            this.Controls.Add(this.avatarSubmit);
            this.Controls.Add(this.emailSubmit);
            this.Controls.Add(this.passwordSubmit);
            this.Controls.Add(this.newUserLbl);
            this.Controls.Add(this.newPasswordtb);
            this.Controls.Add(this.newEmailtb);
            this.Controls.Add(this.newScoretb);
            this.Controls.Add(this.oldScorelbl);
            this.Controls.Add(this.oldAvatarlbl);
            this.Controls.Add(this.oldEmaillbl);
            this.Controls.Add(this.oldPasswordlbl);
            this.Controls.Add(this.oldUsernamelbl);
            this.Controls.Add(this.userDropDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox userDropDown;
        private System.Windows.Forms.Label oldUsernamelbl;
        private System.Windows.Forms.Label oldPasswordlbl;
        private System.Windows.Forms.Label oldEmaillbl;
        private System.Windows.Forms.Label oldAvatarlbl;
        private System.Windows.Forms.Label oldScorelbl;
        private System.Windows.Forms.TextBox newScoretb;
        private System.Windows.Forms.TextBox newEmailtb;
        private System.Windows.Forms.TextBox newPasswordtb;
        private System.Windows.Forms.Label newUserLbl;
        private System.Windows.Forms.Label passwordSubmit;
        private System.Windows.Forms.Label emailSubmit;
        private System.Windows.Forms.Label avatarSubmit;
        private System.Windows.Forms.Label highScoreSubmit;
        private System.Windows.Forms.ComboBox avatarCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label adminExitlbl;
    }
}