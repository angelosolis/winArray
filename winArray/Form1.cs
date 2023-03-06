using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void calcButton_Click(object sender, EventArgs e)
        {
            int[] arr1 = textBox1.Text.Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = textBox2.Text.Split(' ').Select(int.Parse).ToArray();

            int[] intersection = getIntersection(arr1, arr2);
            int[] difference = getDifference(arr1, arr2);
            int[] symmetricalDifference = getSymmetricalDifference(arr1, arr2);
            int[] union = getUnion(arr1, arr2);

            intersectionLabel.Text = ("Intersection: " + string.Join(", ", intersection));
            differenceLabel.Text = ("Difference: " + string.Join(", ", difference));
            sDifferenceLabel.Text = ("Symmetrical Difference: " + string.Join(", ", symmetricalDifference));
            unionLabel.Text = ("Union: " + string.Join(", ", union));
        }
        public int[] getIntersection(int[] arr1, int[] arr2)
        {
            var intersection = arr1.Intersect(arr2).ToArray();
            Array.Sort(intersection);
            return intersection;

        }

        public int[] getDifference(int[] arr1, int[] arr2)
        {
            var difference = arr2.Except(arr1).ToArray();
            Array.Sort(difference);
            return difference;
        }

        public int[] getSymmetricalDifference(int[] arr1, int[] arr2)
        {
            var symmetricalDifference = arr1.Union(arr2).Except(arr1.Intersect(arr2)).ToArray();
            Array.Sort(symmetricalDifference);
            return symmetricalDifference;
        }

        public int[] getUnion(int[] arr1, int[] arr2)
        {
            var union = arr1.Union(arr2).ToArray();
            Array.Sort(union);
            return union;
        }

    }
}
