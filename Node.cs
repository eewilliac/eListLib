using System;

namespace eListLib {
    class Node<T>:Position<T> {
        private T _data;
        private Node<T> _preAddress;
        private Node<T> _postAddress;
        
        public T Data {
            get {
                return _data;
            }
            set {
                _data = value;
            }
        }

        public Node<T> PreAddress {
            get {
                return _preAddress;
            }
            set {
                _preAddress = value;
            }
        }

        public Node<T> PostAddress {
            get {
                return _postAddress;
            }
            set {
                _postAddress = value;
            }
        }

        public T element() {
            return _data;
        }
    }
}
