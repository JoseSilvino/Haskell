using System.IO;

namespace huffinho
{
    public class HuffmanTreeNode
    {
        public byte bytev;
        public int freq;
        public HuffmanTreeNode left, right;
        public HuffmanTreeNode(byte b)
        {
            bytev = b;
            freq = 0;
            left = right = null;
        }
        public HuffmanTreeNode(byte b,int freq)
        {
            bytev = b;
            this.freq = freq;
            left = right = null;
        }
        public HuffmanTreeNode(byte b,int freq,HuffmanTreeNode left,HuffmanTreeNode right)
        {
            bytev = b;
            this.freq = freq;
            this.left = left;
            this.right = right;
        }
        public static bool isLeaf(HuffmanTreeNode n) => n.left == null && n.right == null;
        public static void PrintInFile(FileStream fs,HuffmanTreeNode node)
        {
            if (node != null)
            {   
                if(isLeaf(node) && (node.bytev == (byte)'*' || node.bytev == (byte)'\\'))
                fs.WriteByte(node.bytev);
                PrintInFile(fs, node.left);
                PrintInFile(fs, node.right);
            }
        }
        public static bool operator>=(HuffmanTreeNode a,HuffmanTreeNode b)
        {
            return a.freq >= b.freq;
        }
        public static bool operator <=(HuffmanTreeNode a,HuffmanTreeNode b)
        {
            return a.freq <= b.freq;
        }
        public static bool operator< (HuffmanTreeNode a,HuffmanTreeNode b)
        {
            return a.freq < b.freq;
        }
        public static bool operator>(HuffmanTreeNode a,HuffmanTreeNode b)
        {
            return a.freq > b.freq;
        }
    }
    class HuffmanTree
    {
        public HuffmanTreeNode head;
        public HuffmanTree()
        {
            head = null;
        }
        public HuffmanTree(byte v)
        {
            head = new HuffmanTreeNode(v);
        }
        public HuffmanTree(HuffmanTreeNode hd)
        {
            head = hd;
        }
        void printHtinFile(FileStream fs)
        {
            HuffmanTreeNode.PrintInFile(fs,head);
        }
    }
}
