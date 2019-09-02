using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huffinho
{
    class Heap
    {
        HuffmanTreeNode[] heap;
        int size;
        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        public HuffmanTreeNode this[int i]
        {
            set { heap[i] = value; }
            get { return heap[i]; }
        }
        public Heap(int size)
        {
            heap = new HuffmanTreeNode[size+1];
            this.size = 0;
        }
        void swap(ref HuffmanTreeNode a,ref HuffmanTreeNode b)
        {
            var c = a;
            a = b;
            b = c;
        }
        private int getParent(int i) => i / 2;
        private int getLeft(int i) => i * 2;
        private int getRight(int i) => (i * 2) + 1;
        public  void Push(HuffmanTreeNode node)
        {
            size++;
            heap[size] = node;
            int key = size;
            int parent = getParent(key);
            while(parent>=1 && ((heap[key]) <= heap[parent]))
            {
                swap(ref heap[key], ref heap[parent]);
                key = parent;
                parent = getParent(parent);
            }
        }
        public bool empty() => size == 0;
        public HuffmanTreeNode pop()
        {
            if (!empty())
            {
                var tmp = heap[1];
                heap[1] = heap[size];
                size--;
                min_heapify(1);
                return tmp;
            }
            return null;
        }
        public void min_heapify(int i)
        {
            int lowest;
            int left, right;
            left = getLeft(i);
            right = getRight(i);
            if (right <= size && this[right] < this[i]) lowest = right;
            else lowest = i;
            if (left <= size && this[left] < this[lowest]) lowest = left;
            if (i != lowest)
            {
                swap(ref heap[i], ref heap[lowest]);
                min_heapify(lowest);
            }
        }
        public HuffmanTree CreateHuffmanTree()
        {
            HuffmanTree huff;
            while (size > 1)
            {
                var a = pop();
                var b = pop();
                var tmp = new HuffmanTreeNode((byte)'*',a.freq+b.freq,a,b);
                Push(tmp);
            }
            huff = new HuffmanTree(pop());
            return huff;
        }
    }
}
