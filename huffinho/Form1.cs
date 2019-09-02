using System;
using System.IO;
using System.Windows.Forms;

namespace huffinho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Compress_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            var dialog = (op.ShowDialog());
            if(dialog == DialogResult.OK)
            {
                var fs = new FileStream(op.FileName, FileMode.Create);
                Compress_file(fs);
            }
        }
        private bool feof(FileStream f)
        {
            return f.Position == f.Length;
        }
        private void Compress_file(FileStream original)
        {
            var por = original.Position;
            int[] freqs = new int[256];
            while (!feof(original))
            {
                freqs[original.ReadByte()]++;
            }
            Heap h = new Heap(256);
            for(byte i =0; i<=(byte)255; i++) h.Push(new HuffmanTreeNode(i, freqs[i]));
            var Tree = h.CreateHuffmanTree();
            var Ht = new HashTable(256);
            SetTree(Tree.head, Ht, 0, 0);
            original.Position = por;
            byte FinalByte = 0;
            while (!feof(original))
            {
                var bt = original.ReadByte();
                var new_byte = Ht[bt].novo_byte;
                var new_size = Ht[bt].novo_byte_tam;
            }
        }
        private void SetTree(HuffmanTreeNode ht,HashTable t,short height,short value)
        {
            if (ht != null)
            {
                if (HuffmanTreeNode.isLeaf(ht)){
                    if(ht.bytev == '*' || ht.bytev == '\\')
                    {
                        height--;
                        value = (short)(value >> 1);
                    }
                    t.put(ht.bytev, value, height);
                    SetTree(ht.left, t, (short)(height + 1), (short)(value << 1));
                    SetTree(ht.right, t, (short)(height + 1), (short)((value << 1) + 1));
                }
            }
        }
        private void Decompress_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            var dialog = (op.ShowDialog());
            if (dialog == DialogResult.OK)
            {
                var fs = new FileStream(op.FileName, FileMode.Create);
                Decompress_file(fs);
            }
        }
        private void Decompress_file(FileStream original)
        {

        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
