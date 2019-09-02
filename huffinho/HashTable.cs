using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huffinho
{
    class par
    {
        public short novo_byte;
        public short novo_byte_tam;
        public par(short nb,short nbt)
        {
            this.novo_byte = nb;
            this.novo_byte_tam = nbt;
        }
    }
    class HashTable
    {
        public par[] table;
        public HashTable(int size)
        {
            table = new par[size];
            for (int i = 0; i < size; i++) table[i] = null;
        }
        public bool contains(int byte_original)
        {
            return table[byte_original] != null;
        }
        public void put(byte byte_or,par byte_novo) => table[byte_or] = byte_novo;
        public void put(byte byte_or,short byte_nv,short byte_tam) => put(byte_or, new huffinho.par(byte_nv, byte_tam));
        public par this[int i]
        {
            get { return table[i]; }
        }
    }
}
