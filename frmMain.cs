using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUID
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 默认生成个数
        /// </summary>
        private const int CONST_DEFAULT_COUNT = 40;

        /// <summary>
        /// 生成GUID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenGUID_Click(object sender, EventArgs e)
        {
            int genCount = default(int);//生成个数
            if (!int.TryParse(cmbCount.Text, out genCount))
            {
                cmbCount.Text = CONST_DEFAULT_COUNT.ToString();
                genCount = CONST_DEFAULT_COUNT;
            }

            StringBuilder guidCache = new StringBuilder();
            for (int i = 1; i <= genCount; i++)
            {
                string strGUID = string.Empty;
                if (rdoNoFormat.Checked)
                {
                    guidCache.Append(Guid.NewGuid());
                }
                else if (rdoRef.Checked)//生成带双引号
                {
                    guidCache.AppendFormat(@"""{0}""", Guid.NewGuid());
                }
                else if (rdoHand.Checked)//生成带花括号
                {
                    guidCache.AppendFormat(@"{{{0}}}", Guid.NewGuid());
                }

                guidCache.AppendLine();
            }

            txtBoxGUID.Clear();
            txtBoxGUID.Text = guidCache.ToString();
        }

        /// <summary>
        /// 文本变更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxGUID_TextChanged(object sender, EventArgs e)
        {
            btnCopy.Enabled = !string.IsNullOrEmpty(txtBoxGUID.Text);
        }

        /// <summary>
        /// 复制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtBoxGUID.Text);
        }
    }
}
