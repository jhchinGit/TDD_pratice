using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TDD_Practice.Test
{
    public class Algorithm
    {
        #region LinkedList

        public class Node
        {
            private int data;
            public Node next;
            public Node prev;

            public Node(int data)
            {
                this.data = data;
            }
        }

        [Test]
        public void TestMethod()
        {
            Node head = new(4);
            Node nodeB = new(2);
            Node nodeC = new(3);
            Node nodeD = new(10);
            Node nodeE = new(2);

            head.next = nodeB;
            nodeB.prev = head;
            nodeB.next = nodeC;
            nodeC.prev = nodeB;
            nodeC.next = nodeD;
            nodeD.prev = nodeC;
            nodeD.next = nodeE;
            nodeE.prev = nodeD;

            Assert.AreEqual(5, CountNextNode(head));
            Assert.AreEqual(5, CountPrevNode(head));
        }

        private static int CountNextNode(Node head)
        {
            var temp = head;
            int count = 1;
            while (temp.next != null)
            {
                count++;
                temp = temp.next;
            }

            return count;
        }

        private static int CountPrevNode(Node head)
        {
            var temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }

            int count = 1;

            while (temp.prev != null)
            {
                count++;
                temp = temp.prev;
            }

            return count;
        }

        #endregion LinkedList

        #region TreeNode

        public class TreeNode
        {
            public int data;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int data)
            {
                this.data = data;
            }
        }

        [Test]
        public void TestTreeNode()
        {
            TreeNode node2 = new(2);
            TreeNode node3 = new(3);
            TreeNode node5 = new(5);
            TreeNode node6 = new(6);
            TreeNode node4 = new(4);

            node2.left = node3;
            node3.left = node5;
            node3.right = node6;
            node2.right = node4;

            Assert.AreEqual(20, FindTreeSum(node2));
        }

        private int FindTreeSum(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return root.data + FindTreeSum(root.left) + FindTreeSum(root.right);
        }

        #endregion TreeNode

        #region BinarySearch

        [Test]
        public void TestBinarySearch()
        {
            Assert.AreEqual(6, LinearSearch(new int[] { -2, 3, 4, 7, 8, 9, 11, 13 }, 11));
            Assert.AreEqual(6, AdvanceSearch(new int[] { -2, 3, 4, 7, 8, 9, 11, 13 }, 11));
            Assert.AreEqual(-1, AdvanceSearch(new int[] { -2, 3, 4, 7, 8, 9, 11, 13 }, 12));
            Assert.AreEqual(6, AdvanceSearch(new int[] { -2, 3, 4, 7, 8, 9, 11, 12, 13 }, 11));
            Assert.AreEqual(2, ShiftSearch(new int[] { 8, 9, 11, 13, -2, 3, 4, 7 }, 11));
            Assert.AreEqual(6, ShiftSearch(new int[] { -2, 3, 4, 7, 8, 9, 11, 13 }, 11));
            Assert.AreEqual(-1, ShiftSearch(new int[] { -2, 3, 4, 7, 8, 9, 11, 13 }, 12));
            Assert.AreEqual(6, ShiftSearch(new int[] { -2, 3, 4, 7, 8, 9, 11, 12, 13 }, 11));
            Assert.AreEqual(8, ShiftSearch(new int[] { 3, 4, 7, 8, 9, 11, 12, 13, -2 }, -2));
        }

        private static int LinearSearch(int[] nums, int target)
        {
            for (int index = 0; index < nums.Length; index++)
            {
                if (nums[index] == target)
                {
                    return index;
                }
            }

            return -1;
        }

        private static int AdvanceSearch(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;
            int mid = right / 2;
            while (left <= right)
            {
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }

                mid = (left + right) / 2;
            }

            return -1;
        }

        private static int ShiftSearch(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return -1;
            }

            int left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (target == nums[mid])
                {
                    return mid;
                }

                bool amBig = nums[mid] >= nums[0];
                bool targetBig = target >= nums[0];
                if (amBig == targetBig)
                {
                    if (nums[mid] < target)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                else
                {
                    if (amBig)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
            }

            return -1;
        }

        #endregion BinarySearch

        #region Quick Sort

        //[Test]
        // incomplete
        public void TestQuickSort()
        {
            int[] actualNums = { -2, 3, -1, 5, 4, -3, 0 };
            QuickSort(actualNums, 0, actualNums.Length - 1);

            CollectionAssert.AreEqual(new int[] { -2, -1, -3, 0, 4, 3, 5 }, actualNums);
        }

        private static void QuickSort(int[] nums, int l, int r)
        {
            if (l >= r)
            {
                return;
            }

            int p = Partition(nums, l, r);

            QuickSort(nums, l, p - 1);
            QuickSort(nums, p + 1, r);
        }

        private static int Partition(int[] nums, int l, int r)
        {
            int pivot = nums[r];
            int i = l - 1;

            for (int j = l; j < r - 1; j++)
            {
                if (nums[j] < pivot)
                {
                    i++;

                    int temp1 = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp1;
                }
            }

            int temp2 = nums[i + 1];
            nums[i + 1] = nums[r];
            nums[r] = temp2;

            return i + 1;
        }

        #endregion Quick Sort

        [Test]
        public void TestFibonacci()
        {
            var result = ProduceFibonacci(10);

            Assert.IsTrue(IsFibonacci(result));
        }

        private static List<int> ProduceFibonacci(int count)
        {
            List<int> result = new List<int>();

            while(count > 0)
            {
                count--;
                if (result.Count == 0)
                {
                    result.Add(0);
                    continue;
                }
                else if (result.Count == 1)
                {
                    result.Add(1);
                    continue;
                }

                result.Add(result[result.Count - 2] + result[result.Count - 1]);
            }

            return result;
        }

        private static bool IsFibonacci(List<int> list)
        {
            for (int index = 0; index < list.Count; index++)
            {
                if (!IsPerfectSquare(5 * list[index] * list[index] + 4) && 
                    !IsPerfectSquare(5 * list[index] * list[index] - 4))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsPerfectSquare(int x)
        {
            int s = (int)Math.Sqrt(x);
            return s * s == x;
        }
    }
}