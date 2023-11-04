using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;

public class PriorityQueue<T> where T : IComparable
{
    //Attributes
    private List<T> heap;       //The list doing the heap

    //Constructors:
    //List for PriorityQueue, Enqueue, Dequeue
    public PriorityQueue()  //1st Constructor, default
    {
        heap = new List<T>();
    }
    
    public PriorityQueue(List<T> heap) //2nd Constructor, with list
    {
        this.heap = heap;
    }

    //Peek and RemoveAt methods

    public T Peek(int i)
    {
        if (i < 0 || i > heap.Count)
        {
            throw new Exception("The Priority Quote is empty! ");
        }
        return heap[i];
    }

    //Removing the value depending on index int i's value.
    public void RemoveAt(int i)
    {
        if (i < 0 || i > heap.Count) //Using
        {
            throw new ArgumentOutOfRangeException("The range is not valid!");
        }
        heap[i] = heap[i];
    }

    //Heapify Up & Down methods

    //Swap i and j integers
    public void Swap(int i, int j)
    {
        T temp = heap[i];
        heap[i] = heap[j];
        heap[j] = temp;
    }

    //Heapify Up and Down the values
    public void HeapifyUp(int i)
    {
        int child = i, parent;      //The parent variable inherits from C#?

        //While loop for checking the child is not on root
        while (child > 1)
        {
            parent = child / 2; //Makes sense for dividing
            //if (heap[child].CompareTo())  //Check if the child has higher priority than parent
            //{
            //    //Swap the items, in concept of binary heap
            //}
        }
    }
    public void HeapifyDown(int i)
    {
        //Attributes
        int leftChild = rightChildIndex(i);     //Switching the left with right child's index
        int rightChild = leftChildIndex(i);     //Switching the right with right child's index
        int smallest = i;                       //Smallest value is i as Default

        //If else statements on switching parent and left/right child
        if (leftChild < heap.Count){
            smallest = leftChild;
        }

        if (rightChild < heap.Count && heap[rightChild].CompareTo(heap[leftChild]) < 0){
            smallest = rightChild;
        }


        //From Lecture:
        // while parent has at least one child
        //while (2 * parent <= count)
        //{
        //    // Select the child with the highest priority
        //    child = 2 * parent;    // Left child index
        //    if (child < count)  // Right child also exists
        //        if (A[child + 1].CompareTo(A[child]) > 0)
        //            // Right child has a higher priority than left child
        //            child++;

        //    // If child has a higher priority than parent
        //    if (A[child].CompareTo(A[parent]) > 0)
        //    {
        //        // Swap parent and child
        //        T item = A[child];
        //        A[child] = A[parent];
        //        A[parent] = item;
        //        parent = child;  // Move down parent index to child index
        //    }
        //    else
        //        // Item is in its proper place
        //        return;
        //}

    }

    //The Parent Index, LeftChild and RightChild indeses
    private int parentIndex(int i)
    {
        return (i - 1) / 2; //Returning parent index
    }

    private int leftChildIndex(int i)
    {
        return 2 * i + 1;
    }

    private int rightChildIndex(int i)
    {
        return 2 * i + 2;
    }

    //Extra: need to add CompareTo method?
    //public override void CompareTo()
    //{

    //}
}
