﻿using System;
using System.Collections.Generic;
using System.Text;

namespace datastructures.DoubleLinkedList
{
    class Node
    {
        public int Value { get; set; }
        public Node Prev { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
            Next = null;
            Prev = null;
        }
    }
}
