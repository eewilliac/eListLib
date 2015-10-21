using System;

namespace eListLib {
    public class ListIterator<T> : IIterator<T> {
        Position<T> cursor;
        List<T> currList;
        public ListIterator(List<T> aList) {
            currList = aList;
            if (aList.isEmpty()==false) {
                cursor = (Node<T>)aList.first();
            }
            else cursor = null;
        }
    
        public bool hasNext() {
            if (currList.isEmpty()) {
                return false;
            }
            return true;
        }

        public T next() {
            T returnData = cursor.element();
            cursor = currList.next(cursor);
            return returnData;
        }
    }
}
