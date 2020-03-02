using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TweetManager;
namespace Twitter_From
{
    public partial class Twitter : Form
    {
        tweetManagerFile tm = new tweetManagerFile();
        public Twitter()
        {
            InitializeComponent();
        }

        private void Twitter_Load(object sender, EventArgs e)
        {
            refreshTweets();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPost_Click(object sender, EventArgs e)
        {
           string msg =  tm.PostTweet(txtTweet.Text);
            lblStatus.Text = msg;
            refreshTweets();
        }

        void refreshTweets()
        {
            lstTweets.Items.Clear();
            string [] tweets = tm.GetTweets();
            int tweetsCount = tm.TweetCounter();
            for (int i = 0; i < tweetsCount; i++)
                lstTweets.Items.Add(tweets[i]);
        }

    }
}
