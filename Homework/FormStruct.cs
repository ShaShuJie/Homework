using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Homework.Utility;

namespace Homework
{
    public partial class FormStruct : Form
    {
        public FormStruct()
        {
            InitializeComponent();
        }

        private List<Score> scoreList = new List<Score>();

        private void btnSave_Click(object sender, EventArgs e)
        {
            double CHScore, ENScore, MEScore;

            if (double.TryParse(textCH.Text, out CHScore) && CHScore >= 0 &&
                double.TryParse(textEN.Text, out ENScore) && ENScore >= 0 &&
                double.TryParse(textME.Text, out MEScore) && MEScore >= 0)
            {
                Score score = new Score
                {
                    Name = textName.Text,
                    CHScore = CHScore,
                    ENScore = ENScore,
                    MEScore = MEScore
                };

                scoreList.Add(score);
            }
            else
            {
                MessageBox.Show("請輸入數字");
            }
        }

        private void UpdateScoreShow()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Score score in scoreList)
            {
                sb.AppendLine($"姓名: {score.Name}");
                sb.AppendLine($"國文: {score.CHScore}");
                sb.AppendLine($"英文: {score.ENScore}");
                sb.AppendLine($"數學: {score.MEScore}");
                sb.AppendLine();
            }
            labShow.Text = sb.ToString();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            UpdateScoreShow();
        }

        private void btnHLScore_Click(object sender, EventArgs e)
        {
            if (scoreList.Count > 0)
            {
                double maxScore = scoreList.Max(s => s.CHScore);
                string maxSubject = "國文";

                if (scoreList.Max(s => s.ENScore) > maxScore)
                {
                    maxScore = scoreList.Max(s => s.ENScore);
                    maxSubject = "英文";
                }

                if (scoreList.Max(s => s.MEScore) > maxScore)
                {
                    maxScore = scoreList.Max(s => s.MEScore);
                    maxSubject = "數學";
                }

                double minScore = scoreList.Min(s => s.CHScore);
                string minSubject = "國文";

                if (scoreList.Min(s => s.ENScore) < minScore)
                {
                    minScore = scoreList.Min(s => s.ENScore);
                    minSubject = "英文";
                }

                if (scoreList.Min(s => s.MEScore) < minScore)
                {
                    minScore = scoreList.Min(s => s.MEScore);
                    minSubject = "數學";
                }

                MessageBox.Show($"最高分科目: {maxSubject}，分數: {maxScore}\n最低分科目: {minSubject}，分數: {minScore}");
            }
            else
            {
                MessageBox.Show("尚未儲存任何成績");
            }
        }
    }
}
