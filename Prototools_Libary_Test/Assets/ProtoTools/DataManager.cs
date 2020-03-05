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
            private static BodyRigid m_BodyRigid;

            public static void Start()
            {
                GenericList<string> genericList = new GenericList<string>();
                genericList.AddHead("Hello");
                genericList.AddHead("Nein");
                foreach (string item in genericList)
                {
                    Debug.Log(item);
                }
            }

            public static Part GetDataType<T>()
            {
                T key = default;
                if (key.GetType() == m_BodyRigid.GetType())
                {
                    return m_BodyRigid;
                }
                return null;
            }
        }

        public class Part
        {
        }

        public class BodyRigid : Part
        {
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