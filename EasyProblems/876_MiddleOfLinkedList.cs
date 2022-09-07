/*
Given the head of a singly linked list, return the middle node of the linked list.
If there are two middle nodes, return the second middle node.
*/

// Attempt 1; Taken from video
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        
        List<ListNode> NodeList = new List<ListNode>();
        
        int length = 0;
        while(head != null) {
            NodeList.Add(head);
            head = head.next;
            length++;
        }
        
        return NodeList[length / 2];
    }
    
    // Time complexity O(n)
    // Space complexity O(n)
}

/* 
Runtime: 149 ms, faster than 17.39% of C# online submissions for Middle of the Linked List.
Memory Usage: 36.6 MB, less than 68.35% of C# online submissions for Middle of the Linked List.
*/

// Attempt 2; Taken from video
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        
        ListNode middle = head;
        ListNode end = head;
        
        while(end != null && end.next != null) {
            middle = middle.next;
            end = end.next.next;
        }
        
        return middle;
    }
    
    // Time complexity O(n)
    // space complexity O(1)
}

/*
Runtime: 135 ms, faster than 33.99% of C# online submissions for Middle of the Linked List.
Memory Usage: 36.3 MB, less than 91.70% of C# online submissions for Middle of the Linked List.
*/