// Simple Linked List

namespace Practice
{
    class LinkedList<T>{

        private Node<T> head;
        private Node<T> queue;
        private int size = 0;

        public LinkedList(){
            this.head = null;
            this.queue = null;
        }

        public void next(){
            this.size--;
            this.head = this.head.Next;
        }

        public bool isEmpty(){
            return this.head == null;
        }

        public void add(T data){
            if(isEmpty()){
                this.head = new Node<T>(data, null);
                this.queue = this.head;
            }else{
                var tempNode = new Node<T>(data, null);
                this.queue.Next = tempNode;
                this.queue = tempNode;
            }
            this.size++;
        }

        public T getHeadValue(){
            return this.head.Data;
        }

        public int Size{
            get{return this.size;}
        }
    }
}
