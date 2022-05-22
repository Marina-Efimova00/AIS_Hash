using System;
using System.Collections.Generic;
using System.Text;

namespace AIS_Hash
{
    class HashElement
    {
        private int key;
        private int value;
        private bool deleted;

        public HashElement(int key, int value)
        {
            this.key = key;
            this.value = value;
            deleted = false;
        }

        public int hash(int value)
        {
            return value % 10;
        }

        public void setDeleted()
        {
            deleted = true;
        }

        public bool isDeleted()
        {
            return deleted;
        }

        public int getKey()
        {
            return key;
        }

        public int getValue()
        {
            return value;
        }
    }
}
