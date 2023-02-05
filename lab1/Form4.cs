using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HelloWorld.Information;

namespace HelloWorld
{
    public partial class Form4 : Form
    {
        string[] headers = { "Mã", "Họ tên", "Địa chỉ", "Ngày sinh", "Lớp" };
        public Form4()
        {
            InitializeComponent();
        }

       private void close(object sender, EventArgs eventArgs)
       {
            this.Close();
       }

        private void add(object sender, EventArgs eventArgs)
        {
            Information information = new Information();
            information.mssv = mssv.Text;
            information.name = name.Text;
            information.address = address.Text;
            information.dob = dob.Text;
            information.class_ = class_.Text;

            ListViewItem row = new ListViewItem();
            row.Text = information.mssv;
            row.SubItems.Add(information.name);
            row.SubItems.Add(information.address);
            row.SubItems.Add(information.dob);
            row.SubItems.Add(information.class_);

            row.Tag = information;
            itemList.Items.Add(row);
            clear(sender, eventArgs);
            rerender();
        }
        private void clear(object sender, EventArgs eventArgs)
        {
            mssv.Text = string.Empty;
            name.Text = string.Empty;
            address.Text = string.Empty;
            dob.Text = string.Empty;
            class_.Text = string.Empty;
        }

        private void listViewItemCLicked(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedItems = itemList.SelectedItems;
            if (selectedItems.Count <= 0 || selectedItems.Count > 1)
            {
                clear(sender, e);
                return;
            }
            

            var selectedItem = selectedItems[0];
            Information information = (Information)selectedItem.Tag;

            mssv.Text = information.mssv;
            name.Text = information.name;
            address.Text = information.address;
            dob.Text = information.dob;
            class_.Text = information.class_;
        }

        private void delete(object sender, EventArgs eventArgs)
        {
            if (itemList.SelectedItems.Count > 0)
            {
                var confirmation = MessageBox.Show("Want to delete?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes)
                {
                    foreach (ListViewItem itm in itemList.SelectedItems)
                    {
                        itemList.Items.RemoveAt(itm.Index);
                    }
                }
            }
        }

        private void loadForm(object sender, EventArgs eventArgs)
        {
            // Set header for ListView
            List<string> headerList = new List<string>(headers);
            headerList.ForEach(name => itemList.Columns.Add(name));

            // Set width for header when loading form
            int widthListView = itemList.Width;
            int widthHeader = widthListView / headers.Length;
            for (int i = 0; i < headers.Length; ++i)
            {
                itemList.Columns[i].Width = widthHeader;
            }

            // Set ContextMenuStrip
            ToolStripMenuItem viewlargeIconItem = new ToolStripMenuItem("Large Icon");
            viewlargeIconItem.Click += new EventHandler(viewlargeIconCLicked);
            viewlargeIconItem.ImageKey = "ilsLon";
            listViewContextMenu.Items.Add(viewlargeIconItem);


            ToolStripMenuItem viewSmallIconsItem = new ToolStripMenuItem("Small Icon");
            viewSmallIconsItem.Click += new EventHandler(viewSmallIconClicked);
            listViewContextMenu.Items.Add(viewSmallIconsItem);

            ToolStripMenuItem viewDetailItem = new ToolStripMenuItem("Detail");
            viewDetailItem.Click += new EventHandler(viewDetailClicked);
            listViewContextMenu.Items.Add(viewDetailItem);

            ToolStripMenuItem viewListItem = new ToolStripMenuItem("List");
            viewListItem.Click += new EventHandler(viewListClicked);
            listViewContextMenu.Items.Add(viewListItem);

            ToolStripMenuItem viewTitleItem = new ToolStripMenuItem("Title");
            viewTitleItem.Click += new EventHandler(viewTitleClicked);
            listViewContextMenu.Items.Add(viewTitleItem);

        }

        private void rerender()
        {
            for (int i = 0; i < itemList.Columns.Count; i++)
            {
                itemList.Columns[i].Width = -2;
                itemList.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize);
            }

        }
        private void viewlargeIconCLicked(object sender, EventArgs e)
        {
            itemList.View = View.LargeIcon;
        }
        private void viewDetailClicked(object sender, EventArgs e)
        {
            itemList.View = View.Details;
        }
        private void viewSmallIconClicked(object sender, EventArgs e)
        {
            itemList.View = View.SmallIcon;
        }
        private void viewListClicked(object sender, EventArgs e)
        {
            itemList.View = View.List;
        }
        private void viewTitleClicked(object sender, EventArgs e)
        {
            itemList.View = View.Tile;
        }

    }
}
