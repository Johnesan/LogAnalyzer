using LogAnalyzerLib.Models;
using LogAnalyzerLib.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LogAnalyzerUI
{
    public partial class Form1 : Form
    {
        public IEnumerable<LogFile> logFiles { get; set; }
        public IEnumerable<string> archives { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //file search with date button
        private void button2_Click(object sender, EventArgs e)
        {
            logFiles = new LogFileService().SearchFilesByTime(dateTimePicker1.Value, dateTimePicker2.Value,
                new List<string> { selectedDirectory.Text });
            listViewSourceChanged();
        }

        //select directory
        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog().Equals(DialogResult.OK))
                selectedDirectory.Text = folderBrowserDialog1.SelectedPath;

            logFiles = new LogFileService().GetLogFiles(new List<string> { selectedDirectory.Text });
            archives = new LogFileService().GetZipFiles(new List<string> { selectedDirectory.Text });
            listView1.Items.AddRange(logFiles.Select(x =>
            {
                var item = new ListViewItem(x.Name);
                item.Tag = x.FileLocation;
                return item;
            }).ToArray());

            listView2.Items.AddRange(archives.Select(x => new ListViewItem(x)).ToArray());
            listViewSourceChanged();
        }

        //file search with size button
        private void button3_Click(object sender, EventArgs e)
        {
            logFiles = new LogFileService().SearchFilesBySize(long.Parse(fromSizeSearch.Text),
                long.Parse(toSizeSearch.Text), new List<string> { selectedDirectory.Text });
            listViewSourceChanged();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        // list item double click
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var item = listView1.SelectedItems[0];
            contentLabel.Text = new LogFileService().GetLogFileString(item.Tag.ToString());
            var logItemService = new LogItemService();
            duplicateErrorsLabel.Text = logItemService.CountDuplicateErrors(item.Tag.ToString()).ToString();
            uniqueErrorLabel.Text = logItemService.CountUniqueErrors(item.Tag.ToString()).ToString();
        }

        private void listViewSourceChanged()
        {

        }

        private void createArchiveButton_Click(object sender, EventArgs e)
        {
            var resp = new LogFileService().ZipFiles(new List<string> { selectedDirectory.Text },
                createArchiveFrom.Value, createArchiveTo.Value);

            MessageBox.Show(resp.message);
        }

        private void deleteArchiveButton_Click(object sender, EventArgs e)
        {
             new LogFileService().DeleteZipsByDateRange(selectedDirectory.Text,
                deleteArchiveFrom.Value, deleteArchiveTo.Value);
        }
    }
}
