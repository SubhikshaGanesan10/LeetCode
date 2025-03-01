using System;

public class ListNode
{
    public int val; // Node value
    public ListNode next; // Pointer to next node
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode dummy = new ListNode();
        ListNode current = dummy;
        int carry = 0;

        while (l1 != null || l2 != null || carry != 0)
        {
            int sum = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
            carry = sum / 10;
            current.next = new ListNode(sum % 10);
            current = current.next;

            l1 = l1?.next;
            l2 = l2?.next;
        }

        return dummy.next;
    }
}

namespace AddTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating first linked list: 2 -> 4 -> 3 (represents 342)
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));

            // Creating second linked list: 5 -> 6 -> 4 (represents 465)
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

            // Add numbers
            Solution solution = new Solution();
            ListNode result = solution.AddTwoNumbers(l1, l2);

            // Print result linked list
            Console.Write("Result: ");
            while (result != null)
            {
                Console.Write(result.val);
                if (result.next != null) Console.Write(" -> ");
                result = result.next;
            }

            Console.ReadLine(); // Pause console
        }
    }
}

