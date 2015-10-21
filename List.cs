using System;

namespace eListLib {
    public class List<T>:IListHelpers<T> {
        private Node<T> _header;
        private Node<T> _trailer;

        public List() {
            _header = new Node<T>();
            _trailer = new Node<T>();
            _header.PostAddress = _trailer;
            _trailer.PreAddress = _header;
        }

        public Position<T> first() {
            Node<T> returnNode = _header.PostAddress;
            return returnNode;
        }
        

        public Position<T> last() {
            Node<T> returnNode = _trailer.PreAddress;
            return returnNode;
        }

        public Position<T> next(Position<T> pos) {
            Node<T> currNode = (Node<T>)pos;
            return currNode.PostAddress;
        }

        public Position<T> previous(Position<T> pos) {
            Node<T> currNode = (Node<T>)pos;
            return currNode.PreAddress;
        }

        private void addToHead(T data, Position<T> pos) {
            Node<T> frontNode = (Node<T>)pos;
            Node<T> backNode = frontNode.PostAddress;

            Node<T> newNode = new Node<T>();
            newNode.Data = data;
            newNode.PreAddress = frontNode;
            newNode.PostAddress = backNode;
            frontNode.PostAddress = newNode;
            backNode.PreAddress = newNode;
        }


        public void add(T data) {
            addToHead(data, _header);
        }

        public bool isEmpty() {
            if (_header.PostAddress == _trailer) {
                return true;
            }
            return false;
        }
        


    }
}
