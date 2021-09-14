using System;
using System.Collections.Generic;
using System.Text;

namespace GrokkingAlgoExapmles
{
    public class SimpleHashTable
    {
        private KeyValuePair<int,LinkedListNode<string>>[] internalArray;
        private const float loadFactor = 0.7f;
        private int counter = 0;

        SimpleHashTable() { }

        public SimpleHashTable(KeyValuePair<string, string> data) {
            AddItem(data);
        }

        public void AddItem(KeyValuePair<string, string> data)
        {
            int initIDX = SimpleGetHashCode(data.Key);
            if (internalArray == null)
            {
                internalArray = new KeyValuePair<int, LinkedListNode<string>>[initIDX];
                internalArray[initIDX] = new KeyValuePair<int,
                                                          LinkedListNode<string>>
                                                          (initIDX, new LinkedListNode<string>(data.Value));
            }
            else {
                var get  = internalArray[initIDX];
                if (get.Key == 0)
                    internalArray[initIDX] = new KeyValuePair<int,
                                                          LinkedListNode<string>>
                                                          (initIDX, new LinkedListNode<string>(data.Value));
                else
                {
                    bool hasMore = true;
                    LinkedListNode<string> node = get.Value;
                    
                }
            }
            counter++;
        }

        public int SimpleGetHashCode(string keyOf)
        {
            int res = 0;
            for (int i = 0; i < keyOf.Length; i++)
            {
                res += keyOf[i];
            }
            return res % 1000;
        }
    }
}
