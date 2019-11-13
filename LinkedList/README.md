Linked Lists
 - Dynamic data structure made up of nodes; * dynamic structure means we can allocate the required memory while the program is running
 - The dynamic data structure can expand or shrink easily during runtime
 - Unlike an array, data in a linked list is not stoed in contiguous memory locations
 - In comparison to arrays, insertions and deletions of elements is easier because there is no need to reallocate or reorganize the 
   whole lists structure
 - In arrays, insertion/deletion involves shifting of elements, while in linked lists there is no physical movement of data while
   inserting or deleting
 - We can use linked lists to implement abstract data types like list, stack, queue, *stringbuilder uses a linked list

Two disadvantages exist with the linked list
 - Efficient random access is not possible
 - Implementation requires extra memory


There are different variants of linked lists, such as:
 - single-linked-list (simplest)
 - double-linked-list
 - circular-linked-list
 - linked lists with header node



Single Linked List
 - Made up of two parts, i.e. node  | INFO | LINK |
	- info stores the data
	- link is a reference to the next node

 Ex. Single Linked List with 4 nodes	| Start |  -->  | 10 | LINK | --> | 23 | LINK | --> | 43 | LINK | --> | 12 | NULL |
 * each link is a reference to the next node
 * contains a special reference variable that always refers to the first node of the list