namespace Practice
{
    class Node<T>{

        private T data;
        private Node<T> next;

        public Node(T data, Node<T> next){
            this.data = data;
            this.next = next;
        }
        public Node<T> Next{
            set{next = value;}
            get{return this.next;}
        }

        public T Data{
            set{this.data = value;}
            get{return this.data;}
        }
    }
}