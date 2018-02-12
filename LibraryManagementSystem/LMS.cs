using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LMS : Form
    {
        public LMS()
        {
            InitializeComponent();
        }


        private void dataEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataEntry _add = new DataEntry();
            _add.MdiParent = this;
            _add.Show();
            AddMember _add = new AddMember();
            _add.MdiParent = this;
            _add.Show();
            SearchByAuthor _name = new SearchByAuthor();
            _name.MdiParent = this;
            _name.Show();
            SerchByTitle _title = new SerchByTitle();
            _title.MdiParent = this;
            _title.Show();
            SearchBySubject _sub = new SearchBySubject();
            _sub.MdiParent = this;
            _sub.Show();
            SearchByKeywords _key = new SearchByKeywords();
            _key.MdiParent = this;
            _key.Show();
            BooksIssueToday _key;
        }

        private void LMS_Load(object sender, EventArgs e)
        {

        }

    

    }
}