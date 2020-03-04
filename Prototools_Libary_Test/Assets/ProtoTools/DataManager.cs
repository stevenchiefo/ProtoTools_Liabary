using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace ProtoTools
{
    namespace DataManager
    {
        public class DataManager
        {
            public int hallo;

            public static T GetDataType<T>()
            {
                T key = default;
                DataManager i = new DataManager();
                if (i.GetType() == key.GetType())
                {
                    return key = i.GetType();
                }
                return key;
            }
        }

        public class GetClass<T>
        {
            public static T GetTypeOffClass(T type)
            {
                return type;
            }
        }
    }

    public class GenericList<T>
    {
        // The nested class is also generic on T.
        private class Node
        {
            // T used in non-generic constructor.
            public Node(T t)
            {
                next = null;
                data = t;
            }

            private Node next;

            public Node Next
            {
                get { return next; }
                set { next = value; }
            }

            // T as private member data type.
            private T data;

            // T as return type of property.
            public T Data
            {
                get { return data; }
                set { data = value; }
            }
        }

        private Node head;

        // constructor
        public GenericList()
        {
            head = null;
        }

        // T as method parameter type:
        public void AddHead(T t)
        {
            Node n = new Node(t);
            n.Next = head;
            head = n;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}