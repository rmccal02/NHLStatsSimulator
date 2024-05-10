using NHLStatsProject;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class ListViewManager
{
    private ListView listA;
    private ListView listB;
    private ListView listC;
    

    public ListViewManager(ListView listViewA, ListView listViewB, ListView listViewC)
    {
        listA = listViewA ?? throw new ArgumentNullException(nameof(listViewA));
        listB = listViewB ?? throw new ArgumentNullException(nameof(listViewB));
        listC = listViewC ?? throw new ArgumentNullException(nameof(listViewC));
        


        // Enable drag-and-drop for all ListViews
        EnableDragAndDrop(listA);
        EnableDragAndDrop(listB);
        //EnableDragAndDrop(listC);
    }

    private void EnableDragAndDrop(ListView listView)
    {
        listView.AllowDrop = true;
        listView.ItemDrag += ListView_ItemDrag;
        listView.DragEnter += ListView_DragEnter;
        listView.DragDrop += ListView_DragDrop;
    }

    private void ListView_ItemDrag(object sender, ItemDragEventArgs e)
    {
        ListView listView = sender as ListView;
        listView.DoDragDrop(e.Item, DragDropEffects.Move);
    }

    private void ListView_DragEnter(object sender, DragEventArgs e)
    {
        e.Effect = DragDropEffects.Move;
    }

    private int previousIndexC = -1;

    private void ListView_DragDrop(object sender, DragEventArgs e)
    {
        ListView destinationListView = sender as ListView;
        

        if (e.Data.GetDataPresent(typeof(ListViewItem)))
        {
            
            ListViewItem draggedItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));

            // Get the current index in listC
            int currentIndexC = destinationListView.Items.IndexOf(draggedItem);

            // Move the item to the destination ListView
            destinationListView.Items.Add((ListViewItem)draggedItem.Clone());

            // Remove the item from the source ListView
            (draggedItem.ListView.Items).Remove(draggedItem);

            
        }
    }





}
